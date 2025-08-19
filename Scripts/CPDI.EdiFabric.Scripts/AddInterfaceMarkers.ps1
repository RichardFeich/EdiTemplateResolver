<#
.SYNOPSIS
  Adds ITSxxx marker interfaces to TSxxx classes in .cs files.

.DESCRIPTION
  For each class declaration like:
      public (partial) class TS110 : EdiMessage[, OtherInterfaces]
  this script inserts the corresponding marker:
      public (partial) class TS110 : EdiMessage, ITS110[, OtherInterfaces]

  - Skips files where the marker already exists (e.g., ITS110).
  - Preserves other modifiers (public, partial, sealed, etc.).
  - Works whether '{' is on the same line or next line.
  - Supports -WhatIf / -Confirm and optional backups.

.EXAMPLE
  .\AddInterfaceMarkers.ps1 -Path C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12 -Include 'EF_X12_*.cs' -Recurse -WhatIf
  .\AddInterfaceMarkers.ps1 -Path C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.EdiFabric.Templates.Acme\X12 -Include 'EF_X12_*.cs' -Recurse -WhatIf

.EXAMPLE
  .\AddInterfaceMarkers.ps1 -Path 'C:\Proj\Templates' -Backup
#>

[CmdletBinding(SupportsShouldProcess = $true)]
param(
  [Parameter(Mandatory = $true)]
  [ValidateNotNullOrEmpty()]
  [string]$Path,

  # Which files to process (wildcards ok)
  [string[]]$Include = @('*.cs'),

  # Recurse into subfolders
  [switch]$Recurse,

  # Create a .bak alongside each modified file
  [switch]$Backup
)

if (-not (Test-Path -LiteralPath $Path)) {
  throw "Path not found: $Path"
}

# Matches a single line with a class TS### and its base list (up to but not including '{' or EOL).
# Captures the transaction number (ts) and the existing base list (bases).
# Keeps the entire line prefix (prefix) so we can reconstruct cleanly.
$pattern = '(?m)^(?<prefix>[^\r\n]*\bclass\s+TS(?<ts>\d{3})\s*:\s*)(?<bases>[^{\r\n]+)'

$files = Get-ChildItem -LiteralPath $Path -File -Include $Include -Recurse:$Recurse -ErrorAction Stop
$changed = 0
$skipped = 0

foreach ($f in $files) {
  $original = Get-Content -LiteralPath $f.FullName -Raw
  $updated = [regex]::Replace($original, $pattern, {
    param($m)
    $ts = $m.Groups['ts'].Value
    $bases = $m.Groups['bases'].Value
    $prefix = $m.Groups['prefix'].Value

    # If the correct ITS marker is already present, leave as-is.
    if ($bases -match ("\bITS$ts\b")) {
      return $m.Value
    }

    # Insert the marker after EdiMessage if present; otherwise append to the base list.
    $newBases = $bases
    if ($bases -match '\bEdiMessage\b') {
      # Replace the FIRST occurrence of 'EdiMessage' with 'EdiMessage, ITS###'
      $newBases = [regex]::Replace($bases, '\bEdiMessage\b', "EdiMessage, ITS$ts", 1)
    } else {
      $newBases = ($bases.TrimEnd()) + ", ITS$ts"
    }

    return $prefix + $newBases
  })

  if ($updated -ne $original) {
    $action = "Add ITS markers -> $($f.FullName)"
    if ($PSCmdlet.ShouldProcess($f.FullName, $action)) {
      if ($Backup) {
        $bak = $f.FullName + '.bak'
        Copy-Item -LiteralPath $f.FullName -Destination $bak -Force
      }
      # Preserve UTF8; adjust if you need a different encoding
      Set-Content -LiteralPath $f.FullName -Value $updated -Encoding UTF8
      Write-Host "Updated: $($f.FullName)"
      $changed++
    }
  } else {
    $skipped++
  }
}

Write-Host ""
Write-Host "Done." -ForegroundColor Green
Write-Host "  Files updated : $changed"
Write-Host "  Files skipped : $skipped"
Write-Host ""

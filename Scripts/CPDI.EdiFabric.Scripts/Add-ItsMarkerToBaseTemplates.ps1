<#
.SYNOPSIS
  In base templates (namespace ends with ...X12_<ver>), add the matching ITSxxx marker
  to classes that inherit EdiMessage. Example: TS810 : EdiMessage -> TS810 : EdiMessage, ITS810

.EXAMPLE
  .\Script3.ps1 -Path C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12 -FileNamePatterns @('EF_X12_*.cs') -NoBackup -DryRun

.EXAMPLE
  # If you don't have a using for the marker namespace, fully-qualify it:
  .\Add-ItsMarkerToBaseTemplates.ps1 -Path .\src\Templates.Base\X12 `
    -InterfacePrefix 'CPDI.Edi.X12.Abstractions.IT'

    .\Add-ItsMarkerToBaseTemplates.ps1 `
  -Path 'C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12\002040' `
  -FileNamePatterns 'EF_X12_002040_*.cs' `
  -DryRun
#>
[CmdletBinding(SupportsShouldProcess = $true)]
param(
  # Root folder to scan
  [Parameter()][ValidateScript({ Test-Path $_ -PathType Container })]
  [string]$Path = ".",

  # File name filter(s)
  [string[]]$FileNamePatterns = @('TS*.cs','EF_X12_*.cs'),

  # Optional prefix to fully-qualify the interface (e.g., 'CPDI.Edi.X12.Abstractions.IT').
  # Leave empty if your files already 'using' the marker namespace.
  [string]$InterfacePrefix = '',

  # Preview only (no writes)
  [switch]$DryRun,

  # Don’t create .bak backups
  [switch]$NoBackup
)

$regexOptions = [System.Text.RegularExpressions.RegexOptions]::Multiline

# Detect file namespace: namespace <ns>
$nsRegex  = '^\s*namespace\s+(?<ns>[A-Za-z0-9_\.]+)'
# Base namespace must end exactly with ".X12_<6digits>" (no partner segment)
$baseNsRx = '^(?<root>.+)\.X12_(?<ver>\d{6})$'

# Match classes that inherit EdiMessage (qualified or not). Capture any trailing interfaces.
# e.g., class TS810 : EdiMessage, IFoo
$patternEdiMessage = 'class\s+(TS(?<code>\d+))\s*:\s*(?:(?:\w+\.)*EdiMessage)(?<rest>(\s*,\s*[^:{]+)*)'

# Build file list
$files = $FileNamePatterns |
  ForEach-Object {
    Get-ChildItem -Path $Path -Filter $_ -Recurse -File -ErrorAction SilentlyContinue
  } | Sort-Object -Property FullName -Unique

if (-not $files) {
  Write-Host "No files matched $($FileNamePatterns -join ', ') under '$Path'."
  return
}

$scanned = 0
$updated = 0

foreach ($f in $files) {
  $scanned++
  $text = Get-Content -LiteralPath $f.FullName -Raw

  # Only operate on BASE templates (namespace ends with ...X12_<ver>)
  $nsMatch = [regex]::Match($text, $nsRegex, $regexOptions)
  if (-not $nsMatch.Success) { continue }
  $ns = $nsMatch.Groups['ns'].Value
  if (-not [regex]::IsMatch($ns, $baseNsRx)) { continue }

  $original = $text
  $prefix   = $InterfacePrefix  # capture for closure

  $new = [System.Text.RegularExpressions.Regex]::Replace(
    $text, $patternEdiMessage,
    {
      param($m)
      $name = $m.Groups[1].Value      # TS810
      $code = $m.Groups['code'].Value # 810
      $rest = $m.Groups['rest'].Value # ", IFoo" or empty

      # Build the marker name: ITS810 or Fully.Qualified.Namespace.IT810
      $iface = if ([string]::IsNullOrWhiteSpace($prefix)) { "ITS$code" } else { "$prefix$code" }

      # If the marker already exists in the base/interface list, keep as-is
      $existsPattern = "(^|,)\s*" + [regex]::Escape($iface) + "(\s*(,|$))"
      if ($rest -match $existsPattern) {
        "class $name : EdiMessage$rest"
      }
      else {
        # Append after any existing interfaces
        $append = if ([string]::IsNullOrWhiteSpace($rest)) { ", $iface" } else { "$rest, $iface" }
        "class $name : EdiMessage$append"
      }
    },
    $regexOptions
  )

  if ($new -ne $original) {
    if ($DryRun) {
      Write-Host "[DRY] Would update $($f.FullName)"
      $updated++
    } else {
      if (-not $NoBackup) {
        Copy-Item -LiteralPath $f.FullName -Destination "$($f.FullName).bak" -Force -ErrorAction SilentlyContinue
      }
      if ($PSCmdlet.ShouldProcess($f.FullName, "Add matching ITSxxx marker to EdiMessage base")) {
        Set-Content -LiteralPath $f.FullName -Value $new
        Write-Host "Updated $($f.FullName)"
        $updated++
      }
    }
  }
}

Write-Host "Scanned: $scanned file(s). Updated: $updated file(s)."

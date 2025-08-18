<# 
.SYNOPSIS
  Replace ': EdiMessage[, ...]' with ': <BaseNamespace>.TSxxx[, ...]' for TS classes.

.EXAMPLE
  .\Set-TsBaseClass.ps1 -Path .\src\Templates.Partner.Acme -BaseNamespace 'Company.Edi.Templates.X12_004010' -DryRun
  .\Set-TsBaseClass.ps1 -Path .\src\Templates -FileNamePatterns 'EF_X12_*.cs'
    .\Script1.ps1 -Path C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12  -BaseNamespace 'CPDI.EdiFabric.Templates.Base.X12002040' -DryRun -NoBackup -FileNamePatterns 'EF_X12_*.cs'
#>

<#
.SYNOPSIS
  Replace ': EdiMessage[, ...]' with ': <BaseNamespace>.TSxxx[, ...]' for TS classes.

.EXAMPLE
  .\Set-TsBaseClass.ps1 -Path .\src\Templates.Partner.Acme `
    -BaseNamespace 'Company.Edi.Templates.X12_004010' `
    -FileNamePatterns 'EF_X12_*.cs' `
    -DryRun

.EXAMPLE
  .\Set-TsBaseClass.ps1 -Path .\src\Templates.Partner.Acme `
    -BaseNamespace 'CPDI.EdiFabric.Templates.Base.X12_002040' `
    -FileNamePatterns @('TS*.cs','EF_X12_*.cs')
#>

[CmdletBinding(SupportsShouldProcess = $true)]
param(
  # Folder to scan recursively
  [Parameter()]
  [ValidateScript({ Test-Path $_ -PathType Container })]
  [string]$Path = ".",

  # Base namespace that contains the canonical TSxxx classes
  [Parameter(Mandatory = $true)]
  [string]$BaseNamespace,

  # File name filter(s)
  [string[]]$FileNamePatterns = @('TS*.cs','EF_X12_*.cs'),

  # Preview only (no writes)
  [switch]$DryRun,

  # Don’t create .bak backups
  [switch]$NoBackup
)

# Match: class TS123 : EdiMessage [, ...interfaces]
# Accepts fully-qualified EdiMessage too (e.g., EdiFabric.Core.Model.Edi.EdiMessage)
$pattern      = 'class\s+(TS(?<code>\d+))\s*:\s*(?:(?:\w+\.)*EdiMessage)(?<rest>(\s*,\s*[^:{]+)*)'
$regexOptions = [System.Text.RegularExpressions.RegexOptions]::Multiline

# Build the file list safely (avoid "empty pipe element")
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

  if ($text -match $pattern) {
    # capture the base namespace into a local for the callback closure
    $bn = $BaseNamespace

    $new = [System.Text.RegularExpressions.Regex]::Replace(
      $text, $pattern,
      {
        param($m)
        $name = $m.Groups[1].Value      # e.g., TS850
        $rest = $m.Groups['rest'].Value # e.g., ", ITS850"
        "class $name : $bn.$name$rest"
      },
      $regexOptions
    )

    if ($new -ne $text) {
      if ($DryRun) {
        Write-Host "[DRY] Would update $($f.FullName)"
        $updated++
      }
      else {
        if (-not $NoBackup) {
          Copy-Item -LiteralPath $f.FullName -Destination "$($f.FullName).bak" -Force -ErrorAction SilentlyContinue
        }
        if ($PSCmdlet.ShouldProcess($f.FullName, "Set base type(s) to $BaseNamespace.TSxxx")) {
          Set-Content -LiteralPath $f.FullName -Value $new
          Write-Host "Updated $($f.FullName)"
          $updated++
        }
      }
    }
  }
}

Write-Host "Scanned: $scanned file(s). Updated: $updated file(s)."




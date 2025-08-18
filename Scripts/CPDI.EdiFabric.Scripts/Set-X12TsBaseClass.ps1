<# 
.SYNOPSIS
  Rewrites TSxxx classes to inherit from your base templates (e.g., Company.Edi.Templates.X12_004010.TS850).

.EXAMPLE
Target a specific folder, infer version from filename:

.\Set-X12TsBaseClass.ps1 -Path .\src\Templates.Partner.Acme -FileNamePattern 'EF_X12_*.cs' -InferBaseFromFileName


.EXAMPLE
Force a specific base namespace (ignore filename version):
.\Set-X12TsBaseClass.ps1 -Path C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12 -BaseNamespace 'EdiFabric.Templates.X12002040' -DryRun


.EXAMPLE
.\Set-X12TsBaseClass.ps1 -Path .\src\Templates -InferBaseFromFileName -DryRun


#>

<# 
.SYNOPSIS
  Rewrites TSxxx classes to inherit from your base templates, targeting files like EF_X12_002040_810.cs.
#>

[CmdletBinding(SupportsShouldProcess = $true)]
param(
  # Folder to scan (recursively)
  [Parameter()]
  [ValidateScript({ Test-Path $_ -PathType Container })]
  [string]$Path = ".",

  # Default base namespace (used if inference fails or is disabled)
  [string]$BaseNamespace = 'Company.Edi.Templates.X12_004010',

  # File name pattern for your templates
  [string]$FileNamePattern = 'EF_X12_*.cs',

  # Try to infer base namespace from the file name (e.g., EF_X12_002040_810.cs -> Company.Edi.Templates.X12_002040)
  [switch]$InferBaseFromFileName,

  # Preview only (no writes)
  [switch]$DryRun,

  # Don’t create .bak backups
  [switch]$NoBackup
)

# class TS123 : EdiMessage [, ...interfaces]
# Accepts fully-qualified EdiMessage as well
$pattern      = 'class\s+(TS(?<code>\d+))\s*:\s*(?:(?:\w+\.)*EdiMessage)(?<rest>(\s*,\s*[^:{]+)*)'
$regexOptions = [System.Text.RegularExpressions.RegexOptions]::Multiline

# Filename regex: EF_X12_002040_810.cs -> ver=002040, st=810
$fnameRegex = '^EF_X12_(?<ver>\d{6})_(?<st>\d{3,4})\.cs$'

$files   = Get-ChildItem -Path $Path -Filter $FileNamePattern -Recurse -File
$scanned = 0
$updated = 0

foreach ($f in $files) {
  $scanned++

  # Decide base namespace for this file
  $currentBaseNs = $BaseNamespace
  if ($InferBaseFromFileName -and ($f.Name -match $fnameRegex)) {
    $ver = $Matches['ver']
    # Your base namespaces follow X12_<version> with 6 digits (e.g., 004010, 002040)
    $currentBaseNs = "Company.Edi.Templates.X12_$ver"
  }

  $text = Get-Content -LiteralPath $f.FullName -Raw
  if ($text -match $pattern) {
    # Capture per-file base namespace via closure
    $localBaseNs = $currentBaseNs

    $new = [System.Text.RegularExpressions.Regex]::Replace(
      $text, $pattern,
      {
        param($m)
        $name = $m.Groups[1].Value      # TS850
        $rest = $m.Groups['rest'].Value # ", ITS850" etc.
        "class $name : $localBaseNs.$name$rest"
      },
      $regexOptions
    )

    if ($new -ne $text) {
      if ($DryRun) {
        Write-Host "[DRY] Would update $($f.FullName) -> base '$currentBaseNs'"
        $updated++
      }
      else {
        if ($PSCmdlet.ShouldProcess($f.FullName, "Set base type to $currentBaseNs.<TS>")) {
          if (-not $NoBackup) {
            Copy-Item -LiteralPath $f.FullName -Destination "$($f.FullName).bak" -Force -ErrorAction SilentlyContinue
          }
          Set-Content -LiteralPath $f.FullName -Value $new -NoNewline
          Write-Host "Updated $($f.FullName) -> base '$currentBaseNs'"
          $updated++
        }
      }
    }
  }
}

Write-Host "Scanned: $scanned file(s). Updated: $updated file(s)."



<#
.SYNOPSIS
  For base template files (namespace ...X12_<ver> with no partner suffix), ensure:
    class TSxxx : EdiMessage[, interfaces]

.EXAMPLE
  .\Set-BaseTsToEdiMessage.ps1 -Path .\src\Templates.Base\X12 -FileNamePatterns @('TS*.cs','EF_X12_*.cs') -DryRun
  .\Script1.ps1 -Path C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12 -FileNamePatterns @('TS*.cs','EF_X12_*.cs') -BaseNamespace 'CPDI.EdiFabric.Templates.Base.X12002040' -DryRun
#>

[CmdletBinding(SupportsShouldProcess = $true)]
param(
  [Parameter()][ValidateScript({ Test-Path $_ -PathType Container })]
  [string]$Path = ".",

  # Which files to scan
  [string[]]$FileNamePatterns = @('TS*.cs','EF_X12_*.cs'),

  [switch]$DryRun,
  [switch]$NoBackup
)

# 1) Helpers / regex
$regexOptions = [System.Text.RegularExpressions.RegexOptions]::Multiline

# namespace Company.Edi.Templates.X12_004010  (no trailing .Partner)
$nsRegex    = '^\s*namespace\s+(?<ns>[A-Za-z0-9_\.]+)'
$baseNsRx   = '^(?<root>.+)\.X12_(?<ver>\d{6})$'  # base = ends at version (no extra segment)

# class TS123 : Company.Edi.Templates.X12_004010.TS123 [, interfaces]
$patternBaseTs = 'class\s+(TS(?<code>\d+))\s*:\s*[\w\.]+\.X12_\d{6}\.TS\k<code>(?<rest>(\s*,\s*[^:{]+)*)'

# class TS123 : <anything>.EdiMessage [, interfaces]  -> normalize to plain EdiMessage
$patternAnyEdiMessage = 'class\s+(TS(?<code>\d+))\s*:\s*(?:(?:\w+\.)*EdiMessage)(?<rest>(\s*,\s*[^:{]+)*)'

# 2) Build file list
$files = $FileNamePatterns |
  ForEach-Object {
    Get-ChildItem -Path $Path -Filter $_ -Recurse -File -ErrorAction SilentlyContinue
  } | Sort-Object -Property FullName -Unique

if (-not $files) { Write-Host "No files matched $($FileNamePatterns -join ', ') under '$Path'."; return }

$scanned = 0
$updated = 0

foreach ($f in $files) {
  $scanned++
  $text = Get-Content -LiteralPath $f.FullName -Raw

  # Detect if file is a BASE template (namespace ends with ...X12_<ver>)
  $nsMatch = [regex]::Match($text, $nsRegex, $regexOptions)
  if (-not $nsMatch.Success) { continue }

  $ns = $nsMatch.Groups['ns'].Value
  $isBase = [regex]::IsMatch($ns, $baseNsRx)
  if (-not $isBase) { continue }   # skip partner templates

  $original = $text
  $changed  = $false

  # A) If inherits from a base TS (fully-qualified), switch to EdiMessage
  $text = [regex]::Replace($text, $patternBaseTs, {
    param($m)
    $name = $m.Groups[1].Value
    $rest = $m.Groups['rest'].Value
    $changed = $true
    "class $name : EdiMessage$rest"
  }, $regexOptions)

  # B) Normalize any qualified EdiMessage (Optional but tidy):
  $text = [regex]::Replace($text, $patternAnyEdiMessage, {
    param($m)
    $name = $m.Groups[1].Value
    $rest = $m.Groups['rest'].Value
    # If already exactly 'EdiMessage', this is a no-op; otherwise, normalize
    $changed = $true
    "class $name : EdiMessage$rest"
  }, $regexOptions)

  if ($changed -and $text -ne $original) {
    if ($DryRun) {
      Write-Host "[DRY] Would update $($f.FullName) -> ': EdiMessage...'"
      $updated++
    } else {
      if (-not $NoBackup) {
        Copy-Item -LiteralPath $f.FullName -Destination "$($f.FullName).bak" -Force -ErrorAction SilentlyContinue
      }
      if ($PSCmdlet.ShouldProcess($f.FullName, "Normalize TS base type to EdiMessage")) {
        Set-Content -LiteralPath $f.FullName -Value $text
        Write-Host "Updated $($f.FullName)"
        $updated++
      }
    }
  }
}

Write-Host "Scanned: $scanned file(s). Updated: $updated file(s)."

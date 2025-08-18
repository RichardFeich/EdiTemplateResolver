# Add-ItsMarker-Min.ps1
#C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12\002040
# .\Add-ItsMarker-Min.ps1 'C:\Projects\CPDI_EDI\src\TemplateResolver\Templates\CPDI.Edi.Templates.Base\X12' -Pattern 'EF_X12_*.cs'
param(
  [string]$Path = ".",
  [string]$Pattern = "*.cs"
)

$rx = 'class\s+(TS(?<code>\d+))\s*:\s*(?:(?:\w+\.)*EdiMessage)(?<rest>(\s*,\s*[^:{]+)*)'
$opts = [System.Text.RegularExpressions.RegexOptions]::Multiline

Get-ChildItem -Path $Path -Filter $Pattern -Recurse -File | ForEach-Object {
  $text = Get-Content -LiteralPath $_.FullName -Raw

  $new = [regex]::Replace($text, $rx, {
    param($m)
    $name = $m.Groups[1].Value      # TS822
    $code = $m.Groups['code'].Value # 822
    $rest = $m.Groups['rest'].Value # ", IFoo" or empty

    # Already has ITSxxx? leave unchanged
    if ($rest -match "(^|,)\s*ITS$code(\s*(,|$))") { return $m.Value }

    $append = if ([string]::IsNullOrWhiteSpace($rest)) { ", ITS$code" } else { "$rest, ITS$code" }
    "class $name : EdiMessage$append"
  }, $opts)

  if ($new -ne $text) {
    Set-Content -LiteralPath $_.FullName -Value $new
    Write-Host "Updated $($_.FullName)"
  }
}

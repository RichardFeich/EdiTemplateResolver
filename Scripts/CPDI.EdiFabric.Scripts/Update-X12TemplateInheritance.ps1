# Run from the solution root
$baseNs = 'Company.Edi.Templates.X12_004010'

Get-ChildItem -Recurse -Include TS*.cs -File |
  ForEach-Object {
    $text = Get-Content $_.FullName -Raw

    # Match: class TS123 : EdiMessage [, ...interfaces]
    $pattern = 'class\s+(TS(?<code>\d+))\s*:\s*EdiMessage(?<rest>(\s*,\s*[^:{]+)*)'
    if ($text -match $pattern) {
      $new = [System.Text.RegularExpressions.Regex]::Replace(
        $text, $pattern,
        { param($m)
          $name = $m.Groups[1].Value   # TS850
          $rest = $m.Groups['rest'].Value
          "class $name : $baseNs.$name$rest"
        },
        [System.Text.RegularExpressions.RegexOptions]::Multiline
      )

      if ($new -ne $text) {
        Copy-Item $_.FullName "$($_.FullName).bak" -ErrorAction SilentlyContinue
        Set-Content $_.FullName $new -NoNewline
        Write-Host "Updated $($_.FullName)"
      }
    }
  }

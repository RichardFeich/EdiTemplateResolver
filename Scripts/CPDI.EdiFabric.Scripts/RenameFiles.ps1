<#
.SYNOPSIS
  Rename X12 template files by changing the version token in the filename.

.EXAMPLE
  .\RenameFiles.ps1 -Path "C:\Projects\Templates" -WhatIf

.EXAMPLE
  .\RenameFiles.ps1 -Path . -FromVersion 004010 -ToVersion 004000 -Recurse

.NOTES
  - Only renames when the exact FromVersion appears between underscores in the name.
  - Defaults FromVersion=004010, ToVersion=004000, current directory, non-recursive.
#>

[CmdletBinding(SupportsShouldProcess = $true)]
param(
  [Parameter(Mandatory = $true)]
  [ValidateNotNullOrEmpty()]
  [string]$Path,

  [ValidatePattern('^\d{6}$')]
  [string]$FromVersion = '004010',

  [ValidatePattern('^\d{6}$')]
  [string]$ToVersion   = '004000',

  [switch]$Recurse
)

if (-not (Test-Path -LiteralPath $Path)) {
  throw "Path not found: $Path"
}

# Match the exact 6-digit version only when it's BETWEEN underscores
$pattern = '(?<=_)' + [regex]::Escape($FromVersion) + '(?=_)'

$renamed = 0
$skipped = 0
$conflict = 0

Get-ChildItem -Path $Path -File -Filter '*.cs' -Recurse:$Recurse | ForEach-Object {
  $oldName = $_.Name

  if (-not [regex]::IsMatch($oldName, $pattern)) {
    $skipped++
    return
  }

  $newName = [regex]::Replace($oldName, $pattern, $ToVersion)
  if ($newName -eq $oldName) {
    $skipped++
    return
  }

  $newPath = Join-Path -Path $_.DirectoryName -ChildPath $newName

  if (Test-Path -LiteralPath $newPath) {
    Write-Warning "Skip (target exists): '$($._.FullName)' -> '$newPath'"
    $conflict++
    return
  }

  $action = "Rename '$oldName' -> '$newName'"
  if ($PSCmdlet.ShouldProcess($_.FullName, $action)) {
    Rename-Item -LiteralPath $_.FullName -NewName $newName
    $renamed++
  }
}

Write-Host ""
Write-Host "Done." -ForegroundColor Green
Write-Host "  Renamed : $renamed"
Write-Host "  Skipped : $skipped"
Write-Host "  Conflicts (existing target): $conflict"
Write-Host ""

# Tips:
# - First run with -WhatIf to preview changes without modifying files.
# - Add -Recurse to process subdirectories.


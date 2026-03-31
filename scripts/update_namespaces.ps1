# Run from solution root
Set-StrictMode -Version Latest
$root = Get-Location
$backup = Join-Path $root ".namespace_backup"
if (-not (Test-Path $backup)) { New-Item -ItemType Directory -Path $backup | Out-Null }

function Backup-File($path) {
    if (Test-Path $path) {
        $rel = $path.Substring($root.Path.Length).TrimStart('\')
        $dest = Join-Path $backup $rel
        $dir = Split-Path $dest -Parent
        if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        Copy-Item -LiteralPath $path -Destination $dest -Force
    }
}

function Replace-InFile($path, $pattern, $replacement) {
    if (-not (Test-Path $path)) { return }
    Backup-File $path
    $text = Get-Content -Raw -LiteralPath $path
    $new = [regex]::Replace($text, $pattern, $replacement, 'Multiline')
    if ($new -ne $text) {
        Set-Content -LiteralPath $path -Value $new
        Write-Host "Updated: $path"
    }
}

# Update .cs and .Designer.cs files
Get-ChildItem -Path $root -Include *.cs -Recurse | ForEach-Object {
    $file = $_.FullName
    $norm = $file.Replace('/','\')
    if ($norm -match '\\Forms\\Auth\\') {
        # Forms.Auth
        Replace-InFile $file 'namespace\s+Project_FinancePersonalManagement\b' 'namespace Project_FinancePersonalManagement.Forms.Auth'
    } elseif ($norm -match '\\Forms\\') {
        # Forms (but not Auth)
        Replace-InFile $file 'namespace\s+Project_FinancePersonalManagement\b' 'namespace Project_FinancePersonalManagement.Forms'
    } elseif ($norm -match '\\Data\\') {
        # Data
        Replace-InFile $file 'namespace\s+Project_FinancePersonalManagement\b' 'namespace Project_FinancePersonalManagement.Data'
    }
}

Write-Host "Namespace update complete. Backup of changed files is in .namespace_backup"
Write-Host "Next steps:"
Write-Host "  1) Inspect changes (git diff or open files)"
Write-Host "  2) Build solution in Visual Studio and fix any remaining references"
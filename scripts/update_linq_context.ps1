# Run from solution root: .\scripts\update_linq_context.ps1
Set-StrictMode -Version Latest
$root = Get-Location
$backup = Join-Path $root ".linqctx_backup"
if (-not (Test-Path $backup)) { New-Item -ItemType Directory -Path $backup | Out-Null }

function Backup-File($path) {
    $rel = Resolve-Path $path
    $dest = Join-Path $backup ($rel.Path.Substring($root.Path.Length).TrimStart('\'))
    $dir = Split-Path $dest -Parent
    if (-not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
    Copy-Item -LiteralPath $path -Destination $dest -Force
}

function Insert-UsingIfMissing([string]$text, [string]$usingLine) {
    if ($text -match [regex]::Escape($usingLine)) { return $text }
    # find last using statement block and insert after it. If none, insert at top.
    $lines = $text -split "`r?`n"
    $lastUsingIndex = -1
    for ($i = 0; $i -lt $lines.Length; $i++) {
        if ($lines[$i] -match '^\s*using\s+[A-Za-z0-9_.]+\s*;') { $lastUsingIndex = $i }
        elseif ($lastUsingIndex -ge 0 -and $lines[$i] -match '^\s*$') { break }
    }
    if ($lastUsingIndex -ge 0) {
        $insertAt = $lastUsingIndex + 1
        $newLines = $lines[0..($insertAt-1)] + @($usingLine) + $lines[$insertAt..($lines.Length-1)]
    } else {
        $newLines = @($usingLine) + $lines
    }
    return ($newLines -join "`r`n")
}

# Regex patterns
$typePattern = '\b[A-Za-z_][A-Za-z0-9_]*DataContext\b'
$newType = 'AppDatabaseDataContext'
$usingLine = 'using Project_FinancePersonalManagement.Data;'

# Process all .cs files except obj/bin and the script itself
Get-ChildItem -Path $root -Include *.cs -Recurse | Where-Object {
    $_.FullName -notmatch '\\(bin|obj)\\' -and $_.FullName -notmatch '\\.linqctx_backup\\' -and $_.FullName -notmatch '\\scripts\\update_linq_context.ps1$'
} | ForEach-Object {
    $file = $_.FullName
    $text = Get-Content -Raw -LiteralPath $file

    # skip files that are in Data namespace file that define AppDatabaseDataContext itself
    if ($text -match 'class\s+AppDatabaseDataContext\b') {
        Write-Host "Skipping context definition file: $file"
        return
    }

    $original = $text
    $modified = $text

    # Replace any type name ending with DataContext with new type
    $modified = [regex]::Replace($modified, $typePattern, $newType)

    # Also replace "new <old>DataContext(" patterns robustly (already handled by previous replace)
    $modified = [regex]::Replace($modified, 'new\s+' + [regex]::Escape($newType) + '\s*\(', 'new ' + $newType + '(')

    # Insert using for Data namespace if not present but only if the file references AppDatabaseDataContext now
    if ($modified -match '\b' + [regex]::Escape($newType) + '\b' -and $modified -notmatch [regex]::Escape($usingLine)) {
        $modified = Insert-UsingIfMissing $modified $usingLine
    }

    if ($modified -ne $original) {
        Backup-File $file
        Set-Content -LiteralPath $file -Value $modified
        Write-Host "Updated: $file"
    }
}

Write-Host "`nDone. Backups are in .linqctx_backup. Please:"
Write-Host "  1) Inspect changes with git diff or open files in Visual Studio."
Write-Host "  2) Build the solution and fix any remaining references (fully-qualified names, reflection, strings)."
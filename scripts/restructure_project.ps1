# Run from solution root
# Usage: .\restructure_project.ps1
Set-StrictMode -Version Latest

$root = Get-Location
$backupDir = Join-Path $root ".refactor_backup"
Write-Host "Root: $root"
Write-Host "Backup directory: $backupDir"

# Create backup
if (-Not (Test-Path $backupDir)) {
    New-Item -ItemType Directory -Path $backupDir | Out-Null
}

# Helper: backup a file
function Backup-File($path) {
    if (Test-Path $path) {
        $dest = Join-Path $backupDir (Resolve-Path $path).Path.Substring($root.Path.Length).TrimStart('\')
        $dir = Split-Path $dest -Parent
        if (-Not (Test-Path $dir)) { New-Item -ItemType Directory -Path $dir -Force | Out-Null }
        Copy-Item -Path $path -Destination $dest -Force
    }
}

# Create target folders
$formsDir = Join-Path $root "Forms"
$authDir = Join-Path $formsDir "Auth"
$dataDir = Join-Path $root "Data"
foreach ($d in @($formsDir, $authDir, $dataDir)) {
    if (-Not (Test-Path $d)) { New-Item -ItemType Directory -Path $d | Out-Null }
}

# File rename/move mapping (relative to root)
$mappings = @{
    "form_GiaoDich.cs" = "Forms\FrmGiaoDich.cs"
    "form_GiaoDich.Designer.cs" = "Forms\FrmGiaoDich.Designer.cs"

    "form_KhoanVay_ChoVay.cs" = "Forms\FrmKhoanVayChoVay.cs"
    "form_KhoanVay_ChoVay.Designer.cs" = "Forms\FrmKhoanVayChoVay.Designer.cs"

    "Form_Menu.cs" = "Forms\FrmMenu.cs"
    "Form_Menu.Designer.cs" = "Forms\FrmMenu.Designer.cs"

    "form_TaiKhoan.cs" = "Forms\FrmTaiKhoan.cs"
    "form_TaiKhoan.Designer.cs" = "Forms\FrmTaiKhoan.Designer.cs"

    "form_ThongKe.cs" = "Forms\FrmThongKe.cs"
    "form_ThongKe.Designer.cs" = "Forms\FrmThongKe.Designer.cs"

    "frm_danhMuc.cs" = "Forms\FrmDanhMuc.cs"
    "frm_danhMuc.Designer.cs" = "Forms\FrmDanhMuc.Designer.cs"

    "frm_nganSach.cs" = "Forms\FrmNganSach.cs"
    "frm_nganSach.Designer.cs" = "Forms\FrmNganSach.Designer.cs"
}

# Move and rename files
foreach ($kv in $mappings.GetEnumerator()) {
    $src = Join-Path $root $kv.Key
    $dst = Join-Path $root $kv.Value
    if (Test-Path $src) {
        Backup-File $src
        $dstDir = Split-Path $dst -Parent
        if (-Not (Test-Path $dstDir)) { New-Item -ItemType Directory -Path $dstDir -Force | Out-Null }
        Move-Item -Path $src -Destination $dst -Force
        Write-Host "Moved: $src -> $dst"
    } else {
        Write-Host "Not found (skipped): $src"
    }
}

# Move sign_in_and_sign_up to Forms/Auth if exists
$oldAuth = Join-Path $root "sign_in_and_sign_up"
if (Test-Path $oldAuth) {
    $newAuth = Join-Path $authDir "sign_in_and_sign_up"
    Backup-File $oldAuth
    Move-Item -Path $oldAuth -Destination $newAuth -Force
    Write-Host "Moved auth folder: $oldAuth -> $newAuth"
} else {
    Write-Host "No sign_in_and_sign_up folder found (skipped)"
}

# Move DB_System.* files to Data
Get-ChildItem -Path $root -Filter "DB_System.*" -Recurse | ForEach-Object {
    $src = $_.FullName
    $dst = Join-Path $dataDir $_.Name
    Backup-File $src
    Move-Item -Path $src -Destination $dst -Force
    Write-Host "Moved DB file: $src -> $dst"
}

# Utility: update content in files with backup
function Replace-InFile($path, $pattern, $replacement) {
    if (-Not (Test-Path $path)) { return }
    Backup-File $path
    $text = Get-Content -Raw -LiteralPath $path
    $newText = [regex]::Replace($text, $pattern, $replacement, [System.Text.RegularExpressions.RegexOptions]::Multiline)
    if ($newText -ne $text) {
        Set-Content -LiteralPath $path -Value $newText
        Write-Host "Updated: $path"
    }
}

# Update namespaces & class identifiers in moved files
# Forms -> namespace Project_FinancePersonalManagement.Forms
Get-ChildItem -Path $formsDir -Include *.cs -Recurse | ForEach-Object {
    $p = $_.FullName
    # update namespace Project_FinancePersonalManagement to sub-namespace for forms only where appropriate
    Replace-InFile $p 'namespace\s+Project_FinancePersonalManagement\b' 'namespace Project_FinancePersonalManagement.Forms'
}

# Auth files -> Project_FinancePersonalManagement.Forms.Auth
Get-ChildItem -Path $authDir -Include *.cs -Recurse | ForEach-Object {
    $p = $_.FullName
    Replace-InFile $p 'namespace\s+Project_FinancePersonalManagement\b' 'namespace Project_FinancePersonalManagement.Forms.Auth'
}

# Data DB_System files -> Project_FinancePersonalManagement.Data
Get-ChildItem -Path $dataDir -Include *.cs,*.dbml,*.designer.cs -Recurse | ForEach-Object {
    $p = $_.FullName
    Replace-InFile $p 'namespace\s+Project_FinancePersonalManagement\b' 'namespace Project_FinancePersonalManagement.Data'
}

# Rename class identifiers (basic): form_GiaoDich -> FrmGiaoDich, etc.
# This performs simple identifier replacements across the project
$identifierReplacements = @{
    'class\s+form_GiaoDich' = 'class FrmGiaoDich'
    'class\s+form_KhoanVay_ChoVay' = 'class FrmKhoanVayChoVay'
    'class\s+Form_Menu' = 'class FrmMenu'
    'class\s+form_TaiKhoan' = 'class FrmTaiKhoan'
    'class\s+form_ThongKe' = 'class FrmThongKe'
    'class\s+frm_danhMuc' = 'class FrmDanhMuc'
    'class\s+frm_nganSach' = 'class FrmNganSach'
    # Also replace partial class declarations used by Designer.cs
    'partial\s+class\s+form_GiaoDich' = 'partial class FrmGiaoDich'
    'partial\s+class\s+form_KhoanVay_ChoVay' = 'partial class FrmKhoanVayChoVay'
    'partial\s+class\s+Form_Menu' = 'partial class FrmMenu'
    'partial\s+class\s+form_TaiKhoan' = 'partial class FrmTaiKhoan'
    'partial\s+class\s+form_ThongKe' = 'partial class FrmThongKe'
    'partial\s+class\s+frm_danhMuc' = 'partial class FrmDanhMuc'
    'partial\s+class\s+frm_nganSach' = 'partial class FrmNganSach'
}

# Apply replacements project-wide for .cs and Designer files
Get-ChildItem -Path $root -Include *.cs -Recurse | ForEach-Object {
    $file = $_.FullName
    foreach ($pat in $identifierReplacements.Keys) {
        Replace-InFile $file $pat $identifierReplacements[$pat]
    }
}

# Update .csproj path entries: replace old file names with new ones
Get-ChildItem -Path $root -Filter *.csproj -Recurse | ForEach-Object {
    $proj = $_.FullName
    Backup-File $proj
    $projText = Get-Content -Raw -LiteralPath $proj
    foreach ($kv in $mappings.GetEnumerator()) {
        $old = $kv.Key -replace '\\','/'
        $new = $kv.Value -replace '\\','/'
        $projText = $projText -replace [regex]::Escape($old), [regex]::Escape($new)
    }
    # Update sign_in_and_sign_up folder path occurrences if any
    $projText = $projText -replace 'sign_in_and_sign_up/', 'Forms/Auth/sign_in_and_sign_up/'
    Set-Content -LiteralPath $proj -Value $projText
    Write-Host "Patched project file: $proj"
}

Write-Host "Refactor script finished. PLEASE review the changes in the .refactor_backup folder and with git."
Write-Host "Recommended next steps:"
Write-Host "  1) git status"
Write-Host "  2) git add -A && git commit -m 'Refactor: move forms, auth, dbml; update namespaces and names' (or create a branch first)"
Write-Host "  3) Build the solution in Visual Studio and resolve any remaining references."
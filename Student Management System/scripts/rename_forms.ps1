# Usage: run from the solution folder (where the .csproj sits). Close Visual Studio first.
# Back up and rename files, then update first .csproj found.

$map = @{
    "Form1.cs"               = "frmLogin.cs"
    "Form1.Designer.cs"      = "frmLogin.Designer.cs"
    "Form1.resx"             = "frmLogin.resx"
    "Form2.cs"               = "frmMainStudent.cs"
    "Form2.Designer.cs"      = "frmMainStudent.Designer.cs"
    "Form2.resx"             = "frmMainStudent.resx"
    "Form3.cs"               = "frmAddStudent.cs"
    "Form3.Designer.cs"      = "frmAddStudent.Designer.cs"
    "Form3.resx"             = "frmAddStudent.resx"
}

# Find project file
$proj = Get-ChildItem -Path . -Filter *.csproj -Recurse -ErrorAction SilentlyContinue | Select-Object -First 1
if (-not $proj) { Write-Error "No .csproj found in or under current folder."; exit 1 }

# Backup project file
$projBackup = "$($proj.FullName).backup"
Copy-Item -Path $proj.FullName -Destination $projBackup -Force
Write-Host "Backed up project to $projBackup"

# Rename files on disk and update project content
$content = Get-Content -Raw -Path $proj.FullName

foreach ($old in $map.Keys) {
    $new = $map[$old]
    $oldPath = Join-Path -Path $proj.DirectoryName -ChildPath $old
    $oldPathRec = Get-ChildItem -Path $proj.DirectoryName -Recurse -Filter $old -File -ErrorAction SilentlyContinue | Select-Object -First 1
    if ($oldPathRec) {
        $src = $oldPathRec.FullName
        $dst = Join-Path -Path (Split-Path $src) -ChildPath $new
        if (-not (Test-Path $dst)) {
            Rename-Item -Path $src -NewName $new
            Write-Host "Renamed $src -> $dst"
        } else {
            Write-Warning "Destination already exists: $dst (skipping rename)"
        }
        # Replace filename references in .csproj
        $content = $content -replace [regex]::Escape($old), [regex]::Escape($new)
    } else {
        Write-Host "File not found, skipping: $old"
    }
}

# Save updated project file
Set-Content -Path $proj.FullName -Value $content -Encoding UTF8
Write-Host "Updated project file: $($proj.Name). Please open Visual Studio and Rebuild."                
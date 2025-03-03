Clear-Host
$path = "F:\16151814"
$numberOfFolder = (Get-ChildItem $path | Measure-Object).Count
$counter = 1
$breakCounter = 1
$script:counter = 1   

function PictureSort {
    Write-Host "Bilder werden Sotiert"

    for ($i = 0; $i -le $numberOfFolder; $i++) {
        $selectFolder = Get-ChildItem -Path $path | Select-Object -Skip $i -First 1 | Select-Object -ExpandProperty FullName
        $checkForSubFolder = (Get-childitem -path $selectFolder -Recurse -Directory | Measure-Object).Count
    
        if ($checkForSubFolder -eq 0) {    
            $folderShortName = $selectFolder | Split-Path -Leaf
            Write-Host "|"$folderShortName 
            Get-ChildItem -Path "$selectFolder" -File | Sort-Object LastWriteTime | Rename-Item -NewName { "$folderShortName - {0:D4}{1}" -f $script:counter++, ".png" } -ErrorAction 'silentlycontinue'   
            $script:counter = 1    
        }
    
        if ($selectFolder -like "*IRL_3D*") {
            $newNumberOfFolders = (Get-ChildItem $selectFolder | Measure-Object).Count
            $folderShortName = $selectFolder | Split-Path -Leaf
            Write-Host "|"$folderShortName
            for ($j = 0; $j -lt $newNumberOfFolders; $j++) {
                $selecetSubFolder = Get-ChildItem -Path $selectFolder | Select-Object -Skip $j -First 1 | Select-Object -ExpandProperty FullName
                $selecetSubFolderShort = $selecetSubFolder | Split-Path -Leaf
                Write-Host "-|"$selecetSubFolderShort 
                $filesToRename = Get-ChildItem -Path "$selecetSubFolder" -File | Sort-Object LastWriteTime
                foreach ($file in $filesToRename) {
                    $newName = "$selecetSubFolderShort - {0:D4}{1}" -f $script:counter++, ".png" 
                    Rename-Item $file.FullName -NewName  $newName -ErrorAction 'silentlycontinue' 
                }

                $script:counter = 1    
            }
        }

        $script:counter = 1    
        $breakCounter++

        if ($breakCounter -eq 6) {
            break
        }

        Start-Sleep -Seconds 2
    }   
    Write-Host `n
}

function VideoSort {
    Write-Host "Videos werden Sotiert"

    for ($i = 0; $i -le $numberOfFolder; $i++) {
        $selectFolder = Get-ChildItem -Path $path | Select-Object -Skip $i -First 1 | Select-Object -ExpandProperty FullName
        if ($selectFolder -like "*Vid*") {
            $newNumberOfFolders = (Get-ChildItem $selectFolder | Measure-Object).Count
            for ($j = 0; $j -lt $newNumberOfFolders; $j++) {
                $selecetSubFolder = Get-ChildItem -Path $selectFolder | Select-Object -Skip $j -First 1 | Select-Object -ExpandProperty FullName
                $selecetSubFolderShort = $selecetSubFolder | Split-Path -Leaf
                Write-Host "|"$selecetSubFolderShort
                Get-ChildItem -Path "$selecetSubFolder" -File | Sort-Object LastWriteTime | Rename-Item -NewName { "$selecetSubFolderShort - {0:D4}{1}" -f $script:counter++, ".mp4" } -ErrorAction 'silentlycontinue'
                $script:counter = 1    
                Start-Sleep -Seconds 1
            }
        }
        
        $script:counter = 1    

        Start-Sleep -Seconds 3
    }
    Write-Host `n
}

PictureSort
VideoSort
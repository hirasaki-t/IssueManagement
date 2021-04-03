. "./ps/set-location.ps1"
. "./ps/variable.ps1"

Write-Output "最後に追加されたマイグレーションを削除します。よろしいですか？"
$accept = Read-Host "問題なければyを入力後、エンターキーを押してください"
if ($accept -ne "y") {
    exit
}

SetLocation
dotnet ef migrations remove --project:$project --startup-project:$startupProject --context:$context
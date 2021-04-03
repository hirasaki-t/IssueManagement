. "./ps/set-location.ps1"
. "./ps/variable.ps1"

$migrationName = Read-Host "作成するマイグレーション名を設定してください"
if ([string]::IsNullOrWhiteSpace($migrationName)) {
    exit
}

SetLocation
dotnet ef migrations add --project:$project --startup-project:$startupProject --context:$context $migrationName
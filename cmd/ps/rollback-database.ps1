. "./ps/set-location.ps1"
. "./ps/variable.ps1"
. "./ps/select-configuration.ps1"

$configuration = SelectConfiguration
$migrationName = Read-Host "復元を行うマイグレーション名を指定してください"

SetLocation
dotnet ef database update $migrationName --verbose --project:$project --startup-project:$startupProject --context:$context --configuration:$configuration
. "./ps/select-configuration.ps1"
. "./ps/set-location.ps1"
. "./ps/variable.ps1"

$configuration = SelectConfiguration

SetLocation
dotnet ef database update --verbose --project:$project --startup-project:$startupProject --context:$context --configuration:$configuration
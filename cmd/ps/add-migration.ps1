. "./ps/set-location.ps1"
. "./ps/variable.ps1"

$migrationName = Read-Host "�쐬����}�C�O���[�V��������ݒ肵�Ă�������"
if ([string]::IsNullOrWhiteSpace($migrationName)) {
    exit
}

SetLocation
dotnet ef migrations add --project:$project --startup-project:$startupProject --context:$context $migrationName
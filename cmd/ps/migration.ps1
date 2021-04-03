$ErrorActionPreference = "Stop"
$typeName = "System.Management.Automation.Host.ChoiceDescription"
$addMigration = New-Object $typeName("マイグレーションの追加(&1)", "マイグレーション名を指定して、新規マイグレーションを追加します")
$removeMigration = New-Object $typeName("マイグレーションの削除(&2)", "直前に追加したマイグレーションを削除します")
$updateMigration = New-Object $typeName("DBの定義を最新に更新(&3)", "DBの定義を最新の状態に更新します")
$rollbackMigration = New-Object $typeName("DBの定義の変更(&4)", "マイグレーション名を指定して、DBの定義を変更します")

$options = New-Object "System.Collections.ObjectModel.Collection``1[[$typeName]]"
$options.add($addMigration)
$options.add($removeMigration)
$options.add($updateMigration)
$options.add($rollbackMigration)

$result = $host.ui.PromptForChoice("操作", "実行する操作を選択してください", $options, 0)

dotnet tool update -g dotnet-ef

switch ($result) {
    0 { powershell "../cmd/ps/add-migration.ps1"; break }
    1 { powershell "../cmd/ps/remove-migration.ps1"; break }
    2 { powershell "../cmd/ps/update-database.ps1"; break }
    3 { powershell "../cmd/ps/rollback-database.ps1"; break }
}
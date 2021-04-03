# DbContextクラスを継承したクラスが存在するプロジェクト名
$project = "Model"

# 起動時に呼ばれるプロジェクト名
$startupProject = "WebApp"

# DbContextクラスを継承したマイグレーション対象のクラス
$context = "SQLServerDataContext"

# cmdフォルダから見たソリューションフォルダが存在するパスへの相対パス
$solutionFolder = "../src/backend"

# 構成の一覧
$configurations = @("Debug","Test","Release")
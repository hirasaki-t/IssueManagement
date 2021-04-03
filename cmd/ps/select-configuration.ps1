. "./ps/variable.ps1"

function SelectConfiguration() {
    $result = Read-Host ("[" + ($configurations -join "][") + "]から、操作を実行する対象の構成を選択してください")
    if ($result | Select-String ("^(?:(?:" + ($configurations -join ")|(?:") + "))$") -Quiet) {
        return $result
    }
    throw "正しくない構成が選択されました" 
}
. "./ps/variable.ps1"

function SelectConfiguration() {
    $result = Read-Host ("[" + ($configurations -join "][") + "]����A��������s����Ώۂ̍\����I�����Ă�������")
    if ($result | Select-String ("^(?:(?:" + ($configurations -join ")|(?:") + "))$") -Quiet) {
        return $result
    }
    throw "�������Ȃ��\�����I������܂���" 
}
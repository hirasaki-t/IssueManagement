import MaterialTable from "material-table";
import { useState } from "react";
import { useHistory } from 'react-router-dom';

/** 過去の案件テーブル */
function ArchiveListTable() {

    /** 案件ステータス定義 */
    const projectStatus = { 1: "未着手", 2: "要求分析", 3: "要件定義", 4: "基本設計", 5: "詳細設計", 6: "開発", 7: "内部テスト", 8: "ユーザーテスト", 9: "リリース準備", 10: "リリース済" };

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '案件ID', field: 'id', editable: 'never' as any },
        { title: '案件名', field: 'title' },
        { title: 'ステータス', field: 'status', lookup: projectStatus },
        { title: '部署', field: 'department' },
        { title: '作成日', field: 'createdate', editable: 'never' as any },
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", title: "プロジェクトA", status: 10, department: "総務部", createdate: "2021/01/01" },
        { id: "2", title: "プロジェクトB", status: 10, department: "総務部", createdate: "2021/01/01" },
        { id: "3", title: "プロジェクトC", status: 10, department: "その他", createdate: "2021/01/01" },
        { id: "4", title: "プロジェクトD", status: 10, department: "営業部", createdate: "2021/01/01" },
        { id: "5", title: "プロジェクトE", status: 10, department: "広報部", createdate: "2021/01/01" },
    ]);

    /** ページ遷移用ヒストリー */
    const history = useHistory()

    return (
        <MaterialTable
            title="過去の案件"
            columns={columns}
            data={datas}
            options={{ pageSize: 10, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(_, rowData) => // ★ 行クリック時の処理
                history.push("/project/issue")
            }
            editable={{
                onRowUpdate: (newData, oldData) =>
                    new Promise((resolve, reject) => {
                        setTimeout(() => {
                        }, 1000)
                    }),
                onRowDelete: (oldData) =>
                    new Promise((resolve, reject) => {
                        setTimeout(() => {
                        }, 1000)
                    })
            }}
        />
    );
}
export default ArchiveListTable;
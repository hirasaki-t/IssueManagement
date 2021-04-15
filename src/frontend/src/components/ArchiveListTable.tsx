import MaterialTable from "material-table";
import { useState } from "react";
import { Link, useHistory } from 'react-router-dom';

function ArchiveListTable() {

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '案件ID', field: 'id' },
        { title: '案件名', field: 'title' },
        { title: '状態', field: 'status' },
        { title: '部署', field: 'department' },
        { title: '作成日', field: 'createdate' },
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", title: "プロジェクトA", status: "リリース済", department: "総務部", createdate: "2021/01/01" },
        { id: "2", title: "プロジェクトB", status: "リリース済", department: "総務部", createdate: "2021/01/01" },
        { id: "3", title: "プロジェクトC", status: "リリース済", department: "その他", createdate: "2021/01/01" },
        { id: "4", title: "プロジェクトD", status: "リリース済", department: "営業部", createdate: "2021/01/01" },
        { id: "5", title: "プロジェクトE", status: "リリース済", department: "広報部", createdate: "2021/01/01" },
    ]);

    const [selectedCouponId, setSelectedCouponId] = useState<string | null>(null);
    const history = useHistory()

    return (
        <MaterialTable
            title="過去の案件"
            columns={columns}
            data={datas}
            editable={{
                onRowUpdate: (newData, oldData) =>
                    new Promise((resolve, reject) => {
                        setTimeout(() => {
                        }, 1000)
                    }),
            }}
            options={{ pageSize: 10, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(_, rowData) => // ★ 行クリック時の処理
                history.push("/project/issue")
            }
        />
    );
}
export default ArchiveListTable;
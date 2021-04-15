import MaterialTable from "material-table";
import { useState } from "react";
import { Link, useHistory } from 'react-router-dom';


function ProjectListTable() {

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '案件ID', field: 'id' },
        { title: '案件名', field: 'title' },
        { title: 'ステータス', field: 'status' },
        { title: '部署', field: 'department' },
        { title: '作成日', field: 'createdate' },
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "6", title: "プロジェクトF", status: "ユーザーテスト", department: "総務部", createdate: "2021/01/01" },
        { id: "7", title: "プロジェクトG", status: "未着手", department: "総務部", createdate: "2021/01/01" },
        { id: "8", title: "プロジェクトH", status: "要求分析中", department: "その他", createdate: "2021/01/01" },
        { id: "9", title: "プロジェクトI", status: "開発", department: "営業部", createdate: "2021/01/01" },
        { id: "10", title: "プロジェクトJ", status: "未着手", department: "広報部", createdate: "2021/01/01" },
    ]);

    const [selectedCouponId, setSelectedCouponId] = useState<string | null>(null);
    const history = useHistory()

    return (
        <MaterialTable
            title="案件リスト"
            columns={columns}
            data={datas}
            editable={{
                onRowAdd: newData =>
                    new Promise((resolve, reject) => {
                        setTimeout(() => {
                        }, 1000)
                    }),
                onRowUpdate: (newData, oldData) =>
                    new Promise((resolve, reject) => {
                        setTimeout(() => {
                        }, 1000)
                    }),
            }}
            options={{ pageSize: 10, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(event, rowData) =>
                history.push("/project/issue")
            }
        />
    );

}

export default ProjectListTable;
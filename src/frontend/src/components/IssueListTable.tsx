import MaterialTable from "material-table";
import { useState } from "react";
import { Link, useHistory } from 'react-router-dom';

import 'easymde/dist/easymde.min.css';

function IssueListTable() {

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '課題ID', field: 'id', style: { width: '2%' } },
        { title: '課題', field: 'title' },
        { title: '質問者', field: 'questioner' },
        { title: '回答者', field: 'answerer' },
        { title: '最終更新日', field: 'updateDate' },
        { title: 'ステータス', field: 'status' }
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", questioner: "山田太郎", answerer: "田中次郎", updateDate: "2020/01/05", status: "CLOSE" },
        { id: "2", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", questioner: "山田太郎", answerer: "田中次郎,増永理俊", updateDate: "2020/01/05", status: "OPEN" },
        { id: "3", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", questioner: "山田太郎", answerer: "", updateDate: "", status: "OPEN" },
        { id: "4", title: "", questioner: "", answerer: "", updateDate: "", status: "" },
        { id: "5", title: "", questioner: "", qanswerer: "", updateDate: "", status: "" },
        { id: "6", title: "", questioner: "", answerer: "", updateDate: "", status: "" },
    ]);

    const [selectedCouponId, setSelectedCouponId] = useState<string | null>(null);
    const history = useHistory()
    return (
        <div>

            <MaterialTable
                title="課題リスト"
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
                options={{ pageSize: 7, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
                onRowClick={(event, rowData) =>
                    history.push("/project/issue/message")
                }
            />
        </div>
    );
}

export default IssueListTable;
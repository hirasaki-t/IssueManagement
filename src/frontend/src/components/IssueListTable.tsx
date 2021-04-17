import MaterialTable from "material-table";
import { useState } from "react";
import { Link, useHistory } from 'react-router-dom';

import 'easymde/dist/easymde.min.css';

function IssueListTable() {

    /** 案件ステータス定義 */
    const issueStatus = { 1: "未解決", 2: "解決済", 3: "保留", 4: "取下" };

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '課題ID', field: 'id' },
        { title: '課題', field: 'title' },
        { title: '起票者', field: 'voter' },
        { title: '最終更新者', field: 'updater' },
        { title: '最終更新日', field: 'updateDate' },
        { title: 'ステータス', field: 'status', lookup: issueStatus }
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "山田二郎", updateDate: "2020/01/05", status: 2 },
        { id: "2", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "田中次郎", updateDate: "2020/01/05", status: 3 },
        { id: "3", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "", updateDate: "", status: 1 },
        { id: "4", title: "", voter: "", updater: "", updateDate: "", status: "" },
        { id: "5", title: "", voter: "", updater: "", updateDate: "", status: "" },
        { id: "6", title: "", voter: "", updater: "", updateDate: "", status: "" },
    ]);

    const history = useHistory()
    return (
        <MaterialTable
            title="課題リスト"
            columns={columns}
            data={datas}
            options={{ pageSize: 7, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(event, rowData) =>
                history.push("/project/issue/message")
            }
        />
    );
}

export default IssueListTable;
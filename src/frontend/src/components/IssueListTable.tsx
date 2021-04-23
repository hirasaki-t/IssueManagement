import MaterialTable from "material-table";
import { useState } from "react";
import { Link, useHistory } from 'react-router-dom';

import 'easymde/dist/easymde.min.css';

/** 課題リストテーブル */
function IssueListTable() {

    /** 案件ステータス定義 */
    const issueStatus = { 1: "未解決", 2: "解決済", 3: "保留", 4: "取下" };

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '課題ID', field: 'id', editable: 'never' as any },
        { title: '課題', field: 'title' },
        { title: '起票者', field: 'voter', editable: 'never' as any },
        { title: '最終更新者', field: 'updater', editable: 'never' as any },
        { title: '最終更新日', field: 'updateDate', editable: 'never' as any },
        { title: 'ステータス', field: 'status', lookup: issueStatus }
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "山田二郎", updateDate: "2020/01/05", status: 2 },
        { id: "2", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "田中次郎", updateDate: "2020/01/05", status: 3 },
        { id: "3", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
        { id: "4", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
        { id: "5", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
        { id: "6", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
    ]);

    /** ページ遷移用ヒストリー */
    const history = useHistory()

    return (
        <MaterialTable
            title="課題リスト"
            columns={columns}
            data={datas}
            options={{ pageSize: 5, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(event, rowData) =>
                history.push("/project/issue/message")
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

export default IssueListTable;
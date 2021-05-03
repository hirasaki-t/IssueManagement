import MaterialTable from "material-table";
import { useState } from "react";

/** ユーザー管理テーブル */
function UserManagementTable() {

    /** 権限情報 */
    const authorities = { 1: "開発", 2: "営業" };

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: "ID", field: "id", editable: 'never' as any },
        { title: "名前", field: "name" },
        { title: "メールアドレス", field: "mail" },
        { title: "部署", field: "department" },
        { title: "権限", field: "authority", lookup: authorities },
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", name: "増永理俊", mail: "testtest@gmail.com", department: "総務部", authority: 1 },
    ]);

    return (
        <MaterialTable
            title="ユーザー管理"
            columns={columns}
            data={datas}
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
            options={{ pageSize: 10, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
        />
    );
}
export default UserManagementTable;
import MaterialTable from "material-table";
import { useState } from "react";

function UserManagementTable() {

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: 'ID', field: 'id' },
        { title: 'ユーザー名', field: 'name' },
        { title: '部署', field: 'department' },
        { title: '権限', field: 'authority' },
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id: "1", name: "増永理俊", department: "総務部", authority: "一般" },
    ]);

    const [selectedCouponId, setSelectedCouponId] = useState<string | null>(null);

    return (
        <MaterialTable
            title="ユーザー管理"
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
                onRowDelete: (oldData) =>
                    new Promise((resolve, reject) => {
                        setTimeout(() => {
                        }, 1000)
                    })
            }}
            options={{ pageSize: 10, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(_, rowData) => // ★ 行クリック時の処理
                setSelectedCouponId(
                    rowData &&
                        (!selectedCouponId || selectedCouponId !== rowData.id)
                        ? rowData.id
                        : null
                )
            }
        />
    );
}
export default UserManagementTable;
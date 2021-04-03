import * as React from "react";
import MaterialTable from "material-table";
import { useState } from "react";

const projectListTable : React.FC = () => {

    /** テーブルのヘッダー定義 */
    const [columns, setColumns] = useState([
        { title: '案件ID', field: 'id' },
        { title: '案件名', field: 'title' },
        { title: '状態', field: 'status' },
        { title: '部署', field: 'department' },
        { title: '依頼者', field: 'client' },
        { title: '開発担当者', field: 'staff' },
        { title: '最終更新日', field: 'updateDate' },
    ]);

    /** テーブルの値セット */
    const [datas, setData] = useState([
        { id:"6", title: "プロジェクトF", status: "ユーザーテスト", department: "総務部", client: "増永理俊", staff: "阿垣和男", updateDate: "2021/01/01"},
        { id:"7", title: "プロジェクトG", status: "未着手", department: "総務部", client: "小栗弥恵子", staff: "阿垣和男", updateDate: "2021/01/01"},
        { id:"8", title: "プロジェクトH", status: "要求分析中", department: "その他", client: "鳥飼潤", staff: "阿垣和男", updateDate: "2021/01/01"},
        { id:"9", title: "プロジェクトI", status: "開発", department: "営業部", client: "宇根元義信", staff: "関谷則子", updateDate: "2021/01/01"},
        { id:"10", title: "プロジェクトJ", status: "未着手", department: "広報部", client: "保科佳直", staff: "関谷則子", updateDate: "2021/01/01"},
    ]);

    const [selectedCouponId, setSelectedCouponId] = useState<string | null>(null);

    return (
        <MaterialTable
            title="進行案件リスト"
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
            options={{ pageSize:15, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
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
export default projectListTable;
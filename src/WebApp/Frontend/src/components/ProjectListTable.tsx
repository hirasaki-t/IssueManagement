import React, { useContext } from 'react'
import MaterialTable from "material-table";
import { useState } from "react";
import { useHistory } from 'react-router-dom';
import { ProjectContext } from "../pages/ProjectListPage"

/** 案件リストテーブル */
function ProjectListTable() {

    /** 案件コンテキスト */
    const project = useContext(ProjectContext);

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
    const [datas, setData] = useState([project]);

    /** ページ遷移用ヒストリー */
    const history = useHistory()

    return (
        <MaterialTable
            title="案件リスト"
            columns={columns}
            data={datas}
            options={{ pageSize: 10, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }}
            onRowClick={(event, rowData) =>
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

export default ProjectListTable;
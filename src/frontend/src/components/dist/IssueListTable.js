"use strict";
exports.__esModule = true;
var material_table_1 = require("material-table");
var react_1 = require("react");
var react_router_dom_1 = require("react-router-dom");
require("easymde/dist/easymde.min.css");
function IssueListTable() {
    /** 案件ステータス定義 */
    var issueStatus = { 1: "未解決", 2: "解決済", 3: "保留", 4: "取下" };
    /** テーブルのヘッダー定義 */
    var _a = react_1.useState([
        { title: '課題ID', field: 'id', editable: 'never' },
        { title: '課題', field: 'title' },
        { title: '起票者', field: 'voter', editable: 'never' },
        { title: '最終更新者', field: 'updater', editable: 'never' },
        { title: '最終更新日', field: 'updateDate', editable: 'never' },
        { title: 'ステータス', field: 'status', lookup: issueStatus }
    ]), columns = _a[0], setColumns = _a[1];
    /** テーブルの値セット */
    var _b = react_1.useState([
        { id: "1", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "山田二郎", updateDate: "2020/01/05", status: 2 },
        { id: "2", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "田中次郎", updateDate: "2020/01/05", status: 3 },
        { id: "3", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
        { id: "4", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
        { id: "5", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
        { id: "6", title: "◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯◯について", voter: "山田太郎", updater: "鈴木一郎", updateDate: "2021/06/08", status: 1 },
    ]), datas = _b[0], setData = _b[1];
    var history = react_router_dom_1.useHistory();
    return (React.createElement(material_table_1["default"], { title: "\u8AB2\u984C\u30EA\u30B9\u30C8", columns: columns, data: datas, options: { pageSize: 5, headerStyle: { whiteSpace: 'nowrap' }, rowStyle: { whiteSpace: 'nowrap' } }, onRowClick: function (event, rowData) {
            return history.push("/project/issue/message");
        }, editable: {
            onRowUpdate: function (newData, oldData) {
                return new Promise(function (resolve, reject) {
                    setTimeout(function () {
                    }, 1000);
                });
            },
            onRowDelete: function (oldData) {
                return new Promise(function (resolve, reject) {
                    setTimeout(function () {
                    }, 1000);
                });
            }
        } }));
}
exports["default"] = IssueListTable;

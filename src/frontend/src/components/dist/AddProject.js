"use strict";
exports.__esModule = true;
var react_1 = require("react");
require("../css/style.scss");
var core_1 = require("@material-ui/core");
function AddProject() {
    var _a = react_1["default"].useState(false), open = _a[0], setOpen = _a[1];
    /** 「案件の新規追加」ボタンの状態がTrue */
    var handleClickOpen = function () {
        setOpen(true);
    };
    /** 「案件の新規追加」ボタンの状態がFalse */
    var handleClose = function () {
        setOpen(false);
    };
    var _b = react_1["default"].useState([]), departments = _b[0], setDepartments = _b[1];
    var handleChange = function (event) {
        setDepartments(event.target.value);
    };
    return (react_1["default"].createElement("div", null,
        react_1["default"].createElement(core_1.Button, { variant: "contained", color: "primary", onClick: handleClickOpen }, "\u6848\u4EF6\u306E\u65B0\u898F\u8FFD\u52A0"),
        react_1["default"].createElement(core_1.Dialog, { open: open },
            react_1["default"].createElement("div", { className: "dialog_mergin stackContainer" },
                react_1["default"].createElement("div", null,
                    react_1["default"].createElement(core_1.TextField, { className: "addProject_name", label: "\u6848\u4EF6\u540D", variant: "outlined" })),
                react_1["default"].createElement("div", null,
                    react_1["default"].createElement(core_1.FormControl, { variant: "outlined" },
                        react_1["default"].createElement(core_1.InputLabel, { id: "addProject_status" }, "\u6848\u4EF6\u30B9\u30C6\u30FC\u30BF\u30B9"),
                        react_1["default"].createElement(core_1.Select, { className: "addProject_status" },
                            react_1["default"].createElement(core_1.MenuItem, { value: 1 }, "\u672A\u7740\u624B"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 2 }, "\u8981\u6C42\u5206\u6790"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 3 }, "\u8981\u4EF6\u5B9A\u7FA9"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 4 }, "\u57FA\u672C\u8A2D\u8A08"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 5 }, "\u8A73\u7D30\u8A2D\u8A08"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 6 }, "\u958B\u767A"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 7 }, "\u5185\u90E8\u30C6\u30B9\u30C8"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 8 }, "\u30E6\u30FC\u30B6\u30FC\u30C6\u30B9\u30C8"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 9 }, "\u30EA\u30EA\u30FC\u30B9\u6E96\u5099"),
                            react_1["default"].createElement(core_1.MenuItem, { value: 10 }, "\u30EA\u30EA\u30FC\u30B9")))),
                react_1["default"].createElement("div", null,
                    react_1["default"].createElement(core_1.FormControl, { variant: "outlined" },
                        react_1["default"].createElement(core_1.InputLabel, { id: "addProject_department" }, "\u90E8\u7F72(\u8907\u6570\u9078\u629E\u53EF)"),
                        react_1["default"].createElement(core_1.Select, { className: "addProject_department", multiple: true, value: departments, onChange: handleChange },
                            react_1["default"].createElement(core_1.MenuItem, { value: "1" }, "\u958B\u767A"),
                            react_1["default"].createElement(core_1.MenuItem, { value: "2" }, "\u55B6\u696D")))),
                react_1["default"].createElement("div", { className: "rightStackContainer" },
                    react_1["default"].createElement("span", null,
                        react_1["default"].createElement(core_1.Button, { className: "addProject_addButton", variant: "contained", color: "default", onClick: handleClose }, "\u623B\u308B")),
                    react_1["default"].createElement("span", null,
                        react_1["default"].createElement(core_1.Button, { className: "addProject_addButton", variant: "contained", color: "primary", onClick: handleClose }, "\u6848\u4EF6\u3092\u8FFD\u52A0")))))));
}
exports["default"] = AddProject;

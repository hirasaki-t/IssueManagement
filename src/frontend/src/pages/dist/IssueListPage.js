"use strict";
exports.__esModule = true;
var react_simplemde_editor_1 = require("react-simplemde-editor");
var react_1 = require("react");
var AddIssue_1 = require("../components/AddIssue");
var Drawers_1 = require("../components/Drawers");
var IssueListTable_1 = require("../components/IssueListTable");
require("../css/style.scss");
function IssueListPage() {
    var _a = react_1.useState(''), markdown = _a[0], setMarkdown = _a[1];
    return (React.createElement("div", null,
        React.createElement(Drawers_1["default"], null,
            React.createElement("div", { className: "stackContainer" },
                React.createElement("div", { className: "rightStackContainer" },
                    React.createElement(AddIssue_1["default"], null)),
                React.createElement(IssueListTable_1["default"], null),
                React.createElement(react_simplemde_editor_1["default"], { onChange: function (e) { return setMarkdown(e); }, options: {
                        autofocus: true,
                        spellChecker: false,
                        toolbar: ["bold", "italic", "strikethrough", "|", "code", "quote", "link", "image", "table", "|", "preview"]
                    } })))));
}
exports["default"] = IssueListPage;

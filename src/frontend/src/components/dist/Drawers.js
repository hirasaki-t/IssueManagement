"use strict";
exports.__esModule = true;
var react_router_bootstrap_1 = require("react-router-bootstrap");
var styles_1 = require("@material-ui/core/styles");
var Drawer_1 = require("@material-ui/core/Drawer");
var CssBaseline_1 = require("@material-ui/core/CssBaseline");
var AppBar_1 = require("@material-ui/core/AppBar");
var Toolbar_1 = require("@material-ui/core/Toolbar");
var List_1 = require("@material-ui/core/List");
var Typography_1 = require("@material-ui/core/Typography");
var Divider_1 = require("@material-ui/core/Divider");
var ListItem_1 = require("@material-ui/core/ListItem");
var ListItemIcon_1 = require("@material-ui/core/ListItemIcon");
var ListItemText_1 = require("@material-ui/core/ListItemText");
var Home_1 = require("@material-ui/icons/Home");
var ListAlt_1 = require("@material-ui/icons/ListAlt");
var History_1 = require("@material-ui/icons/History");
var Settings_1 = require("@material-ui/icons/Settings");
var GroupAdd_1 = require("@material-ui/icons/GroupAdd");
var AccountBox_1 = require("@material-ui/icons/AccountBox");
var drawerWidth = 240;
var useStyles = styles_1.makeStyles(function (theme) {
    return styles_1.createStyles({
        root: {
            display: 'flex'
        },
        appBar: {
            width: "calc(100% - " + drawerWidth + "px)",
            marginLeft: drawerWidth
        },
        drawer: {
            width: drawerWidth,
            flexShrink: 0
        },
        drawerPaper: {
            width: drawerWidth
        },
        // necessary for content to be below app bar
        toolbar: theme.mixins.toolbar,
        content: {
            flexGrow: 1,
            backgroundColor: theme.palette.background["default"],
            padding: theme.spacing(3)
        }
    });
});
function Drawers(props) {
    var classes = useStyles();
    return (React.createElement("div", { className: classes.root },
        React.createElement(CssBaseline_1["default"], null),
        React.createElement(AppBar_1["default"], { position: "fixed", className: classes.appBar },
            React.createElement(Toolbar_1["default"], null,
                React.createElement(Typography_1["default"], { variant: "h6", noWrap: true }, "\u8AB2\u984C\u7BA1\u7406\u30B7\u30B9\u30C6\u30E0(\u4EEE)"))),
        React.createElement(Drawer_1["default"], { className: classes.drawer, variant: "permanent", classes: {
                paper: classes.drawerPaper
            }, anchor: "left" },
            React.createElement("div", { className: classes.toolbar }),
            React.createElement(Divider_1["default"], null),
            React.createElement(List_1["default"], null,
                React.createElement(react_router_bootstrap_1.LinkContainer, { to: "/" },
                    React.createElement(ListItem_1["default"], { button: true, key: "" },
                        React.createElement(ListItemIcon_1["default"], null,
                            React.createElement(Home_1["default"], null)),
                        React.createElement(ListItemText_1["default"], { primary: "\u30DB\u30FC\u30E0" }))),
                React.createElement(react_router_bootstrap_1.LinkContainer, { to: "/list" },
                    React.createElement(ListItem_1["default"], { button: true, key: "" },
                        React.createElement(ListItemIcon_1["default"], null,
                            React.createElement(ListAlt_1["default"], null)),
                        React.createElement(ListItemText_1["default"], { primary: "\u6848\u4EF6\u30EA\u30B9\u30C8" }))),
                React.createElement(react_router_bootstrap_1.LinkContainer, { to: "/archive" },
                    React.createElement(ListItem_1["default"], { button: true, key: "" },
                        React.createElement(ListItemIcon_1["default"], null,
                            React.createElement(History_1["default"], null)),
                        React.createElement(ListItemText_1["default"], { primary: "\u904E\u53BB\u306E\u6848\u4EF6" })))),
            React.createElement(Divider_1["default"], null),
            React.createElement(List_1["default"], null,
                React.createElement(react_router_bootstrap_1.LinkContainer, { to: "/setting" },
                    React.createElement(ListItem_1["default"], { button: true, key: "" },
                        React.createElement(ListItemIcon_1["default"], null,
                            React.createElement(AccountBox_1["default"], null)),
                        React.createElement(ListItemText_1["default"], { primary: "\u30E6\u30FC\u30B6\u30FC\u8A2D\u5B9A" })))),
            React.createElement(Divider_1["default"], null),
            React.createElement(List_1["default"], null,
                React.createElement(react_router_bootstrap_1.LinkContainer, { to: "/admin/usersetting" },
                    React.createElement(ListItem_1["default"], { button: true, key: "" },
                        React.createElement(ListItemIcon_1["default"], null,
                            React.createElement(GroupAdd_1["default"], null)),
                        React.createElement(ListItemText_1["default"], { primary: "\u30E6\u30FC\u30B6\u30FC\u7BA1\u7406" }))),
                React.createElement(react_router_bootstrap_1.LinkContainer, { to: "/admin/systemsetting" },
                    React.createElement(ListItem_1["default"], { button: true, key: "" },
                        React.createElement(ListItemIcon_1["default"], null,
                            React.createElement(Settings_1["default"], null)),
                        React.createElement(ListItemText_1["default"], { primary: "\u30B7\u30B9\u30C6\u30E0\u7BA1\u7406" }))))),
        React.createElement("main", { className: classes.content },
            React.createElement("div", { className: classes.toolbar }),
            props.children)));
}
exports["default"] = Drawers;

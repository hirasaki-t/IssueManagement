import { AppBar, Button, Divider, Drawer, IconButton, List, ListItem, ListItemText, makeStyles, Toolbar, Typography, useTheme } from "@material-ui/core";
import * as React from "react";
import MenuIcon from '@material-ui/icons/Dehaze';
import BackIcon from '@material-ui/icons/ChevronLeftOutlined';
import NextIcon from '@material-ui/icons/ChevronRightOutlined';


/**
 * アプリケーションバーコンポーネント
 */
const appBar: React.FC = () => {

    return (
        <div>
            <AppBar position="absolute">
                <Toolbar>
                    <IconButton edge="start"  color="inherit" aria-label="menu">
                        <MenuIcon />
                    </IconButton>
                    <Typography variant="h6" >
                        課題管理Webアプリ
                    </Typography>
                </Toolbar>
            </AppBar>       
        </div>
    );
}

export default appBar;
import React from 'react';
import { Link } from 'react-router-dom';
import { LinkContainer } from 'react-router-bootstrap';
import { createStyles, Theme, makeStyles } from '@material-ui/core/styles';
import Drawer from '@material-ui/core/Drawer';
import CssBaseline from '@material-ui/core/CssBaseline';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import List from '@material-ui/core/List';
import Typography from '@material-ui/core/Typography';
import Divider from '@material-ui/core/Divider';
import ListItem from '@material-ui/core/ListItem';
import ListItemIcon from '@material-ui/core/ListItemIcon';
import ListItemText from '@material-ui/core/ListItemText';
import HomeIcon from '@material-ui/icons/Home';
import ProjectIcon from '@material-ui/icons/ListAlt';
import HistoryIcon from '@material-ui/icons/History';
import UserSettingIcon from '@material-ui/icons/Settings';
import AdminSettingIcon from '@material-ui/icons/GroupAdd';
import AccountBoxIcon from '@material-ui/icons/AccountBox';

const drawerWidth = 240;

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    root: {
      display: 'flex',
    },
    appBar: {
      width: `calc(100% - ${drawerWidth}px)`,
      marginLeft: drawerWidth,
    },
    drawer: {
      width: drawerWidth,
      flexShrink: 0,
    },
    drawerPaper: {
      width: drawerWidth,
    },
    // necessary for content to be below app bar
    toolbar: theme.mixins.toolbar,
    content: {
      flexGrow: 1,
      backgroundColor: theme.palette.background.default,
      padding: theme.spacing(3),
    },
  }),
);


const Drawers: React.FC = ({children}) => {
  const classes = useStyles();
  return (
    <div className={classes.root}>
      <CssBaseline />
      <AppBar position="fixed" className={classes.appBar}>
        <Toolbar>
          <Typography variant="h6" noWrap>
            課題管理システム(仮)
          </Typography>
        </Toolbar>
      </AppBar>
      <Drawer
        className={classes.drawer}
        variant="permanent"
        classes={{
          paper: classes.drawerPaper,
        }}
        anchor="left"
      >
        <div className={classes.toolbar} />
        <Divider />
        <List>
          <LinkContainer to ="/">
            <ListItem button key="">
              <ListItemIcon><HomeIcon /></ListItemIcon>
              <ListItemText primary="ホーム" />
            </ListItem>
          </LinkContainer>
          <LinkContainer to ="/list">
            <ListItem button key="">
              <ListItemIcon><ProjectIcon /></ListItemIcon>
              <ListItemText primary="案件リスト" />
            </ListItem>
          </LinkContainer>
          <LinkContainer to="/archive">
            <ListItem button key="">
              <ListItemIcon><HistoryIcon /></ListItemIcon>
              <ListItemText primary="過去の案件" />
            </ListItem>
          </LinkContainer>
        </List>
        <Divider />
        <List>
          <LinkContainer to="/setting">
            <ListItem button key="">
              <ListItemIcon><AccountBoxIcon /></ListItemIcon>
              <ListItemText primary="ユーザー設定" />
            </ListItem>
          </LinkContainer>
        </List>
        <Divider />
        <List>
          <LinkContainer to="/admin/usersetting">
            <ListItem button key="">
              <ListItemIcon><AdminSettingIcon /></ListItemIcon>
              <ListItemText primary="ユーザー管理" />
            </ListItem>
          </LinkContainer>
          <LinkContainer to="/admin/systemsetting">
            <ListItem button key="">
              <ListItemIcon><UserSettingIcon /></ListItemIcon>
              <ListItemText primary="システム管理" />
            </ListItem>
          </LinkContainer>
        </List>
      </Drawer>
      
      <main className={classes.content}>
        <div className={classes.toolbar} />
            {children}
      </main>
    </div>
  );
}

export default Drawers;
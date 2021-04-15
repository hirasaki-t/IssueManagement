import React from 'react';
import ReactDOM from 'react-dom';
import { HashRouter, Route, Switch } from 'react-router-dom';
import List from '../src/pages/ProjectListPage';
import Home from '../src/pages/HomePage';
import Archive from "../src/pages/ArchiveListPage";
import Issue from "../src/pages/IssueListPage";
import Message from "../src/pages/MessagePage";
import UserSetting from "../src/pages/ProfileSettingPage"
import ManageUser from "../src/pages/UserManagementPage";
import ManageSystem from "../src/pages/SystemSettingPage";

const Index: React.FC = () => (
  <HashRouter>
    <Switch>
      <Route exact path="/" render={() => <Home />} />
      <Route exact path="/list" render={() => <List />} />
      <Route exact path="/archive" render={() => <Archive />} />
      <Route exact path="/project/issue" render={() => <Issue />} />
      <Route exact path="/project/issue/message" render={() => <Message />} />
      <Route exact path="/setting" render={() => <UserSetting />} />
      <Route exact path="/admin/usersetting" render={() => <ManageUser />} />
      <Route exact path="/admin/systemsetting" render={() => <ManageSystem />} />
    </Switch>
  </HashRouter>
);
ReactDOM.render(<Index />, document.getElementById('root'));
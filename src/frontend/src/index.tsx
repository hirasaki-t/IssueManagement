import React from 'react';
import ReactDOM from 'react-dom';
import { HashRouter, Route, Switch } from 'react-router-dom';
import List from '../src/ts/pages/projectListPage';
import Home from '../src/ts/pages/homePage';
import Archive from "../src/ts/pages/archiveListPage";
import Issue from "../src/ts/pages/issueListPage";
import UserSetting from "../src/ts/pages/profileSettingPage"
import ManageUser from "../src/ts/pages/userManagementPage";
import ManageSystem from "../src/ts/pages/systemSettingPage";

const Index: React.FC = () =>(
  <HashRouter>
    <Switch>
      <Route exact path="/" render={() => <Home />} />  
      <Route exact path = "/list" render={() => <List />} />
      <Route exact path="/archive" render={() => <Archive />} />
      <Route exact path="/project/issue" render={() => <Issue />} />
      <Route exact path="/setting" render={() => <UserSetting />} />
      <Route exact path="/admin/usersetting" render={() => <ManageUser />} />
      <Route exact path="/admin/systemsetting" render={() => <ManageSystem />} />
    </Switch>
  </HashRouter>
);

ReactDOM.render(<Index />, document.getElementById('root'));
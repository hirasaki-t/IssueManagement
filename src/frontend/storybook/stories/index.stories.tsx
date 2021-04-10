import * as React from 'react';
import { storiesOf } from '@storybook/react';

import SignInPage from "../../src/ts/pages/signInPage"
import HomePage from "../../src/ts/pages/homePage"
import MyPage from "../../src/ts/pages/profileSettingPage"
import ProjectsListPage from "../../src/ts/pages/projectListPage"
import ArchiveListPage from "../../src/ts/pages/archiveListPage"
import IssueListPage from "../../src/ts/pages/issueListPage"
import MessagePage from "../../src/ts/pages/messagePage"
import UserManagementPage from "../../src/ts/pages/userManagementPage"
import SystemSettingPage from "../../src/ts/pages/systemSettingPage"

import QuestionAndAnswerTable from "../../src/ts/components/issueListTable"
import AddSubjectDialog from "../../src/ts/components/addSubject" 
import ProjectsListTable from "../../src/ts/components/projectListTable"
import ArchiveListTable from "../../src/ts/components/archiveListTable"
import Answer from "../../src/ts/components/answer" 
import Question from "../../src/ts/components/question" 
import TextInput from "../../src/ts/components/textInput"
import UserManagementTable from "../../src/ts/components/userManagementTable" 
import Drawer from "../../src/ts/components/drawers" 

storiesOf('page', module)
  .add('サインイン', () => <SignInPage />)
  .add('ホーム画面', () => <HomePage />)
  .add('案件リスト画面', () => <ProjectsListPage />)
  .add('過去の案件画面', () => <ArchiveListPage />)
  .add('課題リスト画面', () => <IssueListPage />)
  .add('やりとり画面', () => <MessagePage />)
  .add('ユーザー設定画面', () => <MyPage />)
  .add('ユーザー管理画面', () => <UserManagementPage />)
  .add('システム設定画面', () => <SystemSettingPage />);

  storiesOf('components', module)
  .add('案件リストテーブル', () => <ProjectsListTable />)
  .add('アーカイブテーブル', () => <ArchiveListTable />)
  .add('課題管理テーブル', () => <QuestionAndAnswerTable />)
  .add('課題追加ダイアログ', () => <AddSubjectDialog />)
  .add('質問', () => <Question />)
  .add('回答', () => <Answer />)
  .add('テキスト入力', () => <TextInput />)
  .add('ユーザー管理テーブル', () => <UserManagementTable />)
  .add('メニュー部分', () => <Drawer/>);
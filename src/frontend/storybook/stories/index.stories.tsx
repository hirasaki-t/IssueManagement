import * as React from 'react';
import { storiesOf } from '@storybook/react';

import SignInPage from "../../src/ts/pages/signInPage"
import MyPage from "../../src/ts/pages/profileSettingPage"
import ProjectsListPage from "../../src/ts/pages/projectListPage"
import ArchiveListPage from "../../src/ts/pages/archiveListPage"
import SubjectListPage from "../../src/ts/pages/subjectListPage"
import ExchangeOpinionPage from "../../src/ts/pages/exchangeOpinion"
import UserManagementPage from "../../src/ts/pages/userManagementPage"
import SystemSettingPage from "../../src/ts/pages/systemSettingPage"

import AppBar from "../../src/ts/components/appBar"
import QuestionAndAnswerTable from "../../src/ts/components/subjectListTable"
import AddSubjectDialog from "../../src/ts/components/addSubject" 
import ProjectsListTable from "../../src/ts/components/projectListTable"
import ArchiveListTable from "../../src/ts/components/archiveListTable"
import Answer from "../../src/ts/components/answer" 
import Question from "../../src/ts/components/question" 
import TextInput from "../../src/ts/components/textInput"
import UserManagementTable from "../../src/ts/components/userManagementTable" 

storiesOf('page', module)
  .add('サインイン', () => <SignInPage />)
  .add('プロフィール設定画面', () => <MyPage />)
  .add('進行案件一覧画面', () => <ProjectsListPage />)
  .add('終了案件一覧画面', () => <ArchiveListPage />)
  .add('課題一覧画面', () => <SubjectListPage />)
  .add('やりとり画面', () => <ExchangeOpinionPage />)
  .add('ユーザー管理画面', () => <UserManagementPage />)
  .add('システム設定画面', () => <SystemSettingPage />);

  storiesOf('components', module)
  .add('アプリケーションバー', () => <AppBar />)
  .add('案件リストテーブル', () => <ProjectsListTable />)
  .add('アーカイブテーブル', () => <ArchiveListTable />)
  .add('課題管理テーブル', () => <QuestionAndAnswerTable />)
  .add('課題追加ダイアログ', () => <AddSubjectDialog />)
  .add('質問', () => <Question />)
  .add('回答', () => <Answer />)
  .add('テキスト入力', () => <TextInput />)
  .add('ユーザー管理テーブル', () => <UserManagementTable />);
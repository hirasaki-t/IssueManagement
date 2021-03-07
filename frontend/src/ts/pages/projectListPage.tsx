import * as React from 'react';
import 'typeface-roboto';

import AppBar from '../components/appBar';
import ProjectsListTable from '../components/projectListTable';
import '../../css/style.scss';

// プロジェクトテーブル構造
interface ProjectList{
    projectID : number;
    projectStatusID : number;
    issueID : number;
    project : string;
}

const projectsListPage: React.FC = () => {
 
    // Adapter.sendJsonAsync("messages", message: { name: string; body: string }).then(e => {
    //     if (e instanceof Array) this.setState({ messages: e as ProjectList[] });
    //   });

    return (
        <div>
            <AppBar />
            <div className="Page stackContainer">
            </div>
            <ProjectsListTable />
        </div>
    );
}

export default projectsListPage;
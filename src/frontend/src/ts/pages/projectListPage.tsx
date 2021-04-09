import * as React from 'react';
import 'typeface-roboto';

import Drawers from '../components/drawers';
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
 
   return (
        <div>
            <Drawers>
                <ProjectsListTable />
            </Drawers>
        </div>
    );
}

export default projectsListPage;
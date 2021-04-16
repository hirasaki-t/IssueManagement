import Drawers from '../components/Drawers';
import { Button } from '@material-ui/core';
import ProjectsListTable from '../components/ProjectListTable';
import '../css/style.scss';

// プロジェクトテーブル構造
interface ProjectList {
    projectID: number;
    projectStatusID: number;
    issueID: number;
    project: string;
}

function ProjectsListPage() {

    return (
        <div className="stackContainer">
            <Drawers>
                <div className="rightStackContainer">
                    <Button variant="contained" color="primary">案件の新規追加</Button>
                </div>
                <div>
                    <ProjectsListTable />
                </div>
            </Drawers>
        </div>
    );
}

export default ProjectsListPage;
import Drawers from '../components/Drawers';
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
        <div>
            <Drawers>
                <ProjectsListTable />
            </Drawers>
        </div>
    );
}

export default ProjectsListPage;
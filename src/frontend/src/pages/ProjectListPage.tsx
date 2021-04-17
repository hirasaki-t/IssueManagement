import Drawers from '../components/Drawers';
import AddProjectButton from "../components/AddProject";
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
                <div className="stackContainer">
                    <div className="rightStackContainer">
                        <AddProjectButton />
                    </div>
                    <ProjectsListTable />
                </div>
            </Drawers>
        </div>
    );
}

export default ProjectsListPage;
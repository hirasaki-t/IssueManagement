import React, { createContext, useState } from "react";
import Drawers from '../components/Drawers';
import AddProjectButton from "../components/AddProject";
import ProjectsListTable from '../components/ProjectListTable';
import '../css/style.scss';
import { Project } from "../datas/Project"

/** 案件コンテキスト */
export const ProjectContext = React.createContext({});

/** 案件リストページ */
function ProjectsListPage() {

    /** 案件一覧 */
    const [projects, setProjects] = useState<Project[]>([]);

    return (
        <div>
            <Drawers>
                <div className="stackContainer">
                    <ProjectContext.Provider value={projects}>
                        <div className="rightStackContainer">
                            <AddProjectButton />
                        </div>
                        <ProjectsListTable />
                    </ProjectContext.Provider>
                </div>
            </Drawers>
        </div>
    );
}

export default ProjectsListPage;
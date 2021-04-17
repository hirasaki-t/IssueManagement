import SimpleMDE from 'react-simplemde-editor';
import { useState } from "react";
import AddIssueButton from "../components/AddIssue";
import ProjectDisplay from "../components/ProjectDisplay";
import Drowers from '../components/Drawers';
import IssueTable from '../components/IssueListTable';
import '../css/style.scss';

function IssueListPage() {
    const [markdown, setMarkdown] = useState('');
    return (
        <div>
            <Drowers>
                <div className="stackContainer">
                    <ProjectDisplay />
                    <div className="rightStackContainer">
                        <AddIssueButton />
                    </div>
                    <IssueTable />
                    <SimpleMDE onChange={(e) => setMarkdown(e)} options={{
                        autofocus: true,
                        spellChecker: false,
                        toolbar: ["bold", "italic", "strikethrough", "heading", "|", "code", "quote", "link", "image", "table", "|", "preview"]
                    }} />
                </div>
            </Drowers>
        </div>
    );
}
export default IssueListPage;
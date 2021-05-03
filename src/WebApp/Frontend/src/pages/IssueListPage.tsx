import SimpleMDE from 'react-simplemde-editor';
import { useState } from "react";
import AddIssueButton from "../components/AddIssue";
import Drowers from '../components/Drawers';
import IssueTable from '../components/IssueListTable';
import '../css/style.scss';

/** 課題リストページ */
function IssueListPage() {

    /** マークダウンエディタ情報 */
    const [markdown, setMarkdown] = useState('');

    return (
        <div>
            <Drowers>
                <div className="stackContainer">
                    <div className="rightStackContainer">
                        <AddIssueButton />
                    </div>
                    <IssueTable />
                    <SimpleMDE onChange={(e) => setMarkdown(e)} options={{
                        autofocus: true,
                        spellChecker: false,
                        toolbar: ["bold", "italic", "strikethrough", "|", "code", "quote", "link", "image", "table", "|", "preview"]
                    }} />
                </div>
            </Drowers>
        </div>
    );
}
export default IssueListPage;
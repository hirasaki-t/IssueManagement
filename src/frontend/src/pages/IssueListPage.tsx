import SimpleMDE from 'react-simplemde-editor';
import { useState } from "react";

import Drowers from '../components/Drawers';
import IssueTable from '../components/IssueListTable';
import '../css/style.scss';

function IssueListPage() {
    const [markdown, setMarkdown] = useState('');
    return (
        <div>
            <Drowers>
                <SimpleMDE onChange={(e) => setMarkdown(e)} options={{
                    autofocus: true, spellChecker: false,
                    toolbar: ["bold", "italic", "strikethrough", "heading", "|", "code", "quote", "link", "image", "table", "|", "preview"]
                }} />
                <IssueTable />
            </Drowers>
        </div>
    );
}
export default IssueListPage;
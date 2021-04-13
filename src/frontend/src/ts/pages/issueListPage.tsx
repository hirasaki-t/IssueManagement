import * as React from 'react';
import 'typeface-roboto';
import SimpleMDE from 'react-simplemde-editor';
import { useState } from "react";

import Drowers from '../components/drawers';
import IssueTable from '../components/issueListTable';
import '../../css/style.scss';

const IssueListPage: React.FC = () => {
    const [markdown, setMarkdown] = useState('');
    return (
        <div>
            <Drowers>
                <SimpleMDE onChange={(e) => setMarkdown(e)} options = {{autofocus:true, spellChecker:false, 
                    toolbar:["bold","italic","strikethrough","heading","|","code","quote","link","image","table","|","preview"]}}/>
                <IssueTable /> 
            </Drowers>
        </div>
    );
}
export default IssueListPage;
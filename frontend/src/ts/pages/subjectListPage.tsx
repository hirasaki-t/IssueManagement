import * as React from 'react';
import 'typeface-roboto';

import AppBar from '../components/appBar';
import QuestionAndAnswerTable from '../components/subjectListTable';
import '../../css/style.scss';

const questionAnswerPage: React.FC = () => {

    return (
        <div>
            <AppBar />
            <div className="Page stackContainer">
            </div>
            <QuestionAndAnswerTable />
        </div>
    );
}

export default questionAnswerPage;
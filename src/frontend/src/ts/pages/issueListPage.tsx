import * as React from 'react';
import 'typeface-roboto';

import Drowers from '../components/drawers';
import QuestionAndAnswerTable from '../components/issueListTable';
import '../../css/style.scss';

const issueListPage: React.FC = () => {

    return (
        <div>
            <Drowers>
                <QuestionAndAnswerTable />
            </Drowers>
        </div>
    );
}

export default issueListPage;
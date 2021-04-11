import * as React from 'react';
import 'typeface-roboto';

import Drowers from '../components/drawers';
import IssueTable from '../components/issueListTable';
import '../../css/style.scss';

const IssueListPage: React.FC = () => {

    return (
        <div>
            <Drowers>
                <IssueTable />
            </Drowers>
        </div>
    );
}
export default IssueListPage;
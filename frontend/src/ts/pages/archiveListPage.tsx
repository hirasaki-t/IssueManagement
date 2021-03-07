import * as React from 'react';
import 'typeface-roboto';

import AppBar from '../components/appBar';
import ArchiveListTable from '../components/archiveListTable';
import '../../css/style.scss';

const archiveListPage: React.FC = () => {

    return (
        <div>
            <AppBar />
            <div className="Page stackContainer">
            </div>
            <ArchiveListTable />
        </div>
    );
}

export default archiveListPage;
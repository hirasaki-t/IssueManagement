import * as React from 'react';
import 'typeface-roboto';

import Drawers from '../components/drawers';
import ArchiveListTable from '../components/archiveListTable';
import '../../css/style.scss';

const ArchiveListPage: React.FC = () => {

    return (
        <div>
            <Drawers>
                <ArchiveListTable />
            </Drawers>
        </div>
    );
}

export default ArchiveListPage;
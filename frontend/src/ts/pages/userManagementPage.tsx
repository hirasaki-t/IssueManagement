import * as React from 'react';
import 'typeface-roboto';

import AppBar from '../components/appBar';
import UserManagementTable from '../components/userManagementTable';
import '../../css/style.scss';

const userManagementPage: React.FC = () => {

    return (
        <div>
            <AppBar />
            <div className="Page stackContainer">
            </div>
            <UserManagementTable />
        </div>
    );
}

export default userManagementPage;
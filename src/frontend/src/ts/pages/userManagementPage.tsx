import * as React from 'react';
import 'typeface-roboto';

import Drowers from '../components/drawers';
import UserManagementTable from '../components/userManagementTable';
import '../../css/style.scss';

const UserManagementPage: React.FC = () => {

    return (
        <div>
            <Drowers>
                <UserManagementTable />
            </Drowers>
        </div>
    );
}

export default UserManagementPage;
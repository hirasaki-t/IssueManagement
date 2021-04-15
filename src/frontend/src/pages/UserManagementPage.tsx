import Drowers from '../components/Drawers';
import UserManagementTable from '../components/UserManagementTable';
import '../css/style.scss';

function UserManagementPage() {

    return (
        <div>
            <Drowers>
                <UserManagementTable />
            </Drowers>
        </div>
    );
}

export default UserManagementPage;
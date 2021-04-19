import Drowers from '../components/Drawers';
import AddUser from "../components/AddUser"
import UserManagementTable from '../components/UserManagementTable';
import '../css/style.scss';

function UserManagementPage() {

    return (
        <div>
            <Drowers>
                <div className="stackContainer">
                    <div className="rightStackContainer">
                        <AddUser />
                    </div>
                    <UserManagementTable />
                </div>
            </Drowers>
        </div>
    );
}

export default UserManagementPage;
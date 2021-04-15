import Drawers from '../components/Drawers';
import ArchiveListTable from '../components/ArchiveListTable';
import '../css/style.scss';

function ArchiveListPage() {

    return (
        <div>
            <Drawers>
                <ArchiveListTable />
            </Drawers>
        </div>
    );
}

export default ArchiveListPage;
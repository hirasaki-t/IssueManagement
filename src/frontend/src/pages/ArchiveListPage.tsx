import Drawers from '../components/Drawers';
import ArchiveListTable from '../components/ArchiveListTable';
import '../css/style.scss';

/** 過去の案件ページ */
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
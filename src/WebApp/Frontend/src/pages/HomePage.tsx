import Drawers from '../components/Drawers';
import '../css/style.scss';

/** ホームページ */
function HomePage() {

    return (
        <div>
            <Drawers>
                <h1>課題管理システム(仮)</h1>
                とりあえず最初に飛ばされるホーム画面<br />
                1回目のリリースでは静的画面な想定<br />
                将来的に通知の役割など拡張性を持たせたい。
            </Drawers>
        </div>
    );
}

export default HomePage;
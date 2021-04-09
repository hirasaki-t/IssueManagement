import * as React from 'react';
import 'typeface-roboto';

import Drawers from '../components/drawers';
import QuestionAndAnswerTable from '../components/issueListTable';
import '../../css/style.scss';

const homePage: React.FC = () => {

    return (
        <div>
            <Drawers>
                <h1>課題管理システム(仮)</h1>
                とりあえず最初に飛ばされるホーム画面<br/>
                1回目のリリースでは静的画面な想定<br/>
                将来的に通知の役割など拡張性を持たせたい。
            </Drawers>
        </div>
    );
}

export default homePage;
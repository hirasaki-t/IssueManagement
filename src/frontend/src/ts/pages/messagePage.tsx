import * as React from 'react';
import 'typeface-roboto';

import Drowers from '../components/drawers';
import Answer from '../components/answer';
import Question from '../components/question';
import TextInput from '../components/textInput'
import '../../css/style.scss';

const messagePage: React.FC = () => {

    return (
        <div>
            <Drowers/>
        </div>
    );
}

{/* <Question />
<Answer />
<Answer />
<Question />
<TextInput /> */}
export default messagePage;
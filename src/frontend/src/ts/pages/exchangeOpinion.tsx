import * as React from 'react';
import 'typeface-roboto';

import AppBar from '../components/appBar';
import Answer from '../components/answer';
import Question from '../components/question';
import TextInput from '../components/textInput'
import '../../css/style.scss';

const exchangeOpinion: React.FC = () => {

    return (
        <div>
            <AppBar />
            <div className="Page stackContainer">
            <div className="App">
                <Question />
                <Answer />
                <Answer />
                <Question />
                <TextInput />
        </div>
            </div>
        </div>
    );
}

export default exchangeOpinion;
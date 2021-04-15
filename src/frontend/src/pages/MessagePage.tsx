import Drowers from '../components/Drawers';
import Answer from '../components/Answer';
import Question from '../components/Question';
import TextInput from '../components/TextInput'
import '../css/style.scss';

function MessagePage() {

    return (
        <div>
            <Drowers>
                <Question />
                <Answer />
                <Answer />
                <Question />
                <TextInput />
            </Drowers>
        </div>
    );
}


export default MessagePage;
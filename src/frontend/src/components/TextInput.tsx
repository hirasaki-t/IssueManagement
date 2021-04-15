import TextField from '@material-ui/core/TextField';
import '../css/style.scss';
import { Button, Icon } from "@material-ui/core";

function TextInput() {

    return (
        <div className="Page stackContainer ">
            <div className="leftStackContainer">
                <span>
                    <TextField label="メッセージを入力" multiline className="inputText" rows={4} variant="outlined" />
                </span>
                <span>
                    <Button className="sendButton" variant="contained" color="primary" endIcon={<Icon>send</Icon>} > 投稿 </Button>
                </span>
            </div>
        </div>
    );

}

export default TextInput;
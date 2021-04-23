import '../css/style.scss';
import Avatar from '@material-ui/core/Avatar';
import PersonIcon from '@material-ui/icons/Person';
import { TextField } from '@material-ui/core';

/** メッセージの質問 */
function Question() {

  return (
    <div className="stackContainer">
      <div className='rightStackContainer'>
        <TextField className="question" label="自分" value="あああああああああああああ" multiline={true} InputProps={{ readOnly: true }} />
        <Avatar>
          <PersonIcon />
        </Avatar>
      </div>
      <div className='rightStackContainer'>
        <h5>2021/01/01 10:00</h5>
      </div>
    </div>
  );
}

export default Question;
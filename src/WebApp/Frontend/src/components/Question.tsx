import '../css/style.scss';
import Avatar from '@material-ui/core/Avatar';
import PersonIcon from '@material-ui/icons/Person';
import { TextField, IconButton } from '@material-ui/core';
import { Edit, Delete } from '@material-ui/icons';

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
        <IconButton color="primary" component="span">
          <Edit />
        </IconButton>
        <IconButton color="primary" component="span">
          <Delete />
        </IconButton>
      </div>

    </div>
  );
}

export default Question;
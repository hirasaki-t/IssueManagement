import '../css/style.scss';
import Avatar from '@material-ui/core/Avatar';
import PersonIcon from '@material-ui/icons/Person';
import { TextField } from '@material-ui/core';

function Answer() {

  return (
    <div className="stackContainer">
      <div className='leftStackContainer'>
        <Avatar>
          <PersonIcon />
        </Avatar>
        <TextField className="question" label="田中次郎 <aaaaaaaaaaa@gmail.com>" value="あああああああああああああ" multiline={true} InputProps={{ readOnly: true }} />
      </div>
      <div className='leftStackContainer'>
        <h5>2021/01/01 10:00</h5>
      </div>
    </div>
  );
}

export default Answer;
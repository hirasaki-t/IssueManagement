import Drowers from '../components/Drawers';
import '../css/style.scss';
import { Button, FormControl, IconButton, InputAdornment, InputLabel, OutlinedInput, TextField } from '@material-ui/core';
import { Visibility, VisibilityOff } from '@material-ui/icons';

/** ユーザー設定ページ */
function ProfileSettingPage() {

    return (
        <div>
            <Drowers>
                <div className="stackContainer">
                    <div>
                        <TextField className="setting_name" label="名前" variant="outlined" InputProps={{ readOnly: true }} />
                    </div>
                    <div>
                        <TextField className="setting_email" label="Email" variant="outlined" />
                    </div>
                    <div>
                        <FormControl className="setting_pass" variant="outlined">
                            <InputLabel htmlFor="outlined-adornment-password">Password</InputLabel>
                            <OutlinedInput
                                id="outlined-adornment-password"
                                type={"" ? 'text' : 'password'}
                                endAdornment={
                                    <InputAdornment position="end">
                                        <IconButton aria-label="toggle password visibility" edge="end" >
                                            {"" ? <Visibility /> : <VisibilityOff />}
                                        </IconButton>
                                    </InputAdornment>
                                }
                                labelWidth={70}
                            />
                        </FormControl>
                    </div>
                    <div>
                        <Button variant="contained" color="primary">変更を保存</Button>
                    </div>
                </div>
            </Drowers>
        </div>
    );
}


export default ProfileSettingPage;
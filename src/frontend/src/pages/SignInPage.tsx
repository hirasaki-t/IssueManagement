import '../css/style.scss';
import { Button, Card, CardActions, CardContent, FormControl, IconButton, InputAdornment, InputLabel, OutlinedInput, TextField, Typography } from '@material-ui/core';
import { Visibility, VisibilityOff } from '@material-ui/icons';

/** サインインページ */
function SignInPage() {

    return (
        <Card className="signin_Card">
            <CardContent>
                <Typography variant="h5" component="h2">
                    サインイン
                </Typography>
                <CardActions>
                    <TextField className="signin_user" label="Email" variant="outlined" />
                </CardActions>
                <CardActions>
                    <FormControl className="signin_pass" variant="outlined">
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
                </CardActions>
                <CardActions className="rightStackContainer">
                    <Button variant="contained" color="primary">サインイン</Button>
                </CardActions>
            </CardContent>
        </Card>
    );
}

export default SignInPage;
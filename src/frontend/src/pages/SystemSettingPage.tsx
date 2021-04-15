import React from 'react';

import Drowers from '../components/Drawers';
import '../css/style.scss';
import { Button, Card, CardContent, Chip, makeStyles, OutlinedInput, TextField } from '@material-ui/core';

function SystemSettingPage() {

    const useStyles = makeStyles((theme) => ({
        root: {
            display: 'flex',
            justifyContent: 'center',
            flexWrap: 'wrap',
            listStyle: 'none',
            padding: theme.spacing(0.5),
            margin: 0,
        },
        chip: {
            margin: theme.spacing(0.5),
        },
    }));

    const classes = useStyles();
    const [chipData, setChipData] = React.useState([
        { key: 0, label: 'Angular' },
        { key: 1, label: 'jQuery' },
        { key: 2, label: 'Polymer' },
        { key: 3, label: 'React' },
        { key: 4, label: 'Vue.js' },
    ]);

    const handleDelete = (chipToDelete: { key: number; }) => () => {
        setChipData((chips) => chips.filter((chip) => chip.key !== chipToDelete.key));
    };


    return (
        <div>
            <Drowers>
                <div className="stackContainer">

                    <Card className="systemSetting_card" style={{ backgroundColor: "#f5f5f5" }}>
                        <CardContent>
                            <div>
                                <h3>部署管理</h3>
                            </div>
                            <div>
                                <Chip label="総務部" onDelete={handleDelete} className={classes.chip} />
                                <Chip label="人事部" onDelete={handleDelete} className={classes.chip} />
                                <Chip label="経理部" onDelete={handleDelete} className={classes.chip} />
                                <Chip label="マーケティング部" onDelete={handleDelete} className={classes.chip} />
                                <Chip label="広報部" onDelete={handleDelete} className={classes.chip} />
                                <Chip label="開発部" onDelete={handleDelete} className={classes.chip} />
                            </div>
                            <div>
                                <TextField className="systemSetting_textfield" label="新規追加したい部署名" variant="outlined" />
                                <Button variant="contained" color="primary">追加</Button>
                            </div>
                        </CardContent>
                    </Card>
                    <Card className="systemSetting_card" style={{ backgroundColor: "#f5f5f5" }}>
                        <CardContent>
                            <div>
                                <h3>全閲覧権限付与部署</h3>
                            </div>
                            <div>
                                <Chip label="開発部" onDelete={handleDelete} className={classes.chip} />
                            </div>
                            <div>
                                <TextField className="systemSetting_textfield" label="新規追加したい部署名" variant="outlined" />
                                <Button variant="contained" color="primary">追加</Button>
                            </div>
                        </CardContent>
                    </Card>
                    <div>
                        <Button variant="contained" color="primary">変更を保存</Button>
                    </div>

                </div>
            </Drowers>
        </div>
    );
}


export default SystemSettingPage;


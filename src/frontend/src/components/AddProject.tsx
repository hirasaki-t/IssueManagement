import React from 'react';
import '../css/style.scss';
import { Select, MenuItem, TextField, InputLabel, FormControl, Button, Dialog } from '@material-ui/core';

function AddProject() {

    const [open, setOpen] = React.useState(false);

    /** 「案件の新規追加」ボタンの状態がTrue */
    const handleClickOpen = () => {
        setOpen(true);
    };

    /** 「案件の新規追加」ボタンの状態がFalse */
    const handleClose = () => {
        setOpen(false);
    };

    const [departments, setDepartments] = React.useState<string[]>([]);

    const handleChange = (event: React.ChangeEvent<{ value: unknown }>) => {
        setDepartments(event.target.value as string[]);
    };

    return (
        <div>
            <Button variant="contained" color="primary" onClick={handleClickOpen}>案件の新規追加</Button>
            <Dialog open={open}>
                <div className="dialog_mergin stackContainer">
                    <div>
                        <TextField className="addProject_name" label="案件名" variant="outlined" InputProps={{ readOnly: true }} />
                    </div>
                    <div>
                        <FormControl variant="outlined" >
                            <InputLabel id="addProject_status">案件ステータス</InputLabel>
                            <Select className="addProject_status">
                                <MenuItem value={1}>未着手</MenuItem>
                                <MenuItem value={2}>要求分析</MenuItem>
                                <MenuItem value={3}>要件定義</MenuItem>
                                <MenuItem value={4}>基本設計</MenuItem>
                                <MenuItem value={5}>詳細設計</MenuItem>
                                <MenuItem value={6}>開発</MenuItem>
                                <MenuItem value={7}>内部テスト</MenuItem>
                                <MenuItem value={8}>ユーザーテスト</MenuItem>
                                <MenuItem value={9}>リリース準備</MenuItem>
                                <MenuItem value={10}>リリース</MenuItem>
                            </Select>
                        </FormControl>
                    </div>
                    <div>
                        <FormControl variant="outlined" >
                            <InputLabel id="addProject_department">部署</InputLabel>
                            <Select className="addProject_department" multiple value={departments} onChange={handleChange}>
                                <MenuItem value="1">開発</MenuItem>
                                <MenuItem value="2">営業</MenuItem>
                            </Select>
                        </FormControl>
                    </div>
                    <Button className="addProject_addButton" variant="contained" color="default" onClick={handleClose}>戻る</Button>
                    <Button className="addProject_addButton" variant="contained" color="primary" onClick={handleClose}>案件を追加</Button>
                </div>
            </Dialog>
        </div>
    );
}

export default AddProject;
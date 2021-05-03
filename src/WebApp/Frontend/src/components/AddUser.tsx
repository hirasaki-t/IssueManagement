import React from 'react';
import '../css/style.scss';
import { Select, MenuItem, TextField, InputLabel, FormControl, Button, Dialog } from '@material-ui/core';

/** ユーザーの新規追加 */
function AddUser() {

    /** ダイアログの表示状態 */
    const [open, setOpen] = React.useState(false);

    /** ダイアログを開く */
    const handleClickOpen = () => {
        setOpen(true);
    };

    /** ダイアログを閉じる */
    const handleClose = () => {
        setOpen(false);
    };

    /** 部門情報 */
    const [departments, setDepartments] = React.useState<string[]>([]);

    /** 権限情報 */
    const [authorities, setAuthorities] = React.useState<string[]>([]);

    /** 部門変更ハンドル */
    const departmentHandleChange = (event: React.ChangeEvent<{ value: unknown }>) => {
        setDepartments(event.target.value as string[]);
    };

    /** 権限変更ハンドル */
    const authoritiesHandleChange = (event: React.ChangeEvent<{ value: unknown }>) => {
        setAuthorities(event.target.value as string[]);
    };

    return (
        <div>
            <Button variant="contained" color="primary" onClick={handleClickOpen}>ユーザーの新規追加</Button>
            <Dialog open={open}>
                <div className="dialog_mergin stackContainer">
                    <div>
                        <TextField className="addProject_name" label="名前" variant="outlined" />
                    </div>
                    <div>
                        <TextField className="addProject_name" label="メールアドレス" variant="outlined" />
                    </div>
                    <div>
                        <TextField className="addProject_name" label="初期パスワード" variant="outlined" />
                    </div>
                    <div>
                        <FormControl variant="outlined" >
                            <InputLabel id="addProject_department">部署(複数選択可)</InputLabel>
                            <Select className="addProject_department" multiple value={departments} onChange={departmentHandleChange}>
                                <MenuItem value="1">開発</MenuItem>
                                <MenuItem value="2">営業</MenuItem>
                            </Select>
                        </FormControl>
                    </div>
                    <div>
                        <FormControl variant="outlined" >
                            <InputLabel id="addProject_department">権限</InputLabel>
                            <Select className="addProject_department" value={authorities} onChange={authoritiesHandleChange}>
                                <MenuItem value="1">一般</MenuItem>
                                <MenuItem value="2">管理者</MenuItem>
                            </Select>
                        </FormControl>
                    </div>
                    <div className="rightStackContainer">
                        <span>
                            <Button className="addProject_addButton" variant="contained" color="default" onClick={handleClose}>戻る</Button>
                        </span>
                        <span>
                            <Button className="addProject_addButton" variant="contained" color="primary" onClick={handleClose}>ユーザーを追加</Button>
                        </span>
                    </div>
                </div>
            </Dialog>
        </div>
    );
}

export default AddUser;
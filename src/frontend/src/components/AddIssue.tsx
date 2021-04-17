import React from 'react';
import '../css/style.scss';
import { Select, MenuItem, TextField, InputLabel, FormControl, Button, Dialog } from '@material-ui/core';

function AddIssue() {

  const [open, setOpen] = React.useState(false);

  /** 「課題の新規追加」ボタンの状態がTrue */
  const handleClickOpen = () => {
    setOpen(true);
  };

  /** 「課題の新規追加」ボタンの状態がFalse */
  const handleClose = () => {
    setOpen(false)
  };

  return (
    <div>
      <Button variant="contained" color="primary" onClick={handleClickOpen}>課題の新規追加</Button>
      <Dialog open={open}>
        <div className="dialog_mergin stackContainer">
          <div>
            <TextField className="addIssue_name" label="課題名" variant="outlined" InputProps={{ readOnly: true }} />
          </div>
          <div>
            <TextField className="addIssue_voter" label="起票者" variant="outlined" InputProps={{ readOnly: true }} />
          </div>
          <div>
            <FormControl variant="outlined" >
              <InputLabel id="addProject_department">ステータス</InputLabel>
              <Select className="addProject_department">
                <MenuItem value={1}>未解決</MenuItem>
                <MenuItem value={2}>解決済</MenuItem>
                <MenuItem value={3}>保留</MenuItem>
                <MenuItem value={4}>取消</MenuItem>
              </Select>
            </FormControl>
          </div>
          <Button className="addProject_addButton" variant="contained" color="default" onClick={handleClose}>戻る</Button>
          <Button className="addProject_addButton" variant="contained" color="primary" onClick={handleClose}>課題を追加</Button>
        </div>
      </Dialog>
    </div>
  );
}

export default AddIssue;
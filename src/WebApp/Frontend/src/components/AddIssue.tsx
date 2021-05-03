import React from 'react';
import '../css/style.scss';
import { Select, MenuItem, TextField, InputLabel, FormControl, Button, Dialog } from '@material-ui/core';

/** 課題の新規追加 */
function AddIssue() {

  /** ダイアログの表示状態 */
  const [open, setOpen] = React.useState(false);

  /** ダイアログを開く */
  const handleClickOpen = () => {
    setOpen(true);
  };

  /** ダイアログを閉じる */
  const handleClose = () => {
    setOpen(false)
  };

  return (
    <div>
      <Button variant="contained" color="primary" onClick={handleClickOpen}>課題の新規追加</Button>
      <Dialog open={open}>
        <div className="dialog_mergin stackContainer">
          <div>
            <TextField className="addIssue_name" label="課題名" variant="outlined" />
          </div>
          <div>
            <FormControl variant="outlined" >
              <InputLabel id="addIssue_voter">起票者</InputLabel>
              <Select className="addIssue_voter">
                <MenuItem value={1}>田中二郎</MenuItem>
                <MenuItem value={2}>山田太郎</MenuItem>
                <MenuItem value={3}>鈴木一郎</MenuItem>
              </Select>
            </FormControl>
          </div>
          <div>
            <FormControl variant="outlined" >
              <InputLabel id="addIssue_status">ステータス</InputLabel>
              <Select className="addIssue_status">
                <MenuItem value={1}>未解決</MenuItem>
                <MenuItem value={2}>解決済</MenuItem>
                <MenuItem value={3}>保留</MenuItem>
                <MenuItem value={4}>取消</MenuItem>
              </Select>
            </FormControl>
          </div>
          <div className="rightStackContainer">
            <span>
              <Button className="addIssue_returnButton" variant="contained" color="default" onClick={handleClose}>戻る</Button>
            </span>
            <span>
              <Button className="addIssue_addButton" variant="contained" color="primary" onClick={handleClose}>課題を追加</Button>
            </span>
          </div>
        </div>
      </Dialog>
    </div>
  );
}

export default AddIssue;
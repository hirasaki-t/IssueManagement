import React from 'react';
import { TextField, FormControl, InputLabel, Select, MenuItem, Button } from "@material-ui/core";

function ProjectDisplay() {

    const [departments, setDepartments] = React.useState<string[]>([]);

    const handleChange = (event: React.ChangeEvent<{ value: unknown }>) => {
        setDepartments(event.target.value as string[]);
    };

    return (
        <div className="stackContainer">
            <div>
                <TextField label="プロジェクト名" className="editProject_name" value="プロジェクトA" />
            </div>
            <div>
                <FormControl >
                    <InputLabel id="editProject_sutatus">ステータス</InputLabel>
                    <Select className="addProject_department">
                        <MenuItem value={1}>未解決</MenuItem>
                        <MenuItem value={2}>解決済</MenuItem>
                        <MenuItem value={3}>保留</MenuItem>
                        <MenuItem value={4}>取消</MenuItem>
                    </Select>
                </FormControl>
            </div>
            <div>
                <FormControl >
                    <InputLabel id="editProject_departments">部署</InputLabel>
                    <Select className="addProject_department" multiple value={departments} onChange={handleChange}>
                        <MenuItem value="1">開発</MenuItem>
                        <MenuItem value="2">営業</MenuItem>
                    </Select>
                </FormControl>
            </div>
            <Button className="addProject_addButton" variant="contained" color="primary" >更新</Button>
        </div>
    );
}

export default ProjectDisplay;
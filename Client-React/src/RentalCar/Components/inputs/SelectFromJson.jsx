
import { Box, FormControl, InputLabel, MenuItem, Select } from "@mui/material";
import { useState } from "react"

const ITEM_HEIGHT = 40;
const ITEM_PADDING_TOP = 8;
const MenuProps = {
    PaperProps: {
        style: {
            maxHeight: ITEM_HEIGHT * 4.5 + ITEM_PADDING_TOP,
            width: 250,
        },
    },
};

export const SelectFromJson = ({ label = "", values, setValueToSave = () => { }, callReach, callSave, value = null, required = false }) => {

    const [valueInput, setValueInput] = useState()

    const changeValue = (event) => {
        setValueInput(event.target.value)
        setValueToSave(callSave(event.target.value))
    }

    return <>
        <Box sx={{ minWidth: 140 }}>
            <FormControl fullWidth>
                <InputLabel id="demo-simple-select-label">{label}</InputLabel>
                <Select
                    labelId="demo-simple-select-label"
                    // id="demo-simple-select"
                    value={valueInput}
                    label={label}
                    defaultValue={value}
                    onChange={(e) => changeValue(e)}
                    required={required}
                    MenuProps={MenuProps}
                >
                    {values.map((x) => {
                        if (callReach(x) != callReach(value))
                            return <MenuItem value={x}>{callReach(x)}</MenuItem>
                        else
                            return <MenuItem value={x} selected={true}>{callReach(x)}</MenuItem>
                    }
                    )}
                </Select>
            </FormControl>
        </Box>
    </>

}
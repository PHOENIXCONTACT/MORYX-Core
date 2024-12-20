/*
 * Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
 * Licensed under the Apache License, Version 2.0
*/

import MenuItem from "@mui/material/MenuItem";
import TextField from "@mui/material/TextField";
import Tooltip from "@mui/material/Tooltip";
import * as React from "react";
import Entry from "../../models/Entry";
import { InputEditorBasePropModel } from "./InputEditorBase";

interface SelectionStateModel {
    PossibleValues: string[];
}

export default class SelectionEditorBase extends React.Component<InputEditorBasePropModel, SelectionStateModel> {
    constructor(props: InputEditorBasePropModel) {
        super(props);
        if (this.props.Entry.value.possible != null) {
            const possibleValues: string[] = [...this.props.Entry.value.possible];
            if (possibleValues.find((value: string) => value === this.props.Entry.value.current) === undefined) {
                possibleValues.unshift("");
            }
            this.state = { PossibleValues: possibleValues };
        }

    }

    public onValueChange(value: string, entry: Entry): void {
        entry.value.current = value;
        this.setState({ PossibleValues: this.props.Entry.value.possible });
        this.forceUpdate();
    }

    public render(): React.ReactNode {
        return (
            <Tooltip title={this.props.Entry.description} placement="right">
                <TextField
                    select={true}
                    fullWidth={true}
                    value={this.props.Entry.value.current !== null ? this.props.Entry.value.current : ""}
                    size="small"
                    margin="dense"
                    label={this.props.Entry.displayName}
                    disabled={this.props.Entry.value.isReadOnly || this.props.IsReadOnly}
                    onChange={(e) => this.onValueChange(e.target.value, this.props.Entry)}>
                    {
                        (this.state != null) ?
                        this.state.PossibleValues.map((possibleValue, idx) => {
                            return (<MenuItem key={idx} value={possibleValue}>{possibleValue}</MenuItem>);
                        })
                        : null
                    }
                </TextField>
            </Tooltip>
        );
    }
}

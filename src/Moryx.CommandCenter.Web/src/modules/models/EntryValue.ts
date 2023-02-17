/*
 * Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
 * Licensed under the Apache License, Version 2.0
*/

import { EntryValueType } from "./EntryValueType";

export default class EntryValue {
    public type: EntryValueType;
    public current: string;
    public default: string;
    public possible: string[];
    public isReadOnly: boolean;
}

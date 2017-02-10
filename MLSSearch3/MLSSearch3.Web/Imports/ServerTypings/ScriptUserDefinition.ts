﻿namespace MLSSearch3 {
    export interface ScriptUserDefinition {
        Username?: string;
        DisplayName?: string;
        IsAdmin?: boolean;
        Permissions?: { [key: string]: boolean };
    }
}


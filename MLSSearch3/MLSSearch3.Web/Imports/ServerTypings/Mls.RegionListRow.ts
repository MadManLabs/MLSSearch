namespace MLSSearch3.Mls {
    export interface RegionListRow {
        RegionId?: number;
        RegionCode?: string;
        RegionName?: string;
    }

    export namespace RegionListRow {
        export const idProperty = 'RegionId';
        export const nameProperty = 'RegionName';
        export const localTextPrefix = 'Mls.RegionList';
        export const lookupKey = 'Mls.RegionList';

        export function getLookup(): Q.Lookup<RegionListRow> {
            return Q.getLookup<RegionListRow>('Mls.RegionList');
        }

        export namespace Fields {
            export declare const RegionId: string;
            export declare const RegionCode: string;
            export declare const RegionName: string;
        }

        ['RegionId', 'RegionCode', 'RegionName'].forEach(x => (<any>Fields)[x] = x);
    }
}


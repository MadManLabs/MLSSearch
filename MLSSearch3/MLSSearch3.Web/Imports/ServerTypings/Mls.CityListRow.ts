namespace MLSSearch3.Mls {
    export interface CityListRow {
        CityId?: number;
        CityCode?: string;
        CityName?: string;
        RegionId?: number;
        RegionRegionCode?: string;
        RegionRegionName?: string;
    }

    export namespace CityListRow {
        export const idProperty = 'CityId';
        export const nameProperty = 'CityName';
        export const localTextPrefix = 'Mls.CityList';
        export const lookupKey = 'Mls.CityList';

        export function getLookup(): Q.Lookup<CityListRow> {
            return Q.getLookup<CityListRow>('Mls.CityList');
        }

        export namespace Fields {
            export declare const CityId: string;
            export declare const CityCode: string;
            export declare const CityName: string;
            export declare const RegionId: string;
            export declare const RegionRegionCode: string;
            export declare const RegionRegionName: string;
        }

        ['CityId', 'CityCode', 'CityName', 'RegionId', 'RegionRegionCode', 'RegionRegionName'].forEach(x => (<any>Fields)[x] = x);
    }
}


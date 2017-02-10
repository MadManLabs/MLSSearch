namespace MLSSearch3.Mls {
    export interface CityDistrictListRow {
        DistrictId?: number;
        CityCode?: string;
        DistrictName?: string;
        CityId?: number;
        CityCityCode?: string;
        CityCityName?: string;
        CityRegionId?: number;
    }

    export namespace CityDistrictListRow {
        export const idProperty = 'DistrictId';
        export const nameProperty = 'DistrictName';
        export const localTextPrefix = 'Mls.CityDistrictList';
        export const lookupKey = 'Mls.CityDistrictList';

        export function getLookup(): Q.Lookup<CityDistrictListRow> {
            return Q.getLookup<CityDistrictListRow>('Mls.CityDistrictList');
        }

        export namespace Fields {
            export declare const DistrictId: string;
            export declare const CityCode: string;
            export declare const DistrictName: string;
            export declare const CityId: string;
            export declare const CityCityCode: string;
            export declare const CityCityName: string;
            export declare const CityRegionId: string;
        }

        ['DistrictId', 'CityCode', 'DistrictName', 'CityId', 'CityCityCode', 'CityCityName', 'CityRegionId'].forEach(x => (<any>Fields)[x] = x);
    }
}


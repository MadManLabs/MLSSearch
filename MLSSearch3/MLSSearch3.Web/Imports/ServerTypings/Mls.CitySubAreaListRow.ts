namespace MLSSearch3.Mls {
    export interface CitySubAreaListRow {
        SubAreaId?: number;
        SubAreaCode?: string;
        SubAreaName?: string;
        DistrictId?: number;
        DistrictCityCode?: string;
        DistrictDistrictName?: string;
        DistrictCityId?: number;
    }

    export namespace CitySubAreaListRow {
        export const idProperty = 'SubAreaId';
        export const nameProperty = 'SubAreaName';
        export const localTextPrefix = 'Mls.CitySubAreaList';
        export const lookupKey = 'Mls.CitySubAreaList';

        export function getLookup(): Q.Lookup<CitySubAreaListRow> {
            return Q.getLookup<CitySubAreaListRow>('Mls.CitySubAreaList');
        }

        export namespace Fields {
            export declare const SubAreaId: string;
            export declare const SubAreaCode: string;
            export declare const SubAreaName: string;
            export declare const DistrictId: string;
            export declare const DistrictCityCode: string;
            export declare const DistrictDistrictName: string;
            export declare const DistrictCityId: string;
        }

        ['SubAreaId', 'SubAreaCode', 'SubAreaName', 'DistrictId', 'DistrictCityCode', 'DistrictDistrictName', 'DistrictCityId'].forEach(x => (<any>Fields)[x] = x);
    }
}


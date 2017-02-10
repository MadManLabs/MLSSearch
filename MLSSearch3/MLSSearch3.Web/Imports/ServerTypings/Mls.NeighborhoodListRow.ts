namespace MLSSearch3.Mls {
    export interface NeighborhoodListRow {
        NeighborhoodId?: number;
        NeighborhoodCode?: string;
        NeighborhoodName?: string;
        SubAreaCode?: string;
        SubAreaId?: number;
        SubAreaSubAreaCode?: string;
        SubAreaSubAreaName?: string;
        SubAreaDistrictId?: number;
    }

    export namespace NeighborhoodListRow {
        export const idProperty = 'NeighborhoodId';
        export const nameProperty = 'NeighborhoodName';
        export const localTextPrefix = 'Mls.NeighborhoodList';
        export const lookupKey = 'Mls.NeighborhoodList';

        export function getLookup(): Q.Lookup<NeighborhoodListRow> {
            return Q.getLookup<NeighborhoodListRow>('Mls.NeighborhoodList');
        }

        export namespace Fields {
            export declare const NeighborhoodId: string;
            export declare const NeighborhoodCode: string;
            export declare const NeighborhoodName: string;
            export declare const SubAreaCode: string;
            export declare const SubAreaId: string;
            export declare const SubAreaSubAreaCode: string;
            export declare const SubAreaSubAreaName: string;
            export declare const SubAreaDistrictId: string;
        }

        ['NeighborhoodId', 'NeighborhoodCode', 'NeighborhoodName', 'SubAreaCode', 'SubAreaId', 'SubAreaSubAreaCode', 'SubAreaSubAreaName', 'SubAreaDistrictId'].forEach(x => (<any>Fields)[x] = x);
    }
}


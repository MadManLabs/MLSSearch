namespace MLSSearch3.Mls {
    export interface SurreyDeltaApartment2016YtdRow {
        Id?: number;
        Pic?: number;
        Pics?: string;
        MlNo?: string;
        Status?: string;
        Address?: string;
        SubArea?: string;
        Complex?: string;
        Price?: number;
        ListDate?: string;
        ListPrice?: number;
        PrevPrice?: number;
        PriceDate?: string;
        SoldDate?: string;
        SoldPrice?: number;
        Dom?: number;
        TotBr?: number;
        TotBaths?: number;
        TotFlArea?: number;
        YrBlt?: number;
        Age?: number;
        FrontageFeet?: number;
        Depth?: number;
        Kitchens?: number;
        TypeDwell?: string;
        BylawRestrictions?: string;
        ListFirm1CodeOfficeName?: string;
        ListSalesRep1AgentName?: string;
        ListFirm2CodeOfficeName?: string;
        ListSalesRep2AgentName?: string;
        PriceTotFlArea?: number;
        SoldPricePerSqFt?: number;
        Area?: string;
        City?: string;
        SellingOffice1?: string;
        SellSalesRep1?: string;
        SellingOffice2?: string;
        SellSalesRep2?: string;
        LotSzAcres?: number;
        LotSzSqFt?: number;
        PostalCode?: string;
        OwnerName?: string;
        Buyer?: string;
        StratMtFee?: number;
        Locker?: string;
        TotalPrkng?: number;
        ParkingPlacesCovered?: number;
        Parking?: string;
        ProtectedOwnerName?: number;
        RegionId?: number;
        CityId?: number;
        DistrictId?: number;
        SubAreaId?: number;
        NeighborhoodId?: number;
        NeighborhoodNeighborhoodCode?: string;
        NeighborhoodNeighborhoodName?: string;
        NeighborhoodSubAreaCode?: string;
        NeighborhoodSubAreaId?: number;
        RegionRegionCode?: string;
        RegionRegionName?: string;
        CityCityCode?: string;
        CityCityName?: string;
        CityRegionId?: number;
        DistrictCityCode?: string;
        DistrictDistrictName?: string;
        DistrictCityId?: number;
        SubAreaSubAreaCode?: string;
        SubAreaSubAreaName?: string;
        SubAreaDistrictId?: number;
    }

    export namespace SurreyDeltaApartment2016YtdRow {
        export const idProperty = 'Id';
        export const nameProperty = 'MlNo';
        export const localTextPrefix = 'Mls.SurreyDeltaApartment2016Ytd';
        export const lookupKey = 'Mls.SurreyDeltaApartment2016Ytd';

        export function getLookup(): Q.Lookup<SurreyDeltaApartment2016YtdRow> {
            return Q.getLookup<SurreyDeltaApartment2016YtdRow>('Mls.SurreyDeltaApartment2016Ytd');
        }

        export namespace Fields {
            export declare const Id: string;
            export declare const Pic: string;
            export declare const Pics: string;
            export declare const MlNo: string;
            export declare const Status: string;
            export declare const Address: string;
            export declare const SubArea: string;
            export declare const Complex: string;
            export declare const Price: string;
            export declare const ListDate: string;
            export declare const ListPrice: string;
            export declare const PrevPrice: string;
            export declare const PriceDate: string;
            export declare const SoldDate: string;
            export declare const SoldPrice: string;
            export declare const Dom: string;
            export declare const TotBr: string;
            export declare const TotBaths: string;
            export declare const TotFlArea: string;
            export declare const YrBlt: string;
            export declare const Age: string;
            export declare const FrontageFeet: string;
            export declare const Depth: string;
            export declare const Kitchens: string;
            export declare const TypeDwell: string;
            export declare const BylawRestrictions: string;
            export declare const ListFirm1CodeOfficeName: string;
            export declare const ListSalesRep1AgentName: string;
            export declare const ListFirm2CodeOfficeName: string;
            export declare const ListSalesRep2AgentName: string;
            export declare const PriceTotFlArea: string;
            export declare const SoldPricePerSqFt: string;
            export declare const Area: string;
            export declare const City: string;
            export declare const SellingOffice1: string;
            export declare const SellSalesRep1: string;
            export declare const SellingOffice2: string;
            export declare const SellSalesRep2: string;
            export declare const LotSzAcres: string;
            export declare const LotSzSqFt: string;
            export declare const PostalCode: string;
            export declare const OwnerName: string;
            export declare const Buyer: string;
            export declare const StratMtFee: string;
            export declare const Locker: string;
            export declare const TotalPrkng: string;
            export declare const ParkingPlacesCovered: string;
            export declare const Parking: string;
            export declare const ProtectedOwnerName: string;
            export declare const RegionId: string;
            export declare const CityId: string;
            export declare const DistrictId: string;
            export declare const SubAreaId: string;
            export declare const NeighborhoodId: string;
            export declare const NeighborhoodNeighborhoodCode: string;
            export declare const NeighborhoodNeighborhoodName: string;
            export declare const NeighborhoodSubAreaCode: string;
            export declare const NeighborhoodSubAreaId: string;
            export declare const RegionRegionCode: string;
            export declare const RegionRegionName: string;
            export declare const CityCityCode: string;
            export declare const CityCityName: string;
            export declare const CityRegionId: string;
            export declare const DistrictCityCode: string;
            export declare const DistrictDistrictName: string;
            export declare const DistrictCityId: string;
            export declare const SubAreaSubAreaCode: string;
            export declare const SubAreaSubAreaName: string;
            export declare const SubAreaDistrictId: string;
        }

        ['Id', 'Pic', 'Pics', 'MlNo', 'Status', 'Address', 'SubArea', 'Complex', 'Price', 'ListDate', 'ListPrice', 'PrevPrice', 'PriceDate', 'SoldDate', 'SoldPrice', 'Dom', 'TotBr', 'TotBaths', 'TotFlArea', 'YrBlt', 'Age', 'FrontageFeet', 'Depth', 'Kitchens', 'TypeDwell', 'BylawRestrictions', 'ListFirm1CodeOfficeName', 'ListSalesRep1AgentName', 'ListFirm2CodeOfficeName', 'ListSalesRep2AgentName', 'PriceTotFlArea', 'SoldPricePerSqFt', 'Area', 'City', 'SellingOffice1', 'SellSalesRep1', 'SellingOffice2', 'SellSalesRep2', 'LotSzAcres', 'LotSzSqFt', 'PostalCode', 'OwnerName', 'Buyer', 'StratMtFee', 'Locker', 'TotalPrkng', 'ParkingPlacesCovered', 'Parking', 'ProtectedOwnerName', 'RegionId', 'CityId', 'DistrictId', 'SubAreaId', 'NeighborhoodId', 'NeighborhoodNeighborhoodCode', 'NeighborhoodNeighborhoodName', 'NeighborhoodSubAreaCode', 'NeighborhoodSubAreaId', 'RegionRegionCode', 'RegionRegionName', 'CityCityCode', 'CityCityName', 'CityRegionId', 'DistrictCityCode', 'DistrictDistrictName', 'DistrictCityId', 'SubAreaSubAreaCode', 'SubAreaSubAreaName', 'SubAreaDistrictId'].forEach(x => (<any>Fields)[x] = x);
    }
}


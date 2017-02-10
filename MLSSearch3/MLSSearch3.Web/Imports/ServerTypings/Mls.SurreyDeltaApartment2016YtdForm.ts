namespace MLSSearch3.Mls {
    export class SurreyDeltaApartment2016YtdForm extends Serenity.PrefixedContext {
        static formKey = 'Mls.SurreyDeltaApartment2016Ytd';

    }

    export interface SurreyDeltaApartment2016YtdForm {
        Pic: Serenity.DecimalEditor;
        Pics: Serenity.ImageUploadEditor;
        MlNo: Serenity.StringEditor;
        Status: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        SubArea: Serenity.StringEditor;
        Complex: Serenity.StringEditor;
        Price: Serenity.DecimalEditor;
        ListDate: Serenity.DateEditor;
        ListPrice: Serenity.DecimalEditor;
        PrevPrice: Serenity.DecimalEditor;
        PriceDate: Serenity.DateEditor;
        SoldDate: Serenity.DateEditor;
        SoldPrice: Serenity.DecimalEditor;
        Dom: Serenity.DecimalEditor;
        TotBr: Serenity.DecimalEditor;
        TotBaths: Serenity.DecimalEditor;
        TotFlArea: Serenity.DecimalEditor;
        YrBlt: Serenity.DecimalEditor;
        Age: Serenity.DecimalEditor;
        FrontageFeet: Serenity.DecimalEditor;
        Depth: Serenity.DecimalEditor;
        Kitchens: Serenity.DecimalEditor;
        TypeDwell: Serenity.StringEditor;
        BylawRestrictions: Serenity.StringEditor;
        ListFirm1CodeOfficeName: Serenity.StringEditor;
        ListSalesRep1AgentName: Serenity.StringEditor;
        ListFirm2CodeOfficeName: Serenity.StringEditor;
        ListSalesRep2AgentName: Serenity.StringEditor;
        PriceTotFlArea: Serenity.DecimalEditor;
        SoldPricePerSqFt: Serenity.DecimalEditor;
        Area: Serenity.StringEditor;
        City: Serenity.StringEditor;
        SellingOffice1: Serenity.StringEditor;
        SellSalesRep1: Serenity.StringEditor;
        SellingOffice2: Serenity.StringEditor;
        SellSalesRep2: Serenity.StringEditor;
        LotSzAcres: Serenity.DecimalEditor;
        LotSzSqFt: Serenity.DecimalEditor;
        PostalCode: Serenity.StringEditor;
        OwnerName: Serenity.StringEditor;
        Buyer: Serenity.StringEditor;
        StratMtFee: Serenity.DecimalEditor;
        Locker: Serenity.StringEditor;
        TotalPrkng: Serenity.DecimalEditor;
        ParkingPlacesCovered: Serenity.DecimalEditor;
        Parking: Serenity.StringEditor;
        ProtectedOwnerName: Serenity.DecimalEditor;
        NeighborhoodId: Serenity.LookupEditor;
        RegionId: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        DistrictId: Serenity.LookupEditor;
        SubAreaId: Serenity.LookupEditor;
    }

    [['Pic', () => Serenity.DecimalEditor], ['Pics', () => Serenity.ImageUploadEditor], ['MlNo', () => Serenity.StringEditor], ['Status', () => Serenity.StringEditor], ['Address', () => Serenity.StringEditor], ['SubArea', () => Serenity.StringEditor], ['Complex', () => Serenity.StringEditor], ['Price', () => Serenity.DecimalEditor], ['ListDate', () => Serenity.DateEditor], ['ListPrice', () => Serenity.DecimalEditor], ['PrevPrice', () => Serenity.DecimalEditor], ['PriceDate', () => Serenity.DateEditor], ['SoldDate', () => Serenity.DateEditor], ['SoldPrice', () => Serenity.DecimalEditor], ['Dom', () => Serenity.DecimalEditor], ['TotBr', () => Serenity.DecimalEditor], ['TotBaths', () => Serenity.DecimalEditor], ['TotFlArea', () => Serenity.DecimalEditor], ['YrBlt', () => Serenity.DecimalEditor], ['Age', () => Serenity.DecimalEditor], ['FrontageFeet', () => Serenity.DecimalEditor], ['Depth', () => Serenity.DecimalEditor], ['Kitchens', () => Serenity.DecimalEditor], ['TypeDwell', () => Serenity.StringEditor], ['BylawRestrictions', () => Serenity.StringEditor], ['ListFirm1CodeOfficeName', () => Serenity.StringEditor], ['ListSalesRep1AgentName', () => Serenity.StringEditor], ['ListFirm2CodeOfficeName', () => Serenity.StringEditor], ['ListSalesRep2AgentName', () => Serenity.StringEditor], ['PriceTotFlArea', () => Serenity.DecimalEditor], ['SoldPricePerSqFt', () => Serenity.DecimalEditor], ['Area', () => Serenity.StringEditor], ['City', () => Serenity.StringEditor], ['SellingOffice1', () => Serenity.StringEditor], ['SellSalesRep1', () => Serenity.StringEditor], ['SellingOffice2', () => Serenity.StringEditor], ['SellSalesRep2', () => Serenity.StringEditor], ['LotSzAcres', () => Serenity.DecimalEditor], ['LotSzSqFt', () => Serenity.DecimalEditor], ['PostalCode', () => Serenity.StringEditor], ['OwnerName', () => Serenity.StringEditor], ['Buyer', () => Serenity.StringEditor], ['StratMtFee', () => Serenity.DecimalEditor], ['Locker', () => Serenity.StringEditor], ['TotalPrkng', () => Serenity.DecimalEditor], ['ParkingPlacesCovered', () => Serenity.DecimalEditor], ['Parking', () => Serenity.StringEditor], ['ProtectedOwnerName', () => Serenity.DecimalEditor], ['NeighborhoodId', () => Serenity.LookupEditor], ['RegionId', () => Serenity.LookupEditor], ['CityId', () => Serenity.LookupEditor], ['DistrictId', () => Serenity.LookupEditor], ['SubAreaId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(SurreyDeltaApartment2016YtdForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}


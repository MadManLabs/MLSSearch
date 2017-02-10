﻿
namespace MLSSearch3.Mls.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Mls.SurreyDeltaApartment2016Ytd")]
    [BasedOnRow(typeof(Entities.SurreyDeltaApartment2016YtdRow))]
    public class SurreyDeltaApartment2016YtdColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public Double Pic { get; set; }
        [InlineImageFormatter, Width(200)]
        public String Pics { get; set; }
        [EditLink]
        public String MlNo { get; set; }
        [Width(20), QuickFilter]
        public String Status { get; set; }
        [Width(100),QuickFilter, LookupEditor(typeof(Entities.RegionListRow))]
        public Int16 RegionId { get; set; }
        [Width(100), QuickFilter]
        public Int16 CityId { get; set; }
        [Width(100), QuickFilter]
        public Int16 DistrictId { get; set; }
        [Width(100), QuickFilter]
        public Int16 SubAreaId { get; set; }
        [Width(100), QuickFilter]
        public Int16 NeighborhoodId { get; set; }
        public String Address { get; set; }
        public String SubArea { get; set; }
        public String Complex { get; set; }
        public Decimal Price { get; set; }
        public DateTime ListDate { get; set; }
        public Decimal ListPrice { get; set; }
        public Decimal PrevPrice { get; set; }
        public DateTime PriceDate { get; set; }
        public DateTime SoldDate { get; set; }
        public Decimal SoldPrice { get; set; }
        public Double Dom { get; set; }
        public Double TotBr { get; set; }
        public Double TotBaths { get; set; }
        public Double TotFlArea { get; set; }
        public Double YrBlt { get; set; }
        public Double Age { get; set; }
        public Decimal FrontageFeet { get; set; }
        public Decimal Depth { get; set; }
        public Double Kitchens { get; set; }
        public String TypeDwell { get; set; }
        public String BylawRestrictions { get; set; }
        public String ListFirm1CodeOfficeName { get; set; }
        public String ListSalesRep1AgentName { get; set; }
        public String ListFirm2CodeOfficeName { get; set; }
        public String ListSalesRep2AgentName { get; set; }
        public Decimal PriceTotFlArea { get; set; }
        public Decimal SoldPricePerSqFt { get; set; }
        public String Area { get; set; }
        public String City { get; set; }
        public String SellingOffice1 { get; set; }
        public String SellSalesRep1 { get; set; }
        public String SellingOffice2 { get; set; }
        public String SellSalesRep2 { get; set; }
        public Double LotSzAcres { get; set; }
        public Double LotSzSqFt { get; set; }
        public String PostalCode { get; set; }
        public String OwnerName { get; set; }
        public String Buyer { get; set; }
        public Decimal StratMtFee { get; set; }
        public String Locker { get; set; }
        public Double TotalPrkng { get; set; }
        public Double ParkingPlacesCovered { get; set; }
        public String Parking { get; set; }
        public Decimal ProtectedOwnerName { get; set; }
        
    }
}
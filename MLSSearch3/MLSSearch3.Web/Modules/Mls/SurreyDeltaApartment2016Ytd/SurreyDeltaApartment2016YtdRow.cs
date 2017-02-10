
namespace MLSSearch3.Mls.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MLS"), DisplayName("Surrey Delta Apartment2016 Ytd"), InstanceName("Surrey Delta Apartment2016 Ytd"), TwoLevelCached]
    [ReadPermission("Mls:SurreyDeltaApartment2016YTD:Read")]
    [InsertPermission("Mls:SurreyDeltaApartment2016YTD:Insert")]
    [UpdatePermission("Mls:SurreyDeltaApartment2016YTD:Update")]
    [DeletePermission("Mls:SurreyDeltaApartment2016YTD:Delete")]
    [LookupScript("Mls.SurreyDeltaApartment2016Ytd")]
    public sealed class SurreyDeltaApartment2016YtdRow : Row, IIdRow, INameRow
    {        
            #region Id
            [DisplayName("Id"), Column("ID"), Identity]
            public Int32? Id { get { return Fields.Id[this]; } set { Fields.Id[this] = value; } }
            public partial class RowFields { public Int32Field Id; }
            #endregion Id
                
            #region Pic
            [DisplayName("Pic"), Column("PIC")]
            public Double? Pic { get { return Fields.Pic[this]; } set { Fields.Pic[this] = value; } }
            public partial class RowFields { public DoubleField Pic; }
            #endregion Pic
                
            #region Pics
            [DisplayName("Pics"), Size(255), ImageUploadEditor(FilenameFormat = "")]
            public String Pics { get { return Fields.Pics[this]; } set { Fields.Pics[this] = value; } }
            public partial class RowFields { public StringField Pics; }
            #endregion Pics
                
            #region Ml No
            [DisplayName("Ml No"), Column("ML_no"), Size(50), NotNull, QuickSearch]
            public String MlNo { get { return Fields.MlNo[this]; } set { Fields.MlNo[this] = value; } }
            public partial class RowFields { public StringField MlNo; }
            #endregion MlNo
                
            #region Status
            [DisplayName("Status"), Size(255)]
            public String Status { get { return Fields.Status[this]; } set { Fields.Status[this] = value; } }
            public partial class RowFields { public StringField Status; }
            #endregion Status
                
            #region Address
            [DisplayName("Address"), Size(255), QuickSearch]
            public String Address { get { return Fields.Address[this]; } set { Fields.Address[this] = value; } }
            public partial class RowFields { public StringField Address; }
            #endregion Address
                
            #region Sub Area
            [DisplayName("Sub Area"), Size(255)]
            public String SubArea { get { return Fields.SubArea[this]; } set { Fields.SubArea[this] = value; } }
            public partial class RowFields { public StringField SubArea; }
            #endregion SubArea
                
            #region Complex
            [DisplayName("Complex"), Size(255)]
            public String Complex { get { return Fields.Complex[this]; } set { Fields.Complex[this] = value; } }
            public partial class RowFields { public StringField Complex; }
            #endregion Complex
                
            #region Price
            [DisplayName("Price"), Size(19), Scale(4)]
            public Decimal? Price { get { return Fields.Price[this]; } set { Fields.Price[this] = value; } }
            public partial class RowFields { public DecimalField Price; }
            #endregion Price
                
            #region List Date
            [DisplayName("List Date")]
            public DateTime? ListDate { get { return Fields.ListDate[this]; } set { Fields.ListDate[this] = value; } }
            public partial class RowFields { public DateTimeField ListDate; }
            #endregion ListDate
                
            #region List Price
            [DisplayName("List Price"), Size(19), Scale(4)]
            public Decimal? ListPrice { get { return Fields.ListPrice[this]; } set { Fields.ListPrice[this] = value; } }
            public partial class RowFields { public DecimalField ListPrice; }
            #endregion ListPrice
                
            #region Prev Price
            [DisplayName("Prev Price"), Size(19), Scale(4)]
            public Decimal? PrevPrice { get { return Fields.PrevPrice[this]; } set { Fields.PrevPrice[this] = value; } }
            public partial class RowFields { public DecimalField PrevPrice; }
            #endregion PrevPrice
                
            #region Price Date
            [DisplayName("Price Date")]
            public DateTime? PriceDate { get { return Fields.PriceDate[this]; } set { Fields.PriceDate[this] = value; } }
            public partial class RowFields { public DateTimeField PriceDate; }
            #endregion PriceDate
                
            #region Sold Date
            [DisplayName("Sold Date")]
            public DateTime? SoldDate { get { return Fields.SoldDate[this]; } set { Fields.SoldDate[this] = value; } }
            public partial class RowFields { public DateTimeField SoldDate; }
            #endregion SoldDate
                
            #region Sold Price
            [DisplayName("Sold Price"), Size(19), Scale(4)]
            public Decimal? SoldPrice { get { return Fields.SoldPrice[this]; } set { Fields.SoldPrice[this] = value; } }
            public partial class RowFields { public DecimalField SoldPrice; }
            #endregion SoldPrice
                
            #region Dom
            [DisplayName("Dom"), Column("DOM")]
            public Double? Dom { get { return Fields.Dom[this]; } set { Fields.Dom[this] = value; } }
            public partial class RowFields { public DoubleField Dom; }
            #endregion Dom
                
            #region Tot Br
            [DisplayName("Tot Br"), Column("TotBR")]
            public Double? TotBr { get { return Fields.TotBr[this]; } set { Fields.TotBr[this] = value; } }
            public partial class RowFields { public DoubleField TotBr; }
            #endregion TotBr
                
            #region Tot Baths
            [DisplayName("Tot Baths")]
            public Double? TotBaths { get { return Fields.TotBaths[this]; } set { Fields.TotBaths[this] = value; } }
            public partial class RowFields { public DoubleField TotBaths; }
            #endregion TotBaths
                
            #region Tot Fl Area
            [DisplayName("Tot Fl Area")]
            public Double? TotFlArea { get { return Fields.TotFlArea[this]; } set { Fields.TotFlArea[this] = value; } }
            public partial class RowFields { public DoubleField TotFlArea; }
            #endregion TotFlArea
                
            #region Yr Blt
            [DisplayName("Yr Blt")]
            public Double? YrBlt { get { return Fields.YrBlt[this]; } set { Fields.YrBlt[this] = value; } }
            public partial class RowFields { public DoubleField YrBlt; }
            #endregion YrBlt
                
            #region Age
            [DisplayName("Age")]
            public Double? Age { get { return Fields.Age[this]; } set { Fields.Age[this] = value; } }
            public partial class RowFields { public DoubleField Age; }
            #endregion Age
                
            #region Frontage Feet
            [DisplayName("Frontage Feet"), Size(19), Scale(4)]
            public Decimal? FrontageFeet { get { return Fields.FrontageFeet[this]; } set { Fields.FrontageFeet[this] = value; } }
            public partial class RowFields { public DecimalField FrontageFeet; }
            #endregion FrontageFeet
                
            #region Depth
            [DisplayName("Depth"), Size(19), Scale(4)]
            public Decimal? Depth { get { return Fields.Depth[this]; } set { Fields.Depth[this] = value; } }
            public partial class RowFields { public DecimalField Depth; }
            #endregion Depth
                
            #region Kitchens
            [DisplayName("Kitchens")]
            public Double? Kitchens { get { return Fields.Kitchens[this]; } set { Fields.Kitchens[this] = value; } }
            public partial class RowFields { public DoubleField Kitchens; }
            #endregion Kitchens
                
            #region Type Dwell
            [DisplayName("Type Dwell"), Size(255)]
            public String TypeDwell { get { return Fields.TypeDwell[this]; } set { Fields.TypeDwell[this] = value; } }
            public partial class RowFields { public StringField TypeDwell; }
            #endregion TypeDwell
                
            #region Bylaw Restrictions
            [DisplayName("Bylaw Restrictions"), Size(255)]
            public String BylawRestrictions { get { return Fields.BylawRestrictions[this]; } set { Fields.BylawRestrictions[this] = value; } }
            public partial class RowFields { public StringField BylawRestrictions; }
            #endregion BylawRestrictions
                
            #region List Firm1 Code Office Name
            [DisplayName("List Firm1 Code Office Name"), Column("ListFirm1Code_OfficeName"), Size(255)]
            public String ListFirm1CodeOfficeName { get { return Fields.ListFirm1CodeOfficeName[this]; } set { Fields.ListFirm1CodeOfficeName[this] = value; } }
            public partial class RowFields { public StringField ListFirm1CodeOfficeName; }
            #endregion ListFirm1CodeOfficeName
                
            #region List Sales Rep1 Agent Name
            [DisplayName("List Sales Rep1 Agent Name"), Column("ListSalesRep1_AgentName"), Size(255)]
            public String ListSalesRep1AgentName { get { return Fields.ListSalesRep1AgentName[this]; } set { Fields.ListSalesRep1AgentName[this] = value; } }
            public partial class RowFields { public StringField ListSalesRep1AgentName; }
            #endregion ListSalesRep1AgentName
                
            #region List Firm2 Code Office Name
            [DisplayName("List Firm2 Code Office Name"), Column("ListFirm2Code_OfficeName"), Size(255)]
            public String ListFirm2CodeOfficeName { get { return Fields.ListFirm2CodeOfficeName[this]; } set { Fields.ListFirm2CodeOfficeName[this] = value; } }
            public partial class RowFields { public StringField ListFirm2CodeOfficeName; }
            #endregion ListFirm2CodeOfficeName
                
            #region List Sales Rep2 Agent Name
            [DisplayName("List Sales Rep2 Agent Name"), Column("ListSalesRep2_AgentName"), Size(255)]
            public String ListSalesRep2AgentName { get { return Fields.ListSalesRep2AgentName[this]; } set { Fields.ListSalesRep2AgentName[this] = value; } }
            public partial class RowFields { public StringField ListSalesRep2AgentName; }
            #endregion ListSalesRep2AgentName
                
            #region Price Tot Fl Area
            [DisplayName("Price Tot Fl Area"), Size(19), Scale(4)]
            public Decimal? PriceTotFlArea { get { return Fields.PriceTotFlArea[this]; } set { Fields.PriceTotFlArea[this] = value; } }
            public partial class RowFields { public DecimalField PriceTotFlArea; }
            #endregion PriceTotFlArea
                
            #region Sold Price Per Sq Ft
            [DisplayName("Sold Price Per Sq Ft"), Size(19), Scale(4)]
            public Decimal? SoldPricePerSqFt { get { return Fields.SoldPricePerSqFt[this]; } set { Fields.SoldPricePerSqFt[this] = value; } }
            public partial class RowFields { public DecimalField SoldPricePerSqFt; }
            #endregion SoldPricePerSqFt
                
            #region Area
            [DisplayName("Area"), Size(255)]
            public String Area { get { return Fields.Area[this]; } set { Fields.Area[this] = value; } }
            public partial class RowFields { public StringField Area; }
            #endregion Area
                
            #region City
            [DisplayName("City"), Size(255), QuickSearch]
            public String City { get { return Fields.City[this]; } set { Fields.City[this] = value; } }
            public partial class RowFields { public StringField City; }
            #endregion City
                
            #region Selling Office1
            [DisplayName("Selling Office1"), Size(255)]
            public String SellingOffice1 { get { return Fields.SellingOffice1[this]; } set { Fields.SellingOffice1[this] = value; } }
            public partial class RowFields { public StringField SellingOffice1; }
            #endregion SellingOffice1
                
            #region Sell Sales Rep1
            [DisplayName("Sell Sales Rep1"), Size(255)]
            public String SellSalesRep1 { get { return Fields.SellSalesRep1[this]; } set { Fields.SellSalesRep1[this] = value; } }
            public partial class RowFields { public StringField SellSalesRep1; }
            #endregion SellSalesRep1
                
            #region Selling Office2
            [DisplayName("Selling Office2"), Size(255)]
            public String SellingOffice2 { get { return Fields.SellingOffice2[this]; } set { Fields.SellingOffice2[this] = value; } }
            public partial class RowFields { public StringField SellingOffice2; }
            #endregion SellingOffice2
                
            #region Sell Sales Rep2
            [DisplayName("Sell Sales Rep2"), Size(255)]
            public String SellSalesRep2 { get { return Fields.SellSalesRep2[this]; } set { Fields.SellSalesRep2[this] = value; } }
            public partial class RowFields { public StringField SellSalesRep2; }
            #endregion SellSalesRep2
                
            #region Lot Sz Acres
            [DisplayName("Lot Sz Acres"), Column("LotSz_Acres")]
            public Double? LotSzAcres { get { return Fields.LotSzAcres[this]; } set { Fields.LotSzAcres[this] = value; } }
            public partial class RowFields { public DoubleField LotSzAcres; }
            #endregion LotSzAcres
                
            #region Lot Sz Sq Ft
            [DisplayName("Lot Sz Sq Ft"), Column("LotSz_SqFt")]
            public Double? LotSzSqFt { get { return Fields.LotSzSqFt[this]; } set { Fields.LotSzSqFt[this] = value; } }
            public partial class RowFields { public DoubleField LotSzSqFt; }
            #endregion LotSzSqFt
                
            #region Postal Code
            [DisplayName("Postal Code"), Size(255)]
            public String PostalCode { get { return Fields.PostalCode[this]; } set { Fields.PostalCode[this] = value; } }
            public partial class RowFields { public StringField PostalCode; }
            #endregion PostalCode
                
            #region Owner Name
            [DisplayName("Owner Name"), Size(255)]
            public String OwnerName { get { return Fields.OwnerName[this]; } set { Fields.OwnerName[this] = value; } }
            public partial class RowFields { public StringField OwnerName; }
            #endregion OwnerName
                
            #region Buyer
            [DisplayName("Buyer"), Size(255)]
            public String Buyer { get { return Fields.Buyer[this]; } set { Fields.Buyer[this] = value; } }
            public partial class RowFields { public StringField Buyer; }
            #endregion Buyer
                
            #region Strat Mt Fee
            [DisplayName("Strat Mt Fee"), Size(19), Scale(4)]
            public Decimal? StratMtFee { get { return Fields.StratMtFee[this]; } set { Fields.StratMtFee[this] = value; } }
            public partial class RowFields { public DecimalField StratMtFee; }
            #endregion StratMtFee
                
            #region Locker
            [DisplayName("Locker"), Size(255)]
            public String Locker { get { return Fields.Locker[this]; } set { Fields.Locker[this] = value; } }
            public partial class RowFields { public StringField Locker; }
            #endregion Locker
                
            #region Total Prkng
            [DisplayName("Total Prkng")]
            public Double? TotalPrkng { get { return Fields.TotalPrkng[this]; } set { Fields.TotalPrkng[this] = value; } }
            public partial class RowFields { public DoubleField TotalPrkng; }
            #endregion TotalPrkng
                
            #region Parking Places Covered
            [DisplayName("Parking Places Covered"), Column("ParkingPlaces_Covered")]
            public Double? ParkingPlacesCovered { get { return Fields.ParkingPlacesCovered[this]; } set { Fields.ParkingPlacesCovered[this] = value; } }
            public partial class RowFields { public DoubleField ParkingPlacesCovered; }
            #endregion ParkingPlacesCovered
                
            #region Parking
            [DisplayName("Parking"), Size(255)]
            public String Parking { get { return Fields.Parking[this]; } set { Fields.Parking[this] = value; } }
            public partial class RowFields { public StringField Parking; }
            #endregion Parking
                
            #region Protected Owner Name
            [DisplayName("Protected Owner Name"), Column("Protected_Owner_Name"), Size(19), Scale(4)]
            public Decimal? ProtectedOwnerName { get { return Fields.ProtectedOwnerName[this]; } set { Fields.ProtectedOwnerName[this] = value; } }
            public partial class RowFields { public DecimalField ProtectedOwnerName; }
            #endregion ProtectedOwnerName
                
            #region Region
            [DisplayName("Region"), Column("RegionID"), ForeignKey("[mls].[RegionList]", "RegionID"), LeftJoin("jRegion"), TextualField("RegionRegionCode")]
            [LookupEditor(typeof(Mls.Entities.RegionListRow), InplaceAdd = true)]
            public Int16? RegionId { get { return Fields.RegionId[this]; } set { Fields.RegionId[this] = value; } }
            public partial class RowFields { public Int16Field RegionId; }
            #endregion RegionId
                
            #region City
            [DisplayName("City"), Column("CityID"), ForeignKey("[mls].[CityList]", "CityID"), LeftJoin("jCity"), TextualField("CityCityCode")]
            [LookupEditor(typeof(Mls.Entities.CityListRow), InplaceAdd = true)]
            public Int16? CityId { get { return Fields.CityId[this]; } set { Fields.CityId[this] = value; } }
            public partial class RowFields { public Int16Field CityId; }
            #endregion CityId
                
            #region District
            [DisplayName("District"), Column("DistrictID"), ForeignKey("[mls].[CityDistrictList]", "DistrictID"), LeftJoin("jDistrict"), TextualField("DistrictCityCode")]
            [LookupEditor(typeof(Mls.Entities.CityDistrictListRow), InplaceAdd = true)]
            public Int16? DistrictId { get { return Fields.DistrictId[this]; } set { Fields.DistrictId[this] = value; } }
            public partial class RowFields { public Int16Field DistrictId; }
            #endregion DistrictId
                
            #region Sub Area
            [DisplayName("Sub Area"), Column("SubAreaID"), ForeignKey("[mls].[CitySubAreaList]", "SubAreaID"), LeftJoin("jSubArea"), TextualField("SubAreaSubAreaCode")]
            [LookupEditor(typeof(Mls.Entities.CitySubAreaListRow), InplaceAdd = true)]
            public Int16? SubAreaId { get { return Fields.SubAreaId[this]; } set { Fields.SubAreaId[this] = value; } }
            public partial class RowFields { public Int16Field SubAreaId; }
        #endregion SubAreaId

        #region Neighborhood
        [DisplayName("Neighborhood"), Column("NeighborhoodID"), ForeignKey("[mls].[NeighborhoodList]", "NeighborhoodID"), LeftJoin("jNeighborhood"), TextualField("NeighborhoodNeighborhoodCode")]
        [LookupEditor(typeof(Mls.Entities.NeighborhoodListRow), InplaceAdd = true)]
        public Int16? NeighborhoodId { get { return Fields.NeighborhoodId[this]; } set { Fields.NeighborhoodId[this] = value; } }
        public partial class RowFields { public Int16Field NeighborhoodId; }
        #endregion NeighborhoodId


        #region Foreign Fields

        [DisplayName("Neighborhood Neighborhood Code"), Expression("jNeighborhood.[NeighborhoodCode]")]
                public String NeighborhoodNeighborhoodCode { get { return Fields.NeighborhoodNeighborhoodCode[this]; } set { Fields.NeighborhoodNeighborhoodCode[this] = value; } }
                public partial class RowFields { public StringField NeighborhoodNeighborhoodCode; }

                        
                [DisplayName("Neighborhood Neighborhood Name"), Expression("jNeighborhood.[NeighborhoodName]")]
                public String NeighborhoodNeighborhoodName { get { return Fields.NeighborhoodNeighborhoodName[this]; } set { Fields.NeighborhoodNeighborhoodName[this] = value; } }
                public partial class RowFields { public StringField NeighborhoodNeighborhoodName; }

                        
                [DisplayName("Neighborhood Sub Area Code"), Expression("jNeighborhood.[SubAreaCode]")]
                public String NeighborhoodSubAreaCode { get { return Fields.NeighborhoodSubAreaCode[this]; } set { Fields.NeighborhoodSubAreaCode[this] = value; } }
                public partial class RowFields { public StringField NeighborhoodSubAreaCode; }

                        
                [DisplayName("Neighborhood Sub Area Id"), Expression("jNeighborhood.[SubAreaID]")]
                public Int16? NeighborhoodSubAreaId { get { return Fields.NeighborhoodSubAreaId[this]; } set { Fields.NeighborhoodSubAreaId[this] = value; } }
                public partial class RowFields { public Int16Field NeighborhoodSubAreaId; }

                        
                [DisplayName("Region Region Code"), Expression("jRegion.[RegionCode]")]
                public String RegionRegionCode { get { return Fields.RegionRegionCode[this]; } set { Fields.RegionRegionCode[this] = value; } }
                public partial class RowFields { public StringField RegionRegionCode; }

                        
                [DisplayName("Region Region Name"), Expression("jRegion.[RegionName]")]
                public String RegionRegionName { get { return Fields.RegionRegionName[this]; } set { Fields.RegionRegionName[this] = value; } }
                public partial class RowFields { public StringField RegionRegionName; }

                        
                [DisplayName("City City Code"), Expression("jCity.[CityCode]")]
                public String CityCityCode { get { return Fields.CityCityCode[this]; } set { Fields.CityCityCode[this] = value; } }
                public partial class RowFields { public StringField CityCityCode; }

                        
                [DisplayName("City City Name"), Expression("jCity.[CityName]")]
                public String CityCityName { get { return Fields.CityCityName[this]; } set { Fields.CityCityName[this] = value; } }
                public partial class RowFields { public StringField CityCityName; }

                        
                [DisplayName("City Region Id"), Expression("jCity.[RegionID]")]
                public Int16? CityRegionId { get { return Fields.CityRegionId[this]; } set { Fields.CityRegionId[this] = value; } }
                public partial class RowFields { public Int16Field CityRegionId; }

                        
                [DisplayName("District City Code"), Expression("jDistrict.[CityCode]")]
                public String DistrictCityCode { get { return Fields.DistrictCityCode[this]; } set { Fields.DistrictCityCode[this] = value; } }
                public partial class RowFields { public StringField DistrictCityCode; }

                        
                [DisplayName("District District Name"), Expression("jDistrict.[DistrictName]")]
                public String DistrictDistrictName { get { return Fields.DistrictDistrictName[this]; } set { Fields.DistrictDistrictName[this] = value; } }
                public partial class RowFields { public StringField DistrictDistrictName; }

                        
                [DisplayName("District City Id"), Expression("jDistrict.[CityID]")]
                public Int16? DistrictCityId { get { return Fields.DistrictCityId[this]; } set { Fields.DistrictCityId[this] = value; } }
                public partial class RowFields { public Int16Field DistrictCityId; }

                        
                [DisplayName("Sub Area Sub Area Code"), Expression("jSubArea.[SubAreaCode]")]
                public String SubAreaSubAreaCode { get { return Fields.SubAreaSubAreaCode[this]; } set { Fields.SubAreaSubAreaCode[this] = value; } }
                public partial class RowFields { public StringField SubAreaSubAreaCode; }

                        
                [DisplayName("Sub Area Sub Area Name"), Expression("jSubArea.[SubAreaName]")]
                public String SubAreaSubAreaName { get { return Fields.SubAreaSubAreaName[this]; } set { Fields.SubAreaSubAreaName[this] = value; } }
                public partial class RowFields { public StringField SubAreaSubAreaName; }

                        
                [DisplayName("Sub Area District Id"), Expression("jSubArea.[DistrictID]")]
                public Int16? SubAreaDistrictId { get { return Fields.SubAreaDistrictId[this]; } set { Fields.SubAreaDistrictId[this] = value; } }
                public partial class RowFields { public Int16Field SubAreaDistrictId; }

            
    #endregion Foreign Fields

    #region Id and Name fields
    IIdField IIdRow.IdField
    {
    get { return Fields.Id; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.MlNo; }
            }
            #endregion Id and Name fields

    #region Constructor
    public SurreyDeltaApartment2016YtdRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[mls].[SurreyDeltaApartment2016YTD]")
    {
    LocalTextPrefix = "Mls.SurreyDeltaApartment2016Ytd";
    }
    }
    #endregion RowFields
    }
    }

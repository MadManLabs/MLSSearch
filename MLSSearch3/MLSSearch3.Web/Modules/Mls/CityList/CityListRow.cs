
namespace MLSSearch3.Mls.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MLS"), DisplayName("City List"), InstanceName("City List"), TwoLevelCached]
    [ReadPermission("Mls:CityList:Read")]
    [InsertPermission("Mls:CityList:Insert")]
    [UpdatePermission("Mls:CityList:Update")]
    [DeletePermission("Mls:CityList:Delete")]
    [LookupScript("Mls.CityList")]
    public sealed class CityListRow : Row, IIdRow, INameRow
    {        
            #region City Id
            [DisplayName("City Id"), Column("CityID"), Identity]
            public Int16? CityId { get { return Fields.CityId[this]; } set { Fields.CityId[this] = value; } }
            public partial class RowFields { public Int16Field CityId; }
            #endregion CityId
                
            #region City Code
            [DisplayName("City Code"), Size(20), QuickSearch]
            public String CityCode { get { return Fields.CityCode[this]; } set { Fields.CityCode[this] = value; } }
            public partial class RowFields { public StringField CityCode; }
            #endregion CityCode
                
            #region City Name
            [DisplayName("City Name"), Size(50)]
            public String CityName { get { return Fields.CityName[this]; } set { Fields.CityName[this] = value; } }
            public partial class RowFields { public StringField CityName; }
            #endregion CityName
                
            #region Region
            [DisplayName("Region"), Column("RegionID"), ForeignKey("[mls].[RegionList]", "RegionID"), LeftJoin("jRegion"), TextualField("RegionRegionCode")]
            [LookupEditor(typeof(Mls.Entities.RegionListRow), InplaceAdd = true), LookupInclude]
            public Int16? RegionId { get { return Fields.RegionId[this]; } set { Fields.RegionId[this] = value; } }
            public partial class RowFields { public Int16Field RegionId; }
            #endregion RegionId
        

    #region Foreign Fields
            
                [DisplayName("Region Region Code"), Expression("jRegion.[RegionCode]")]
                public String RegionRegionCode { get { return Fields.RegionRegionCode[this]; } set { Fields.RegionRegionCode[this] = value; } }
                public partial class RowFields { public StringField RegionRegionCode; }

                        
                [DisplayName("Region Region Name"), Expression("jRegion.[RegionName]")]
                public String RegionRegionName { get { return Fields.RegionRegionName[this]; } set { Fields.RegionRegionName[this] = value; } }
                public partial class RowFields { public StringField RegionRegionName; }

            
    #endregion Foreign Fields

    #region Id and Name fields
    IIdField IIdRow.IdField
    {
    get { return Fields.CityId; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.CityName; }
            }
            #endregion Id and Name fields

    #region Constructor
    public CityListRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[mls].[CityList]")
    {
    LocalTextPrefix = "Mls.CityList";
    }
    }
    #endregion RowFields
    }
    }

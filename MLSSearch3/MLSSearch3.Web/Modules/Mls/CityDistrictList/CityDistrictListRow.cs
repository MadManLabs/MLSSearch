
namespace MLSSearch3.Mls.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MLS"), DisplayName("City District List"), InstanceName("City District List"), TwoLevelCached]
    [ReadPermission("Mls:CityDistrictList:Read")]
    [InsertPermission("Mls:CityDistrictList:Insert")]
    [UpdatePermission("Mls:CityDistrictList:Update")]
    [DeletePermission("Mls:CityDistrictList:Delete")]
    [LookupScript("Mls.CityDistrictList")]
    public sealed class CityDistrictListRow : Row, IIdRow, INameRow
    {        
            #region District Id
            [DisplayName("District Id"), Column("DistrictID"), Identity]
            public Int16? DistrictId { get { return Fields.DistrictId[this]; } set { Fields.DistrictId[this] = value; } }
            public partial class RowFields { public Int16Field DistrictId; }
            #endregion DistrictId
                
            #region City Code
            [DisplayName("City Code"), Size(20), QuickSearch]
            public String CityCode { get { return Fields.CityCode[this]; } set { Fields.CityCode[this] = value; } }
            public partial class RowFields { public StringField CityCode; }
            #endregion CityCode
                
            #region District Name
            [DisplayName("District Name"), Size(50)]
            public String DistrictName { get { return Fields.DistrictName[this]; } set { Fields.DistrictName[this] = value; } }
            public partial class RowFields { public StringField DistrictName; }
            #endregion DistrictName
                
            #region City
            [DisplayName("City"), Column("CityID"), ForeignKey("[mls].[CityList]", "CityID"), LeftJoin("jCity"), TextualField("CityCityCode")]
            [LookupEditor(typeof(Mls.Entities.CityListRow), InplaceAdd = true), LookupInclude]
            public Int16? CityId { get { return Fields.CityId[this]; } set { Fields.CityId[this] = value; } }
            public partial class RowFields { public Int16Field CityId; }
            #endregion CityId
        

    #region Foreign Fields
            
                [DisplayName("City City Code"), Expression("jCity.[CityCode]")]
                public String CityCityCode { get { return Fields.CityCityCode[this]; } set { Fields.CityCityCode[this] = value; } }
                public partial class RowFields { public StringField CityCityCode; }

                        
                [DisplayName("City City Name"), Expression("jCity.[CityName]")]
                public String CityCityName { get { return Fields.CityCityName[this]; } set { Fields.CityCityName[this] = value; } }
                public partial class RowFields { public StringField CityCityName; }

                        
                [DisplayName("City Region Id"), Expression("jCity.[RegionID]")]
                public Int16? CityRegionId { get { return Fields.CityRegionId[this]; } set { Fields.CityRegionId[this] = value; } }
                public partial class RowFields { public Int16Field CityRegionId; }

            
    #endregion Foreign Fields

    #region Id and Name fields
    IIdField IIdRow.IdField
    {
    get { return Fields.DistrictId; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.DistrictName; }
            }
            #endregion Id and Name fields

    #region Constructor
    public CityDistrictListRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[mls].[CityDistrictList]")
    {
    LocalTextPrefix = "Mls.CityDistrictList";
    }
    }
    #endregion RowFields
    }
    }

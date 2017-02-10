
namespace MLSSearch3.Mls.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MLS"), DisplayName("City Sub Area List"), InstanceName("City Sub Area List"), TwoLevelCached]
    [ReadPermission("Mls:CitySubAreaList:Read")]
    [InsertPermission("Mls:CitySubAreaList:Insert")]
    [UpdatePermission("Mls:CitySubAreaList:Update")]
    [DeletePermission("Mls:CitySubAreaList:Delete")]
    [LookupScript("Mls.CitySubAreaList")]
    public sealed class CitySubAreaListRow : Row, IIdRow, INameRow
    {        
            #region Sub Area Id
            [DisplayName("Sub Area Id"), Column("SubAreaID"), Identity]
            public Int16? SubAreaId { get { return Fields.SubAreaId[this]; } set { Fields.SubAreaId[this] = value; } }
            public partial class RowFields { public Int16Field SubAreaId; }
            #endregion SubAreaId
                
            #region Sub Area Code
            [DisplayName("Sub Area Code"), Size(10), QuickSearch]
            public String SubAreaCode { get { return Fields.SubAreaCode[this]; } set { Fields.SubAreaCode[this] = value; } }
            public partial class RowFields { public StringField SubAreaCode; }
            #endregion SubAreaCode
                
            #region Sub Area Name
            [DisplayName("Sub Area Name"), Size(50)]
            public String SubAreaName { get { return Fields.SubAreaName[this]; } set { Fields.SubAreaName[this] = value; } }
            public partial class RowFields { public StringField SubAreaName; }
            #endregion SubAreaName
                
            #region District
            [DisplayName("District"), Column("DistrictID"), ForeignKey("[mls].[CityDistrictList]", "DistrictID"), LeftJoin("jDistrict"), TextualField("DistrictCityCode")]
            [LookupEditor(typeof(Mls.Entities.CityDistrictListRow), InplaceAdd = true), LookupInclude]
            public Int16? DistrictId { get { return Fields.DistrictId[this]; } set { Fields.DistrictId[this] = value; } }
            public partial class RowFields { public Int16Field DistrictId; }
            #endregion DistrictId
        

    #region Foreign Fields
            
                [DisplayName("District City Code"), Expression("jDistrict.[CityCode]")]
                public String DistrictCityCode { get { return Fields.DistrictCityCode[this]; } set { Fields.DistrictCityCode[this] = value; } }
                public partial class RowFields { public StringField DistrictCityCode; }

                        
                [DisplayName("District District Name"), Expression("jDistrict.[DistrictName]")]
                public String DistrictDistrictName { get { return Fields.DistrictDistrictName[this]; } set { Fields.DistrictDistrictName[this] = value; } }
                public partial class RowFields { public StringField DistrictDistrictName; }

                        
                [DisplayName("District City Id"), Expression("jDistrict.[CityID]")]
                public Int16? DistrictCityId { get { return Fields.DistrictCityId[this]; } set { Fields.DistrictCityId[this] = value; } }
                public partial class RowFields { public Int16Field DistrictCityId; }

            
    #endregion Foreign Fields

    #region Id and Name fields
    IIdField IIdRow.IdField
    {
    get { return Fields.SubAreaId; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.SubAreaName; }
            }
            #endregion Id and Name fields

    #region Constructor
    public CitySubAreaListRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[mls].[CitySubAreaList]")
    {
    LocalTextPrefix = "Mls.CitySubAreaList";
    }
    }
    #endregion RowFields
    }
    }

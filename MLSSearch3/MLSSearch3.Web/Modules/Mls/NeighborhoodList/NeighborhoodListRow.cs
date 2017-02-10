
namespace MLSSearch3.Mls.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MLS"), DisplayName("Neighborhood List"), InstanceName("Neighborhood List"), TwoLevelCached]
    [ReadPermission("Mls:NeighborhoodList:Read")]
    [InsertPermission("Mls:NeighborhoodList:Insert")]
    [UpdatePermission("Mls:NeighborhoodList:Update")]
    [DeletePermission("Mls:NeighborhoodList:Delete")]
    [LookupScript("Mls.NeighborhoodList")]
    public sealed class NeighborhoodListRow : Row, IIdRow, INameRow
    {        
            #region Neighborhood Id
            [DisplayName("Neighborhood Id"), Column("NeighborhoodID"), Identity]
            public Int16? NeighborhoodId { get { return Fields.NeighborhoodId[this]; } set { Fields.NeighborhoodId[this] = value; } }
            public partial class RowFields { public Int16Field NeighborhoodId; }
            #endregion NeighborhoodId
                
            #region Neighborhood Code
            [DisplayName("Neighborhood Code"), Size(10), QuickSearch]
            public String NeighborhoodCode { get { return Fields.NeighborhoodCode[this]; } set { Fields.NeighborhoodCode[this] = value; } }
            public partial class RowFields { public StringField NeighborhoodCode; }
            #endregion NeighborhoodCode
                
            #region Neighborhood Name
            [DisplayName("Neighborhood Name"), Size(50)]
            public String NeighborhoodName { get { return Fields.NeighborhoodName[this]; } set { Fields.NeighborhoodName[this] = value; } }
            public partial class RowFields { public StringField NeighborhoodName; }
            #endregion NeighborhoodName
                
            #region Sub Area Code
            [DisplayName("Sub Area Code"), Size(10)]
            public String SubAreaCode { get { return Fields.SubAreaCode[this]; } set { Fields.SubAreaCode[this] = value; } }
            public partial class RowFields { public StringField SubAreaCode; }
            #endregion SubAreaCode
                
            #region Sub Area
            [DisplayName("Sub Area"), Column("SubAreaID"), ForeignKey("[mls].[CitySubAreaList]", "SubAreaID"), LeftJoin("jSubArea"), TextualField("SubAreaSubAreaCode")]
            [LookupEditor(typeof(Mls.Entities.CitySubAreaListRow), InplaceAdd = true), LookupInclude]
            public Int16? SubAreaId { get { return Fields.SubAreaId[this]; } set { Fields.SubAreaId[this] = value; } }
            public partial class RowFields { public Int16Field SubAreaId; }
            #endregion SubAreaId
        

    #region Foreign Fields
            
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
    get { return Fields.NeighborhoodId; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.NeighborhoodName; }
            }
            #endregion Id and Name fields

    #region Constructor
    public NeighborhoodListRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[mls].[NeighborhoodList]")
    {
    LocalTextPrefix = "Mls.NeighborhoodList";
    }
    }
    #endregion RowFields
    }
    }

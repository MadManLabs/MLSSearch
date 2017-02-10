
namespace MLSSearch3.Mls.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MLS"), DisplayName("Region List"), InstanceName("Region List"), TwoLevelCached]
    [ReadPermission("Mls:RegionList:Read")]
    [InsertPermission("Mls:RegionList:Insert")]
    [UpdatePermission("Mls:RegionList:Update")]
    [DeletePermission("Mls:RegionList:Delete")]
    [LookupScript("Mls.RegionList")]
    public sealed class RegionListRow : Row, IIdRow, INameRow
    {        
            #region Region Id
            [DisplayName("Region Id"), Column("RegionID"), Identity]
            public Int16? RegionId { get { return Fields.RegionId[this]; } set { Fields.RegionId[this] = value; } }
            public partial class RowFields { public Int16Field RegionId; }
            #endregion RegionId
                
            #region Region Code
            [DisplayName("Region Code"), Size(20), QuickSearch]
            public String RegionCode { get { return Fields.RegionCode[this]; } set { Fields.RegionCode[this] = value; } }
            public partial class RowFields { public StringField RegionCode; }
            #endregion RegionCode
                
            #region Region Name
            [DisplayName("Region Name"), Size(50)]
            public String RegionName { get { return Fields.RegionName[this]; } set { Fields.RegionName[this] = value; } }
            public partial class RowFields { public StringField RegionName; }
            #endregion RegionName
        

    #region Foreign Fields

    #endregion Foreign Fields

    #region Id and Name fields
    IIdField IIdRow.IdField
    {
    get { return Fields.RegionId; }
    }
        
            StringField INameRow.NameField
            {
            get { return Fields.RegionName; }
            }
            #endregion Id and Name fields

    #region Constructor
    public RegionListRow()
    : base(Fields)
    {
    }
    #endregion Constructor

    #region RowFields
    public static readonly RowFields Fields = new RowFields().Init();

    public partial class RowFields : RowFieldsBase
    {
    public RowFields()
    : base("[mls].[RegionList]")
    {
    LocalTextPrefix = "Mls.RegionList";
    }
    }
    #endregion RowFields
    }
    }

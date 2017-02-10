
namespace MLSSearch3.Mls.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Mls.CitySubAreaList")]
    [BasedOnRow(typeof(Entities.CitySubAreaListRow))]
    public class CitySubAreaListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 SubAreaId { get; set; }
        [EditLink]
        public String SubAreaCode { get; set; }
        public String SubAreaName { get; set; }
        public Int16 DistrictId { get; set; }
    }
}
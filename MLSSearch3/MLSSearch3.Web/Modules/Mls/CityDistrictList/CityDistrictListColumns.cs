
namespace MLSSearch3.Mls.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Mls.CityDistrictList")]
    [BasedOnRow(typeof(Entities.CityDistrictListRow))]
    public class CityDistrictListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 DistrictId { get; set; }
        [EditLink]
        public String CityCode { get; set; }
        public String DistrictName { get; set; }
        public Int16 CityId { get; set; }
    }
}
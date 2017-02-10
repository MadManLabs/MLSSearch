
namespace MLSSearch3.Mls.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Mls.CityList")]
    [BasedOnRow(typeof(Entities.CityListRow))]
    public class CityListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 CityId { get; set; }
        [EditLink]
        public String CityCode { get; set; }
        public String CityName { get; set; }
        public Int16 RegionId { get; set; }
    }
}
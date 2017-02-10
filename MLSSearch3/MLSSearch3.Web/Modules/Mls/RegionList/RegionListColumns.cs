
namespace MLSSearch3.Mls.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Mls.RegionList")]
    [BasedOnRow(typeof(Entities.RegionListRow))]
    public class RegionListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 RegionId { get; set; }
        [EditLink]
        public String RegionCode { get; set; }
        public String RegionName { get; set; }
    }
}
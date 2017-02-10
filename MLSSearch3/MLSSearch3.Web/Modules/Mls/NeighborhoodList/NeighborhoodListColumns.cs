
namespace MLSSearch3.Mls.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Mls.NeighborhoodList")]
    [BasedOnRow(typeof(Entities.NeighborhoodListRow))]
    public class NeighborhoodListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int16 NeighborhoodId { get; set; }
        [EditLink]
        public String NeighborhoodCode { get; set; }
        public String NeighborhoodName { get; set; }
        public String SubAreaCode { get; set; }
        public Int16 SubAreaId { get; set; }
    }
}
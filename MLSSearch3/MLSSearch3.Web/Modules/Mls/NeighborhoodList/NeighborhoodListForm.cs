
namespace MLSSearch3.Mls.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Mls.NeighborhoodList")]
    [BasedOnRow(typeof(Entities.NeighborhoodListRow))]
    public class NeighborhoodListForm
    {
        public String NeighborhoodCode { get; set; }
        public String NeighborhoodName { get; set; }
        public String SubAreaCode { get; set; }
        public Int16 SubAreaId { get; set; }
    }
}
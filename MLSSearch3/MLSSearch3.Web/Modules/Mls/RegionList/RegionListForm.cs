
namespace MLSSearch3.Mls.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Mls.RegionList")]
    [BasedOnRow(typeof(Entities.RegionListRow))]
    public class RegionListForm
    {
        public String RegionCode { get; set; }
        public String RegionName { get; set; }
    }
}
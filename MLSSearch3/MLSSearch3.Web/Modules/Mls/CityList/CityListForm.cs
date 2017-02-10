
namespace MLSSearch3.Mls.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Mls.CityList")]
    [BasedOnRow(typeof(Entities.CityListRow))]
    public class CityListForm
    {
        public String CityCode { get; set; }
        public String CityName { get; set; }
        public Int16 RegionId { get; set; }
    }
}
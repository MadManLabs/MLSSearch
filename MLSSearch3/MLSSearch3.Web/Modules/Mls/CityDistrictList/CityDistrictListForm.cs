
namespace MLSSearch3.Mls.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Mls.CityDistrictList")]
    [BasedOnRow(typeof(Entities.CityDistrictListRow))]
    public class CityDistrictListForm
    {
        public String CityCode { get; set; }
        public String DistrictName { get; set; }
        public Int16 CityId { get; set; }
    }
}

namespace MLSSearch3.Mls.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Mls.CitySubAreaList")]
    [BasedOnRow(typeof(Entities.CitySubAreaListRow))]
    public class CitySubAreaListForm
    {
        public String SubAreaCode { get; set; }
        public String SubAreaName { get; set; }
        public Int16 DistrictId { get; set; }
    }
}
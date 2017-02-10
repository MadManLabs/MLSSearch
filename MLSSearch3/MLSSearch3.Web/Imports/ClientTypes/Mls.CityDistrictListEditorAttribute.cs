using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MLSSearch3.Mls
{
    public partial class CityDistrictListEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "MLSSearch3.Mls.CityDistrictListEditor";

        public CityDistrictListEditorAttribute()
            : base(Key)
        {
        }
    }
}


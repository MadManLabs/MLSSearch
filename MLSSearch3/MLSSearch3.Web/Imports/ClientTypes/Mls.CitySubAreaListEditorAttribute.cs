using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MLSSearch3.Mls
{
    public partial class CitySubAreaListEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "MLSSearch3.Mls.CitySubAreaListEditor";

        public CitySubAreaListEditorAttribute()
            : base(Key)
        {
        }
    }
}


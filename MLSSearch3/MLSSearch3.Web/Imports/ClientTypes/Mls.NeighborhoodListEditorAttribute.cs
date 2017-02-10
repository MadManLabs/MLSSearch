using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MLSSearch3.Mls
{
    public partial class NeighborhoodListEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "MLSSearch3.Mls.NeighborhoodListEditor";

        public NeighborhoodListEditorAttribute()
            : base(Key)
        {
        }
    }
}


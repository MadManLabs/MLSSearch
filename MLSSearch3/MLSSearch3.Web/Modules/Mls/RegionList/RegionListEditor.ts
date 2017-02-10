
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class RegionListEditor extends Common.GridEditorBase<RegionListRow> {
        protected getColumnsKey() { return 'Mls.RegionList'; }
        protected getDialogType() { return RegionListEditorDialog; }
                protected getLocalTextPrefix() { return RegionListRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
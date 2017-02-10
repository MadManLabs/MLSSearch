
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class NeighborhoodListEditor extends Common.GridEditorBase<NeighborhoodListRow> {
        protected getColumnsKey() { return 'Mls.NeighborhoodList'; }
        protected getDialogType() { return NeighborhoodListEditorDialog; }
                protected getLocalTextPrefix() { return NeighborhoodListRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
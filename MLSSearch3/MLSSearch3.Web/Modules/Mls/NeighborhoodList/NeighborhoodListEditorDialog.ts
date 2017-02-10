
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class NeighborhoodListEditorDialog extends Common.GridEditorDialog<NeighborhoodListRow> {
        protected getFormKey() { return NeighborhoodListForm.formKey; }
                protected getLocalTextPrefix() { return NeighborhoodListRow.localTextPrefix; }
        protected getNameProperty() { return NeighborhoodListRow.nameProperty; }
        protected form = new NeighborhoodListForm(this.idPrefix);
    }
}
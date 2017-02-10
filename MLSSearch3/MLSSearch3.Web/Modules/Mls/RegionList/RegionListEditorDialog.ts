
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class RegionListEditorDialog extends Common.GridEditorDialog<RegionListRow> {
        protected getFormKey() { return RegionListForm.formKey; }
                protected getLocalTextPrefix() { return RegionListRow.localTextPrefix; }
        protected getNameProperty() { return RegionListRow.nameProperty; }
        protected form = new RegionListForm(this.idPrefix);
    }
}
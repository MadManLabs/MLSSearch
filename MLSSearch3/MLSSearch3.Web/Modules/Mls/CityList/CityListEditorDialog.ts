
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CityListEditorDialog extends Common.GridEditorDialog<CityListRow> {
        protected getFormKey() { return CityListForm.formKey; }
                protected getLocalTextPrefix() { return CityListRow.localTextPrefix; }
        protected getNameProperty() { return CityListRow.nameProperty; }
        protected form = new CityListForm(this.idPrefix);
    }
}
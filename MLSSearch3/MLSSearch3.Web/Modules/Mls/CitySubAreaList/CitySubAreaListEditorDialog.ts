
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CitySubAreaListEditorDialog extends Common.GridEditorDialog<CitySubAreaListRow> {
        protected getFormKey() { return CitySubAreaListForm.formKey; }
                protected getLocalTextPrefix() { return CitySubAreaListRow.localTextPrefix; }
        protected getNameProperty() { return CitySubAreaListRow.nameProperty; }
        protected form = new CitySubAreaListForm(this.idPrefix);
    }
}
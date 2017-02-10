
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CityDistrictListEditorDialog extends Common.GridEditorDialog<CityDistrictListRow> {
        protected getFormKey() { return CityDistrictListForm.formKey; }
                protected getLocalTextPrefix() { return CityDistrictListRow.localTextPrefix; }
        protected getNameProperty() { return CityDistrictListRow.nameProperty; }
        protected form = new CityDistrictListForm(this.idPrefix);
    }
}
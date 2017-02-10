
/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class SurreyDeltaApartment2016YtdEditorDialog extends Common.GridEditorDialog<SurreyDeltaApartment2016YtdRow> {
        protected getFormKey() { return SurreyDeltaApartment2016YtdForm.formKey; }
                protected getLocalTextPrefix() { return SurreyDeltaApartment2016YtdRow.localTextPrefix; }
        protected getNameProperty() { return SurreyDeltaApartment2016YtdRow.nameProperty; }
        protected form = new SurreyDeltaApartment2016YtdForm(this.idPrefix);
    }
}
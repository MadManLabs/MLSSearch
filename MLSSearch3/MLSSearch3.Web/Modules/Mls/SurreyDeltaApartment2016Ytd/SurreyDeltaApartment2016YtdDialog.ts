
namespace MLSSearch3.Mls {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class SurreyDeltaApartment2016YtdDialog extends Serenity.EntityDialog<SurreyDeltaApartment2016YtdRow, any> {
        protected getFormKey() { return SurreyDeltaApartment2016YtdForm.formKey; }
        protected getIdProperty() { return SurreyDeltaApartment2016YtdRow.idProperty; }
        protected getLocalTextPrefix() { return SurreyDeltaApartment2016YtdRow.localTextPrefix; }
        protected getNameProperty() { return SurreyDeltaApartment2016YtdRow.nameProperty; }
        protected getService() { return SurreyDeltaApartment2016YtdService.baseUrl; }

        protected form = new SurreyDeltaApartment2016YtdForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}
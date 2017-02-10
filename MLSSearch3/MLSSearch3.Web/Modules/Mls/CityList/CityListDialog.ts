
namespace MLSSearch3.Mls {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class CityListDialog extends Serenity.EntityDialog<CityListRow, any> {
        protected getFormKey() { return CityListForm.formKey; }
        protected getIdProperty() { return CityListRow.idProperty; }
        protected getLocalTextPrefix() { return CityListRow.localTextPrefix; }
        protected getNameProperty() { return CityListRow.nameProperty; }
        protected getService() { return CityListService.baseUrl; }

        protected form = new CityListForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}
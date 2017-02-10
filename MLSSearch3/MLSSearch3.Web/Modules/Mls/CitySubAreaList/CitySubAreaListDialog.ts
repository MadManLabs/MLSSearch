
namespace MLSSearch3.Mls {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class CitySubAreaListDialog extends Serenity.EntityDialog<CitySubAreaListRow, any> {
        protected getFormKey() { return CitySubAreaListForm.formKey; }
        protected getIdProperty() { return CitySubAreaListRow.idProperty; }
        protected getLocalTextPrefix() { return CitySubAreaListRow.localTextPrefix; }
        protected getNameProperty() { return CitySubAreaListRow.nameProperty; }
        protected getService() { return CitySubAreaListService.baseUrl; }

        protected form = new CitySubAreaListForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}
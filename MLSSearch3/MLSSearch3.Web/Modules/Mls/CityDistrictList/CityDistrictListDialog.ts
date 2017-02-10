
namespace MLSSearch3.Mls {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class CityDistrictListDialog extends Serenity.EntityDialog<CityDistrictListRow, any> {
        protected getFormKey() { return CityDistrictListForm.formKey; }
        protected getIdProperty() { return CityDistrictListRow.idProperty; }
        protected getLocalTextPrefix() { return CityDistrictListRow.localTextPrefix; }
        protected getNameProperty() { return CityDistrictListRow.nameProperty; }
        protected getService() { return CityDistrictListService.baseUrl; }

        protected form = new CityDistrictListForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}
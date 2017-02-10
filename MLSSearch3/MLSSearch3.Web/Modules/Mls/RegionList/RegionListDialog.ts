
namespace MLSSearch3.Mls {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class RegionListDialog extends Serenity.EntityDialog<RegionListRow, any> {
        protected getFormKey() { return RegionListForm.formKey; }
        protected getIdProperty() { return RegionListRow.idProperty; }
        protected getLocalTextPrefix() { return RegionListRow.localTextPrefix; }
        protected getNameProperty() { return RegionListRow.nameProperty; }
        protected getService() { return RegionListService.baseUrl; }

        protected form = new RegionListForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}
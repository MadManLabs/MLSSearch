
namespace MLSSearch3.Mls {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.maximizable()
    export class NeighborhoodListDialog extends Serenity.EntityDialog<NeighborhoodListRow, any> {
        protected getFormKey() { return NeighborhoodListForm.formKey; }
        protected getIdProperty() { return NeighborhoodListRow.idProperty; }
        protected getLocalTextPrefix() { return NeighborhoodListRow.localTextPrefix; }
        protected getNameProperty() { return NeighborhoodListRow.nameProperty; }
        protected getService() { return NeighborhoodListService.baseUrl; }

        protected form = new NeighborhoodListForm(this.idPrefix);

        dialogOpen() {
                    super.dialogOpen();
                   this.element.closest(".ui-dialog").find(".ui-icon-maximize-window").click();
                 }
    }
}
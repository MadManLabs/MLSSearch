
namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class NeighborhoodListGrid extends Serenity.EntityGrid<NeighborhoodListRow, any> {
        protected getColumnsKey() { return 'Mls.NeighborhoodList'; }
        protected getDialogType() { return NeighborhoodListDialog; }
        protected getIdProperty() { return NeighborhoodListRow.idProperty; }
        protected getLocalTextPrefix() { return NeighborhoodListRow.localTextPrefix; }
        protected getService() { return NeighborhoodListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
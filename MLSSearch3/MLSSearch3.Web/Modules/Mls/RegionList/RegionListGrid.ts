
namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class RegionListGrid extends Serenity.EntityGrid<RegionListRow, any> {
        protected getColumnsKey() { return 'Mls.RegionList'; }
        protected getDialogType() { return RegionListDialog; }
        protected getIdProperty() { return RegionListRow.idProperty; }
        protected getLocalTextPrefix() { return RegionListRow.localTextPrefix; }
        protected getService() { return RegionListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class CityListGrid extends Serenity.EntityGrid<CityListRow, any> {
        protected getColumnsKey() { return 'Mls.CityList'; }
        protected getDialogType() { return CityListDialog; }
        protected getIdProperty() { return CityListRow.idProperty; }
        protected getLocalTextPrefix() { return CityListRow.localTextPrefix; }
        protected getService() { return CityListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
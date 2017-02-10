
namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class CitySubAreaListGrid extends Serenity.EntityGrid<CitySubAreaListRow, any> {
        protected getColumnsKey() { return 'Mls.CitySubAreaList'; }
        protected getDialogType() { return CitySubAreaListDialog; }
        protected getIdProperty() { return CitySubAreaListRow.idProperty; }
        protected getLocalTextPrefix() { return CitySubAreaListRow.localTextPrefix; }
        protected getService() { return CitySubAreaListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
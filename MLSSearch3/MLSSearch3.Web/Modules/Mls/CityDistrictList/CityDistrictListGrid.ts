
namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class CityDistrictListGrid extends Serenity.EntityGrid<CityDistrictListRow, any> {
        protected getColumnsKey() { return 'Mls.CityDistrictList'; }
        protected getDialogType() { return CityDistrictListDialog; }
        protected getIdProperty() { return CityDistrictListRow.idProperty; }
        protected getLocalTextPrefix() { return CityDistrictListRow.localTextPrefix; }
        protected getService() { return CityDistrictListService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
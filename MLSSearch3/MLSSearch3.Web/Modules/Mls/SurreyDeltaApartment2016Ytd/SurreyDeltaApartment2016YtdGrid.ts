
namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class SurreyDeltaApartment2016YtdGrid extends Serenity.EntityGrid<SurreyDeltaApartment2016YtdRow, any> {
        protected getColumnsKey() { return 'Mls.SurreyDeltaApartment2016Ytd'; }
        protected getDialogType() { return SurreyDeltaApartment2016YtdDialog; }
        protected getIdProperty() { return SurreyDeltaApartment2016YtdRow.idProperty; }
        protected getLocalTextPrefix() { return SurreyDeltaApartment2016YtdRow.localTextPrefix; }
        protected getService() { return SurreyDeltaApartment2016YtdService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields():
            Serenity.QuickSearchField[] {
            let fld = SurreyDeltaApartment2016YtdRow.Fields;
            return [
                { name: "", title: "all" },
                { name: fld.Address, title: "Address" },
                { name: fld.MlNo, title: "MLS#" },
                { name: fld.City, title: "City" }
            ];
        }
    }
}
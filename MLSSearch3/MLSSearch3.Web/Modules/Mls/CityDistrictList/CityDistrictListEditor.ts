
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class CityDistrictListEditor extends Common.GridEditorBase<CityDistrictListRow> {
        protected getColumnsKey() { return 'Mls.CityDistrictList'; }
        protected getDialogType() { return CityDistrictListEditorDialog; }
                protected getLocalTextPrefix() { return CityDistrictListRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
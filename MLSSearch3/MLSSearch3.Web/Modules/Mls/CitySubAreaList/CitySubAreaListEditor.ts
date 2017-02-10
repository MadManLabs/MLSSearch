
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class CitySubAreaListEditor extends Common.GridEditorBase<CitySubAreaListRow> {
        protected getColumnsKey() { return 'Mls.CitySubAreaList'; }
        protected getDialogType() { return CitySubAreaListEditorDialog; }
                protected getLocalTextPrefix() { return CitySubAreaListRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
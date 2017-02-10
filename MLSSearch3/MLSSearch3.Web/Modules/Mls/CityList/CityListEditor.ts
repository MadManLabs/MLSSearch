
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class CityListEditor extends Common.GridEditorBase<CityListRow> {
        protected getColumnsKey() { return 'Mls.CityList'; }
        protected getDialogType() { return CityListEditorDialog; }
                protected getLocalTextPrefix() { return CityListRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
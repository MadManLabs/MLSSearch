
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace MLSSearch3.Mls {
    
    @Serenity.Decorators.registerClass()
    export class SurreyDeltaApartment2016YtdEditor extends Common.GridEditorBase<SurreyDeltaApartment2016YtdRow> {
        protected getColumnsKey() { return 'Mls.SurreyDeltaApartment2016Ytd'; }
        protected getDialogType() { return SurreyDeltaApartment2016YtdEditorDialog; }
                protected getLocalTextPrefix() { return SurreyDeltaApartment2016YtdRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
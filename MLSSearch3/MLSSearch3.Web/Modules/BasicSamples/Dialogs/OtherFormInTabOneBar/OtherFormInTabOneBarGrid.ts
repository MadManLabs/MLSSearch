﻿/// <reference path="../../../Northwind/Order/OrderGrid.ts" />

namespace MLSSearch3.BasicSamples {

    /**
     * Subclass of OrderGrid to override dialog type to OtherFormInTabOneBarDialog
     */
    @Serenity.Decorators.registerClass()
    export class OtherFormInTabOneBarGrid extends Northwind.OrderGrid {

        protected getDialogType() { return OtherFormInTabOneBarDialog; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
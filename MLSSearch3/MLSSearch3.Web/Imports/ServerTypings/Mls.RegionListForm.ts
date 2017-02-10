namespace MLSSearch3.Mls {
    export class RegionListForm extends Serenity.PrefixedContext {
        static formKey = 'Mls.RegionList';

    }

    export interface RegionListForm {
        RegionCode: Serenity.StringEditor;
        RegionName: Serenity.StringEditor;
    }

    [['RegionCode', () => Serenity.StringEditor], ['RegionName', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(RegionListForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}


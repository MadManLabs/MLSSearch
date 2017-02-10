namespace MLSSearch3.Mls {
    export class CityListForm extends Serenity.PrefixedContext {
        static formKey = 'Mls.CityList';

    }

    export interface CityListForm {
        CityCode: Serenity.StringEditor;
        CityName: Serenity.StringEditor;
        RegionId: Serenity.LookupEditor;
    }

    [['CityCode', () => Serenity.StringEditor], ['CityName', () => Serenity.StringEditor], ['RegionId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(CityListForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}


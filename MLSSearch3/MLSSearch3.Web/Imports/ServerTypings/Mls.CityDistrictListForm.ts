namespace MLSSearch3.Mls {
    export class CityDistrictListForm extends Serenity.PrefixedContext {
        static formKey = 'Mls.CityDistrictList';

    }

    export interface CityDistrictListForm {
        CityCode: Serenity.StringEditor;
        DistrictName: Serenity.StringEditor;
        CityId: Serenity.LookupEditor;
    }

    [['CityCode', () => Serenity.StringEditor], ['DistrictName', () => Serenity.StringEditor], ['CityId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(CityDistrictListForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}


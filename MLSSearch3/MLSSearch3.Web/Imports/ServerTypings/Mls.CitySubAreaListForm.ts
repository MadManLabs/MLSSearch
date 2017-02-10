namespace MLSSearch3.Mls {
    export class CitySubAreaListForm extends Serenity.PrefixedContext {
        static formKey = 'Mls.CitySubAreaList';

    }

    export interface CitySubAreaListForm {
        SubAreaCode: Serenity.StringEditor;
        SubAreaName: Serenity.StringEditor;
        DistrictId: Serenity.LookupEditor;
    }

    [['SubAreaCode', () => Serenity.StringEditor], ['SubAreaName', () => Serenity.StringEditor], ['DistrictId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(CitySubAreaListForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}


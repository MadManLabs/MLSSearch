namespace MLSSearch3.Mls {
    export class NeighborhoodListForm extends Serenity.PrefixedContext {
        static formKey = 'Mls.NeighborhoodList';

    }

    export interface NeighborhoodListForm {
        NeighborhoodCode: Serenity.StringEditor;
        NeighborhoodName: Serenity.StringEditor;
        SubAreaCode: Serenity.StringEditor;
        SubAreaId: Serenity.LookupEditor;
    }

    [['NeighborhoodCode', () => Serenity.StringEditor], ['NeighborhoodName', () => Serenity.StringEditor], ['SubAreaCode', () => Serenity.StringEditor], ['SubAreaId', () => Serenity.LookupEditor]].forEach(x => Object.defineProperty(NeighborhoodListForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}


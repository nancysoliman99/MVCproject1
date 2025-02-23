import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface categoryForm {
    Name: StringEditor;
    Description: StringEditor;
    Photo: StringEditor;
}

export class categoryForm extends PrefixedContext {
    static readonly formKey = 'ecommercecom.category';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!categoryForm.init)  {
            categoryForm.init = true;

            var w0 = StringEditor;

            initFormType(categoryForm, [
                'Name', w0,
                'Description', w0,
                'Photo', w0
            ]);
        }
    }
}
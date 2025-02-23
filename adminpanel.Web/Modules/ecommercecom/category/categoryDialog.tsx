import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { categoryForm, categoryRow, categoryService } from '../../ServerTypes/ecommercecom';

@Decorators.registerClass('adminpanel.ecommercecom.categoryDialog')
export class categoryDialog extends EntityDialog<categoryRow, any> {
    protected getFormKey() { return categoryForm.formKey; }
    protected getRowDefinition() { return categoryRow; }
    protected getService() { return categoryService.baseUrl; }

    protected form = new categoryForm(this.idPrefix);
}
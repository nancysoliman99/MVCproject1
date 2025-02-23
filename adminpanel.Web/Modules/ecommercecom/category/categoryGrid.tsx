import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { categoryColumns, categoryRow, categoryService } from '../../ServerTypes/ecommercecom';
import { categoryDialog } from './categoryDialog';

@Decorators.registerClass('adminpanel.ecommercecom.categoryGrid')
export class categoryGrid extends EntityGrid<categoryRow> {
    protected getColumnsKey() { return categoryColumns.columnsKey; }
    protected getDialogType() { return categoryDialog; }
    protected getRowDefinition() { return categoryRow; }
    protected getService() { return categoryService.baseUrl; }
}
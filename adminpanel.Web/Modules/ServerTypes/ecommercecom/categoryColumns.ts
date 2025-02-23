import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { categoryRow } from "./categoryRow";

export interface categoryColumns {
    Id: Column<categoryRow>;
    Name: Column<categoryRow>;
    Description: Column<categoryRow>;
    Photo: Column<categoryRow>;
}

export class categoryColumns extends ColumnsBase<categoryRow> {
    static readonly columnsKey = 'ecommercecom.category';
    static readonly Fields = fieldsProxy<categoryColumns>();
}
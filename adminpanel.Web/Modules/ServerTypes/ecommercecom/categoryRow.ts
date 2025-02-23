import { fieldsProxy } from "@serenity-is/corelib";

export interface categoryRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Photo?: string;
}

export abstract class categoryRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'ecommercecom.category';
    static readonly deletePermission = 'category';
    static readonly insertPermission = 'category';
    static readonly readPermission = 'category';
    static readonly updatePermission = 'category';

    static readonly Fields = fieldsProxy<categoryRow>();
}
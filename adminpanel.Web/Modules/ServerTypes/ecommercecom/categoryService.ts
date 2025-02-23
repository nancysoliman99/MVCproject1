import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { categoryRow } from "./categoryRow";

export namespace categoryService {
    export const baseUrl = 'ecommercecom/category';

    export declare function Create(request: SaveRequest<categoryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<categoryRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<categoryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<categoryRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<categoryRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<categoryRow>>;

    export const Methods = {
        Create: "ecommercecom/category/Create",
        Update: "ecommercecom/category/Update",
        Delete: "ecommercecom/category/Delete",
        Retrieve: "ecommercecom/category/Retrieve",
        List: "ecommercecom/category/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>categoryService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}
using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<adminpanel.ecommercecom.categoryRow>;
using MyRow = adminpanel.ecommercecom.categoryRow;

namespace adminpanel.ecommercecom;

public interface IcategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class categoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryListHandler
{
    public categoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}
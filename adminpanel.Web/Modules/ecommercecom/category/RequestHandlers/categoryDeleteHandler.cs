using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = adminpanel.ecommercecom.categoryRow;

namespace adminpanel.ecommercecom;

public interface IcategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class categoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryDeleteHandler
{
    public categoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}
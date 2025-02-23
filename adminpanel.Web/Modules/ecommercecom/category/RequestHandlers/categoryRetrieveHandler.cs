using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<adminpanel.ecommercecom.categoryRow>;
using MyRow = adminpanel.ecommercecom.categoryRow;

namespace adminpanel.ecommercecom;

public interface IcategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class categoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IcategoryRetrieveHandler
{
    public categoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<adminpanel.ecommercecom.categoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = adminpanel.ecommercecom.categoryRow;

namespace adminpanel.ecommercecom;

public interface IcategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class categorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IcategorySaveHandler
{
    public categorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}
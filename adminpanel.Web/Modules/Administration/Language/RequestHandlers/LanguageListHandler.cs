using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<adminpanel.Administration.LanguageRow>;
using MyRow = adminpanel.Administration.LanguageRow;


namespace adminpanel.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}
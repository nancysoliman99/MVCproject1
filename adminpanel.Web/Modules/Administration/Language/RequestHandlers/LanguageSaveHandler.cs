using MyRequest = Serenity.Services.SaveRequest<adminpanel.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = adminpanel.Administration.LanguageRow;


namespace adminpanel.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}
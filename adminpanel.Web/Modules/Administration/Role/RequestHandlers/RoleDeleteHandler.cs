using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = adminpanel.Administration.RoleRow;


namespace adminpanel.Administration;
public interface IRoleDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }
public class RoleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRoleDeleteHandler
{
    public RoleDeleteHandler(IRequestContext context)
         : base(context)
    {
    }
}
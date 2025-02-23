using MyRequest = adminpanel.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<adminpanel.Administration.UserRow>;
using MyRow = adminpanel.Administration.UserRow;

namespace adminpanel.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}
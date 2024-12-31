using NetCoreSampleService.Infrastructure;

namespace NetCoreSampleService.APIs;

public class UsersService : UsersServiceBase
{
    public UsersService(NetCoreSampleServiceDbContext context)
        : base(context) { }
}

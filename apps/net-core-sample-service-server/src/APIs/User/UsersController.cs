using Microsoft.AspNetCore.Mvc;

namespace NetCoreSampleService.APIs;

[ApiController()]
public class UsersController : UsersControllerBase
{
    public UsersController(IUsersService service)
        : base(service) { }
}

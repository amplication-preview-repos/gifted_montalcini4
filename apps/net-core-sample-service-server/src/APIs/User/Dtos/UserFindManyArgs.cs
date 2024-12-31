using Microsoft.AspNetCore.Mvc;
using NetCoreSampleService.APIs.Common;
using NetCoreSampleService.Infrastructure.Models;

namespace NetCoreSampleService.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class UserFindManyArgs : FindManyInput<User, UserWhereInput> { }

using Microsoft.EntityFrameworkCore;
using NetCoreSampleService.Infrastructure.Models;

namespace NetCoreSampleService.Infrastructure;

public class NetCoreSampleServiceDbContext : DbContext
{
    public NetCoreSampleServiceDbContext(DbContextOptions<NetCoreSampleServiceDbContext> options)
        : base(options) { }

    public DbSet<UserDbModel> Users { get; set; }
}

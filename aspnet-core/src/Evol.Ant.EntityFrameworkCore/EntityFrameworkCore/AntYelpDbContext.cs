using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Evol.Ant.Authorization.Roles;
using Evol.Ant.Authorization.Users;
using Evol.Ant.MultiTenancy;

namespace Evol.Ant.EntityFrameworkCore
{
    public class AntYelpDbContext : AbpZeroDbContext<Tenant, Role, User, AntYelpDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public AntYelpDbContext(DbContextOptions<AntYelpDbContext> options)
            : base(options)
        {
        }
    }
}

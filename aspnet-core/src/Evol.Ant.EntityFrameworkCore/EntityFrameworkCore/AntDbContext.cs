using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Evol.Ant.Authorization.Roles;
using Evol.Ant.Authorization.Users;
using Evol.Ant.MultiTenancy;

namespace Evol.Ant.EntityFrameworkCore
{
    public class AntDbContext : AbpZeroDbContext<Tenant, Role, User, AntDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AntDbContext(DbContextOptions<AntDbContext> options)
            : base(options)
        {
        }
    }
}

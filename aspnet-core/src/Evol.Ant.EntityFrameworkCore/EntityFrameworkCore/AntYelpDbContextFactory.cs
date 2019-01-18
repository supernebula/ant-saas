using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Evol.Ant.Configuration;
using Evol.Ant.Web;

namespace Evol.Ant.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AntYelpDbContextFactory : IDesignTimeDbContextFactory<AntYelpDbContext>
    {
        public AntYelpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AntYelpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AntDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AntConsts.ConnectionStringName));

            return new AntYelpDbContext(builder.Options);
        }
    }
}

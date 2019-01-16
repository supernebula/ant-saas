using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Evol.Ant.EntityFrameworkCore
{
    public static class AntDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AntDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AntDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QAManagement.EntityFrameworkCore
{
    public class QAManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<QAManagementHttpApiHostMigrationsDbContext>
    {
        public QAManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<QAManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("QAManagement"));

            return new QAManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

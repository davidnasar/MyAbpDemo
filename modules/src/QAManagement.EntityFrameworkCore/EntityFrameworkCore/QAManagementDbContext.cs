using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QAManagement.EntityFrameworkCore
{
    [ConnectionStringName(QAManagementDbProperties.ConnectionStringName)]
    public class QAManagementDbContext : AbpDbContext<QAManagementDbContext>, IQAManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public QAManagementDbContext(DbContextOptions<QAManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureQAManagement();
        }
    }
}
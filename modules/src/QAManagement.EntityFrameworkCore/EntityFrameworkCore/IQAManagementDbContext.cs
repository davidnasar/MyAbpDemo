using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace QAManagement.EntityFrameworkCore
{
    [ConnectionStringName(QAManagementDbProperties.ConnectionStringName)]
    public interface IQAManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}
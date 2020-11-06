using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace QAManagement.MongoDB
{
    [ConnectionStringName(QAManagementDbProperties.ConnectionStringName)]
    public interface IQAManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}

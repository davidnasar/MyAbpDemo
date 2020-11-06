using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace QAManagement.MongoDB
{
    [ConnectionStringName(QAManagementDbProperties.ConnectionStringName)]
    public class QAManagementMongoDbContext : AbpMongoDbContext, IQAManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureQAManagement();
        }
    }
}
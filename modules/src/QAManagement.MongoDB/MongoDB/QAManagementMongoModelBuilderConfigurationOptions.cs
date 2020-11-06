using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace QAManagement.MongoDB
{
    public class QAManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public QAManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}
using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace QAManagement.MongoDB
{
    public static class QAManagementMongoDbContextExtensions
    {
        public static void ConfigureQAManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new QAManagementMongoModelBuilderConfigurationOptions(
                QAManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}
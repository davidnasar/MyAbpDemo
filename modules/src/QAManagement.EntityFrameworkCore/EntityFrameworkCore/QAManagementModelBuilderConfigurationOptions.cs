using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace QAManagement.EntityFrameworkCore
{
    public class QAManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public QAManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}
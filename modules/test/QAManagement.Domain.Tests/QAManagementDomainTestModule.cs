using QAManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace QAManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(QAManagementEntityFrameworkCoreTestModule)
        )]
    public class QAManagementDomainTestModule : AbpModule
    {
        
    }
}

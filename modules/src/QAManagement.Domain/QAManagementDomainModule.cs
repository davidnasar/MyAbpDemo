using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace QAManagement
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(QAManagementDomainSharedModule)
    )]
    public class QAManagementDomainModule : AbpModule
    {

    }
}

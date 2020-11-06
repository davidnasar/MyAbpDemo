using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace QAManagement
{
    [DependsOn(
        typeof(QAManagementDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class QAManagementApplicationContractsModule : AbpModule
    {

    }
}

using Volo.Abp.Modularity;

namespace QAManagement
{
    [DependsOn(
        typeof(QAManagementApplicationModule),
        typeof(QAManagementDomainTestModule)
        )]
    public class QAManagementApplicationTestModule : AbpModule
    {

    }
}

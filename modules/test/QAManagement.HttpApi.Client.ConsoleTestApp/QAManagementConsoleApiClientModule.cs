using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace QAManagement
{
    [DependsOn(
        typeof(QAManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class QAManagementConsoleApiClientModule : AbpModule
    {
        
    }
}

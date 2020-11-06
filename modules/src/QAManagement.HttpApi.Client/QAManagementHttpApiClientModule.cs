using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace QAManagement
{
    [DependsOn(
        typeof(QAManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class QAManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "QAManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(QAManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}

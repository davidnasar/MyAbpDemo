using Localization.Resources.AbpUi;
using QAManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace QAManagement
{
    [DependsOn(
        typeof(QAManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class QAManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(QAManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<QAManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}

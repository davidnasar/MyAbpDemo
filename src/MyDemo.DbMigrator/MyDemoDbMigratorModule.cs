using MyDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MyDemo.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MyDemoEntityFrameworkCoreDbMigrationsModule),
        typeof(MyDemoApplicationContractsModule)
        )]
    public class MyDemoDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

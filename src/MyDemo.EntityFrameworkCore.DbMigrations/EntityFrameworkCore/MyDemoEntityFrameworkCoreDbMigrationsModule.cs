using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MyDemo.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyDemoEntityFrameworkCoreModule)
        )]
    public class MyDemoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MyDemoMigrationsDbContext>();
        }
    }
}

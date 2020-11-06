using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MyDemo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(MyDemoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class MyDemoConsoleApiClientModule : AbpModule
    {
        
    }
}

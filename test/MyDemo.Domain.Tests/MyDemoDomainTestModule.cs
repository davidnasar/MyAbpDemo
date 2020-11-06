using MyDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MyDemo
{
    [DependsOn(
        typeof(MyDemoEntityFrameworkCoreTestModule)
        )]
    public class MyDemoDomainTestModule : AbpModule
    {

    }
}
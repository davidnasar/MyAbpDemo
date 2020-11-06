using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MyDemo.Data
{
    /* This is used if database provider does't define
     * IMyDemoDbSchemaMigrator implementation.
     */
    public class NullMyDemoDbSchemaMigrator : IMyDemoDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
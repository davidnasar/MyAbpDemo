using System.Threading.Tasks;

namespace MyDemo.Data
{
    public interface IMyDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

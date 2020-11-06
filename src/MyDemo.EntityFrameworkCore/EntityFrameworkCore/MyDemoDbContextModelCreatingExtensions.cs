using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace MyDemo.EntityFrameworkCore
{
    public static class MyDemoDbContextModelCreatingExtensions
    {
        public static void ConfigureMyDemo(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(MyDemoConsts.DbTablePrefix + "YourEntities", MyDemoConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
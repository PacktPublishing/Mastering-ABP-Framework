using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace DemoApp.EntityFrameworkCore
{
    public static class DemoAppDbContextModelCreatingExtensions
    {
        public static void ConfigureDemoApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(DemoAppConsts.DbTablePrefix + "YourEntities", DemoAppConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
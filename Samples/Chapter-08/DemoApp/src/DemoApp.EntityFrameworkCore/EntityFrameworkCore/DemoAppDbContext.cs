using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using DemoApp.Users;
using Microsoft.EntityFrameworkCore.Metadata;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;

namespace DemoApp.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See DemoAppMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class DemoAppDbContext : AbpDbContext<DemoAppDbContext>
    {
        protected bool IsArchiveFilterEnabled => DataFilter?.IsEnabled<IArchivable>() ?? false;
        
        public DbSet<AppUser> Users { get; set; }
        
        public DbSet<Order> Orders { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside DemoAppDbContextModelCreatingExtensions.ConfigureDemoApp
         */

        public DemoAppDbContext(DbContextOptions<DemoAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser
                
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the DemoAppEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureDemoApp method */

            builder.ConfigureDemoApp();
        }

        protected override bool ShouldFilterEntity<TEntity>(IMutableEntityType entityType)
        {
            if (typeof(IArchivable).IsAssignableFrom(typeof(TEntity)))
            {
                return true;
            }
            
            return base.ShouldFilterEntity<TEntity>(entityType);
        }
        
        protected override Expression<Func<TEntity, bool>> CreateFilterExpression<TEntity>()
        {
            var expression = base.CreateFilterExpression<TEntity>();

            if (typeof(IArchivable).IsAssignableFrom(typeof(TEntity)))
            {
                Expression<Func<TEntity, bool>> archiveFilter =
                    e => !IsArchiveFilterEnabled || !EF.Property<bool>(e, nameof(IArchivable.IsArchived));
                expression = expression == null 
                    ? archiveFilter 
                    : CombineExpressions(expression, archiveFilter);
            }

            return expression;
        }
    }
}

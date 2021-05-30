using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;

namespace FormsApp
{
    [DependsOn(
        typeof(FormsDomainModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule)
    )]
    public class FormsEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FormsAppDbContext>(options =>
            {
                options.AddDefaultRepositories();
                options.AddRepository<Form, FormRepository>();
            });
            
            Configure<AbpDbContextOptions>(options =>
            {
                options.PreConfigure<FormsAppDbContext>(opts =>
                {
                    opts.DbContextOptions.UseLazyLoadingProxies();
                });
    
                options.UseSqlServer();
            });
            
            Configure<AbpEntityOptions>(options =>
            {
                options.Entity<Form>(orderOptions =>
                {
                    orderOptions.DefaultWithDetailsFunc = query => query
                        .Include(f => f.Questions)
                        .Include(f => f.Managers);
                });
            });
        }
    }
}
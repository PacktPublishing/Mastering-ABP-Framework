using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace FormsApp
{
    [DependsOn(
        typeof(AbpMongoDbModule),
        typeof(FormsDomainModule)
    )]
    public class FormsMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<FormsAppDbContext>(options =>
            {
                options.AddDefaultRepositories();
                options.AddRepository<Form, FormRepository>();
            });
        }
    }
}
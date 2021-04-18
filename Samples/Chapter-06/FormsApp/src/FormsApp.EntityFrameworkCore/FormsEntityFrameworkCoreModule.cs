using FormsApp.Domain;
using Microsoft.Extensions.DependencyInjection;
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
        options.AddDefaultRepositories(includeAllEntities: true);
    });
}
}
}
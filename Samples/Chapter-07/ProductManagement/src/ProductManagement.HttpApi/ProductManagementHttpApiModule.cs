using System.Linq;
using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using ProductManagement.Localization;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace ProductManagement
{
    [DependsOn(
        typeof(ProductManagementApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule),
        typeof(AbpSettingManagementHttpApiModule)
        )]
    public class ProductManagementHttpApiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AuthorizationOptions>(options =>
            {
                options.AddPolicy(
                    "ProductManagement.ProductCreation",
                    policy =>
                    {
                        policy.Requirements.Add(
                            new ProductCreationRequirement()
                        );
                    });
            });

            context.Services.AddSingleton<
                IAuthorizationHandler, 
                ProductCreationRequirementHandler>();
            
            ConfigureLocalization();
        }

        private void ConfigureLocalization()
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ProductManagementResource>()
                    .AddBaseTypes(
                        typeof(AbpUiResource)
                    );
            });
        }
    }
}

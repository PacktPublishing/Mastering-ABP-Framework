using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using ProductManagement.Localization;
using ProductManagement.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace ProductManagement.Web.Menus
{
    public class ProductManagementMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.GetLocalizer<ProductManagementResource>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem(ProductManagementMenus.Home, l["Menu:Home"], "~/"));

            context.Menu.AddItem(
                new ApplicationMenuItem(
                    "ProductManagement",
                    l["Menu:ProductManagement"],
                    icon: "fas fa-shopping-cart"
                ).AddItem(
                    new ApplicationMenuItem(
                        "ProductManagement.Products",
                        l["Menu:Products"],
                        url: "/Products"
                    )
                )
            );
        }
    }
}

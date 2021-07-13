using System.Threading.Tasks;
using Acme.Crm.Localization;
using Volo.Abp.UI.Navigation;

namespace Acme.Crm.Web.Menus
{
    public class CrmMenuContributor : IMenuContributor
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
            var l = context.GetLocalizer<CrmResource>();

            context.Menu.Items.Insert(
                0,
                new ApplicationMenuItem(
                    CrmMenus.Home,
                    l["Menu:Home"],
                    "~/",
                    icon: "fas fa-home",
                    order: 0
                )
            );
        }
    }
}

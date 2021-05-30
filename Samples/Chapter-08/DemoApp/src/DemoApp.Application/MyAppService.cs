using DemoApp.Localization;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DemoApp
{
    public class MyAppService : ApplicationService
    {
        public MyAppService()
        {
            //LocalizationResource = typeof(DemoAppResource); //no need since it is the default resource
        }

        public async Task FooAsync()
        {
            var str = L["WelcomeMessage"];
        }
    }
}
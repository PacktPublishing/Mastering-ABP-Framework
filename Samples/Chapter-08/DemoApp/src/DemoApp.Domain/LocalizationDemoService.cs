using DemoApp.Localization;
using Microsoft.Extensions.Localization;
using Volo.Abp.DependencyInjection;

namespace DemoApp
{
    public class LocalizationDemoService : ITransientDependency
    {
        private readonly IStringLocalizer<DemoAppResource> _localizer;

        public LocalizationDemoService(IStringLocalizer<DemoAppResource> localizer)
        {
            _localizer = localizer;
        }

        public string GetWelcomeMessage()
        {
            return _localizer["WelcomeMessage"];
        }

        public string GetWelcomeMessage(string name)
        {
            return _localizer["WelcomeMessage", name];
        }
    }
}

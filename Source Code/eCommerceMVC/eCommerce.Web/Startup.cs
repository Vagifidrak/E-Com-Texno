using eCommerce.Services;
using eCommerce.Shared.Helpers;
using Microsoft.Owin;
using Owin;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(eCommerce.Web.Startup))]
namespace eCommerce.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ConfigurationsHelper.UpdateConfigurations(ConfigurationsService.Instance.GetAllConfigurations());

            var enabledLanguages = LanguagesService.Instance.GetLanguages(enabledLanguagesOnly: true);
            LanguagesHelper.LoadLanguages(enabledLanguages: enabledLanguages, defaultLanguage: enabledLanguages.FirstOrDefault(x => x.IsDefault));

            LocalizationHelper.LoadResourceLocalizations(LanguagesService.Instance.GetAllLanguageResources());
        }
    }
}

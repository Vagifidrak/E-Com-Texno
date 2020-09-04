using eCommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Shared.Helpers
{
    public static class LanguagesHelper
    {
        /// <summary>
        /// All languages that are marked true for isEnabled property in database.
        /// </summary>
        public static List<Language> EnabledLanguages { get; set; }

        /// <summary>
        /// A language that is marked true for IsDefault property in database.
        /// </summary>
        public static Language DefaultLanguage { get; set; }

        /// <summary>
        /// English Langauge Shortcode used for product detail title sanitization
        /// </summary>
        public static string EnglishLanguageShortCode = "az";

        public static void LoadLanguages(List<Language> enabledLanguages, Language defaultLanguage)
        {
            EnabledLanguages = enabledLanguages;

            DefaultLanguage = defaultLanguage;

            //LocalizationHelper.LoadResourceLocalizations(LanguagesService.Instance.GetAllLanguageResources());
        }

        //public static void LoadLanguages()
        //{
        //    EnabledLanguages = LanguagesService.Instance.GetLanguages(enabledLanguagesOnly: true);

        //    DefaultLanguage = LanguagesService.Instance.GetLanguageByShortCode(ConfigurationsHelper.DefaultLanguage);

        //    //LocalizationHelper.LoadResourceLocalizations(LanguagesService.Instance.GetAllLanguageResources());
        //}
    }
}

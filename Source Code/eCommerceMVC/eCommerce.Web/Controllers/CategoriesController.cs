using eCommerce.Services;
using eCommerce.Shared.Helpers;
using eCommerce.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.Web.Controllers
{
    public class CategoriesController : PublicBaseController
    {
        [OutputCache(Duration = 30, VaryByParam = "lang")]
        public ActionResult CategoriesMenu(string lang)
        {
            CategoriesMenuViewModel model = new CategoriesMenuViewModel();

            var categories = CategoriesService.Instance.GetCategories();

            if(categories != null && categories.Count > 0)
            {
                //remove uncategorized category from categories list.
                categories = categories.Where(x => x.ID != 1).ToList();

                model.CategoryWithChildrens = CategoryHelpers.MakeCategoriesHierarchy(categories);
            }

            return PartialView("_CategoriesMenu", model);
        }
        [OutputCache(Duration = 25, VaryByParam = "lang")]
        public ActionResult CategoriesMenuMobile(string lang)
        {
            CategoriesMenuViewModel model = new CategoriesMenuViewModel();

            var categories = CategoriesService.Instance.GetCategories();

            if (categories != null && categories.Count > 0)
            {
                //remove uncategorized category from categories list.
                categories = categories.Where(x => x.ID != 1).ToList();

                model.CategoryWithChildrens = CategoryHelpers.MakeCategoriesHierarchy(categories);
            }

            return PartialView("_CategoriesMenuMobile", model);
        }
        public ActionResult FeaturedCategories(int recordSize = 8)
        {
            var categories = CategoriesService.Instance.GetFeaturedCategories(recordSize: recordSize);

            return PartialView("_FeaturedCategoriesHomeSection", categories);
        }

        public ActionResult ProductsByFeaturedCategories(int recordSize = 5)
        {
            ProductsByFeaturedCategoriesViewModel model = new ProductsByFeaturedCategoriesViewModel
            {
                Categories = CategoriesService.Instance.GetFeaturedCategories(recordSize: recordSize)
            };

            return PartialView("_ProductsByFeaturedCategories", model);
        }
    }
}
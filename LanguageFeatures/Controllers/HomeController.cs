using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<string> result = new();
            foreach (var item in Product.GetProducts())
            {
                string name = item?.Name ?? "<No Name>";
                decimal? price = item?.Price ?? 0;
                string relatedName = item?.Related?.Name ?? "<None>";
                result.Add(string.Format($"Название: {name}, цена: {price}, связанные: {relatedName}"));
            }
            return View(result);
        }
    }
}

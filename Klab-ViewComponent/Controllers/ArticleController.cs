using Microsoft.AspNetCore.Mvc;

namespace Klab_ViewComponent.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Article/Index.cshtml");
        }
    }
}

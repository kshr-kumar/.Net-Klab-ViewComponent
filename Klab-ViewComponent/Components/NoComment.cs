using Microsoft.AspNetCore.Mvc;

namespace Klab_ViewComponent.Components
{
    public class NoComment:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            List<string> comments = ["kishore", "Kumar"];
            return View("~/Views/Component/_Comment.cshtml",comments);  
        }

    }
}

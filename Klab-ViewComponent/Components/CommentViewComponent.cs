using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.ComponentModel;
using System.Xml.Linq;

namespace Klab_ViewComponent.Components
{
    public class CommentViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            //List<string> Comments = new List<string>() { "Comment1", "Comment2", "Comment3" };  //Older style of writing list
            List<string> comments = ["Comment1", "Comment2", "Comment3"]; //C# 12
            
            return View("~/Views/Component/_Comment.cshtml", comments);
        }
    }
}

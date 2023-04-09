using Microsoft.AspNetCore.Mvc;

namespace Tree.Web.Controllers
{
    public class Tree : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

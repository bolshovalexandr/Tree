using Microsoft.AspNetCore.Mvc;

namespace Tree.Web.Controllers
{
    public class TreeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

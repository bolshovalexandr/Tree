using Microsoft.AspNetCore.Mvc;
using Tree.DAL.Domain.Genre;
using Tree.Logic;

namespace Tree.Web.Controllers
{
    public class TreeController : Controller
    {
        private GenreService _genreService;
        public TreeController(GenreService genreService) { 
            _genreService = genreService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ICollection<Genre> GenresList()
        {
            return _genreService.GenresList();
        }
    }
}

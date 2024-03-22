using Microsoft.AspNetCore.Mvc;
using Zteam.Data;
using Zteam.Models;

namespace Zteam.Controllers
{
    public class libraryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public libraryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Game> game = _db.Game;
            return View(game);
        }
    }
}

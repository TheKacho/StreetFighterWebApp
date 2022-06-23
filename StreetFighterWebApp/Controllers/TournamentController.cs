using Microsoft.AspNetCore.Mvc;

namespace StreetFighterWebApp.Controllers
{
    public class TournamentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

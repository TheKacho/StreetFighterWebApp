using Microsoft.AspNetCore.Mvc;
using StreetFighterWebApp.Data;

namespace StreetFighterWebApp.Controllers
{
    public class ESportGroupController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ESportGroupController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() 
        {
            var esportgroups = _context.EsportGroups.ToList();
            return View(esportgroups);
        }
    }
}

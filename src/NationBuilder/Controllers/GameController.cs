using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NationBuilder.Models;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NationBuilder.Controllers
{
    public class GameController : Controller
    {
        private NationBuilderContext db = new NationBuilderContext();
        private readonly NationBuilderContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public GameController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, NationBuilderContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {
            Nation selectedNation = _db.Nations.LastOrDefault();
            Map selectedMap = _db.Maps.FirstOrDefault(map => map.MapId == selectedNation.NationId);
            ViewBag.SelectedMap = selectedMap;
                
            return View(selectedNation);
        }
        public IActionResult Gamestate()
        {

        }
}

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
            //Nation selectedNation = _db.Nations.LastOrDefault();
            //Map selectedMap = _db.Maps.FirstOrDefault(map => map.MapId == selectedNation.NationId);
            //ViewBag.SelectedMap = selectedMap;

            return View();
        }
        [Route("/Game/MapGamestate")]
        public IActionResult MapGamestate()
        {
            Map selectedMap = _db.Maps.LastOrDefault();
            return Json(selectedMap);

        }
        [Route("/Game/NationGamestate")]
        public IActionResult NationGamestate()
        {
            Nation selectedNation = _db.Nations.LastOrDefault();
            var asd = Json(selectedNation);
            return (asd);
        }
        [Route("/Game/AssignWorkerFood")]
        public IActionResult AssignWorkerFood()
        {
            
        }
        [Route("/Game/RemoveWorkerFood")]
        public IActionResult RemoveWorkerFood()
        {

        }
        [Route("/Game/AssignWorkerResources")]
        public IActionResult AssignWorkerResources()
        {
            Map thisMap = _db.Maps.LastOrDefault();
            Nation thisNation = _db.Nations.LastOrDefault();
            if(thisNation.Workers > 0)
            {
                thisNation.Workers -= 1;
                thisNation.AssignedResourceWorkers += 1;
            }
        
        }
        [Route("/Game/RemoveWorkerResources")]
        public IActionResult RemoveWorkerResources()
        {

        }
        public int GetResouces(int worker)
        {

            return worker;
        }
    }
}

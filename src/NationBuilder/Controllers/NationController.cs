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
    public class NationController : Controller
    {
        private NationBuilderContext db = new NationBuilderContext();
        private readonly NationBuilderContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public NationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, NationBuilderContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {   
            return View();
        }
        //List of Nation
        [Route("/Nation/ListNations")]
        public IActionResult ListNation()
        {
            return View(_db.Nations.ToList());
        }
        //public IActionResult
        [Route("/Nation/Create")]
        public IActionResult Create()
        {
       
            return View();
        }
        [Route("/Nation/CreateNation")]
        [HttpPost]
        public IActionResult Create(string Name, string GovernmentType, string EconomyType, string Geography)
        {
            Nation newNation = new Nation();
            newNation.Name = Name;
            newNation.GovernmentType = GovernmentType;
            newNation.EconomyType = EconomyType;
            newNation.Geography = Geography;
            newNation.MapId = 1; 
            _db.Nations.Add(newNation);
            _db.SaveChanges();
            return RedirectToAction("Index", "Game");
        }
    }
}

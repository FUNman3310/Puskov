using AAdminPanel1.Models;
using AAdminPanel1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AAdminPanel1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AdminContext _adminContext;

        public HomeController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel()
            {
                //Sliders = _adminContext.Sliders..OrderBy(x => x.Order).ToList()
            };
            return View(homeVM);
        }

       
    }
}
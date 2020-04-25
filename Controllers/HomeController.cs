using Project_Bomject1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project_Bomject1.Models;
using Project_Bomject1.Repositories;
using System.Linq;
using Project_Bomject1.ModelBuilders;
using System.Collections.Generic;

namespace Project_Bomject1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IThemeOfTheDayDataRepository themeOfTheDayDataRepository;
        private readonly IThemeModelBuilder themeModelBuilder;
        public HomeController(IThemeOfTheDayDataRepository themeOfTheDayDataRepository, IThemeModelBuilder themeModelBuilder)
        {
            this.themeOfTheDayDataRepository = themeOfTheDayDataRepository;
            this.themeModelBuilder = themeModelBuilder;
        }

        public IActionResult Index()
        {
            return View(themeModelBuilder.GetThemeInfo());
        }

        [HttpGet]
        public IActionResult AddThemeRecord()
        {
       
            return View();
        }

        [HttpPost]
        public IActionResult AddThemeRecord(ThemeOfTheDayModel model)
        {
            themeOfTheDayDataRepository.SaveNewThemeRecord(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditThemeRecord(int id)
        {
            return View(themeOfTheDayDataRepository.FindRecordById(id));
        }

        [HttpPost]
        public IActionResult EditThemeRecord(ThemeOfTheDayModel model)
        {
            
            themeOfTheDayDataRepository.EditThemeRecord(model);
            return RedirectToAction("Index");
        } 
        
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}

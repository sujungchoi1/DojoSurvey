using System;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HelloController: Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("result")]
        public IActionResult Result(string Name, string Location, string Language, string Comment)
        {
            ViewBag.Name = Name;
            ViewBag.Location = Location;
            ViewBag.Language = Language;
            ViewBag.Comment = Comment;
            return View("Result");
            
        }
    }
}
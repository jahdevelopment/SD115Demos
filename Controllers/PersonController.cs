using Microsoft.AspNetCore.Mvc;

namespace SD115Demos.Controllers
{
    public class PersonController : Controller
    {
        private string _name = "Juan Alberto Hernandez";

        public string Name { get { return _name; } }


        public int Number = 1;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Me()
        {
            ViewBag.Name = Name;

            ViewBag.Number = Number;
            
            return View();
        }

    }
}

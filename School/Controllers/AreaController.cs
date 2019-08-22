using Microsoft.AspNetCore.Mvc;

namespace School.Controllers
{
    public class AreaController : Controller
    {
        public IActionResult Index()
        {
            var area = new Models.Area()
            {
                Name = "Computer's science"
            };
            
            return View(area);  
        }
    }
}
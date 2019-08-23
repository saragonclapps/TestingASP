using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class SchoolController : Controller
    {
        private SchoolContext _context;
        public SchoolController(SchoolContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {   
            var school = _context.Schools.FirstOrDefault();
            ViewBag.AnyThingOne = "1- object of bag!!";
            ViewBag.AnyThingTwo = "2-fasdfa object of bag!!";
            
            return View("Index", school);
        }
    }
}
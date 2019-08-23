using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class AreaController : Controller
    {
        private SchoolContext _context;
        public AreaController(SchoolContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var area = _context.Areas.FirstOrDefault();

            return View("Index",area);
        }
        
        public IActionResult MultiArea()
        {
            var areas = _context.Areas;
            
            return View("MultiArea",areas);  
        }
    }
}
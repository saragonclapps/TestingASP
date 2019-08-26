using System;
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
        
        [Route("Area/Index/")]
        [Route("Area/Index/{areaId}")]
        public IActionResult Index(string areaId)
        {
            if (String.IsNullOrEmpty(areaId))
            {
                var areas = _context.Areas;
                return View("MultiArea",areas); 
            }
            
            var area = _context.Areas
                .FirstOrDefault(c => c.Id == areaId);

            return View("Index",area);
        }
 
        
        public IActionResult MultiArea()
        {
            var areas = _context.Areas;
            
            return View("MultiArea",areas);  
        }
    }
}
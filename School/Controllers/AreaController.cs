using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
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
            var area = new Area{
                Name = "Computer's science",
                Id = Guid.NewGuid().ToString()
            };
            
            return View("Index",area);
        }
        
        public IActionResult MultiArea()
        {
            var areas = _context.Areas;
            
            return View("MultiArea",areas);  
        }
    }
}
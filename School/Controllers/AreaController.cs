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
        
        [Route("Area")]
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

        #region Create

        public IActionResult Create()
        {
            ViewBag.Courses = _context.Courses.Select(c => c.Id);
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Area area)
        {
            if (!ModelState.IsValid) return View("Create", area);

            _context.Areas.Add(area);
            _context.SaveChanges();

            ViewBag.Message = "New area is created!!";
            return View("Index", area);  
        }
        
        #endregion Create

        #region Edit

        public IActionResult Edit(string id)
        {
            if (String.IsNullOrEmpty(id)) return View("Error");

            var course = _context.Areas.FirstOrDefault(c => c.Id == id);
            ViewBag.Courses = _context.Courses.Select(c => c.Id);

            return View("Edit", course);
        }

        [HttpPost]
        public IActionResult Edit(Area area)
        {
            if (!ModelState.IsValid) return View("Edit", area);

            _context.Areas.Update(area);
            _context.SaveChanges();

            ViewBag.Message = "Area is edited!!";
            return View("Index", area); 
        }
        
        #endregion Edit
    }
}
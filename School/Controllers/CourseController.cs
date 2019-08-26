using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext _context;
        public CourseController(SchoolContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var course = _context.Courses.FirstOrDefault();

            return View("Index",course);
        }
        
        public IActionResult MultiCourse()
        {
            var courses = _context.Courses;
            
            return View("MultiCourse",courses);  
        }
    }
}
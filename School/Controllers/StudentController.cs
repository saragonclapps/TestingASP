using System.Linq;
using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _context;
        
        public StudentController(SchoolContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var student = _context.Students.FirstOrDefault();

            return View("Index",student);
        }
        
        public IActionResult MultiStudent()
        {
            var listStudents = _context.Students;

            return View("MultiStudent",listStudents);
        }
    }
}
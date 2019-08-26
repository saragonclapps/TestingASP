using System;
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
        
//        public IActionResult Index()
//        {
//            var course = _context.Courses.FirstOrDefault();
//
//            return View("Index",course);
//        }
        
//        public IActionResult Index(string id)
//        {
//            var course = _context.Courses
//                .FirstOrDefault(c => c.Id == id);
//
//            return View("Index",course);
//        }        
        
        [Route("Course")]
        [Route("Course/Index/")]
        [Route("Course/Index/{courseId}")]
        public IActionResult Index(string courseId)
        {
            if (String.IsNullOrEmpty(courseId))
            {
                var courses = _context.Courses;
                return View("MultiCourse",courses);  
            }

            ViewBag.Message = "New course is created!!";
            var course = _context.Courses
                .FirstOrDefault(c => c.Id == courseId);

            return View("Index",course);
        }
        
        public IActionResult MultiCourse()
        {
            var courses = _context.Courses;
            
            return View("MultiCourse",courses);  
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid) return View("Create",course);
            
            var school = _context.Schools.FirstOrDefault();
            course.SchoolId = school.Id;
            _context.Courses.Add(course);
            _context.SaveChanges();
            
            return View("Index", course);
        }
    }
}
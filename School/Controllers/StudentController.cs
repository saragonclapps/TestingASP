using System;
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
        
//        public IActionResult Index(string id)
//        {
//            var student = _context.Students
//                .FirstOrDefault(c => c.Id == id);
//
//            return View("Index",student);
//        }    

        public IActionResult Index(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                var students = _context.Students;
                return View("MultiStudent",students); 
            }
            
            var student = _context.Students
                .FirstOrDefault(c => c.Id == id);

            return View("Index",student);
        }
        
        public IActionResult MultiStudent()
        {
            var listStudents = _context.Students;

            return View("MultiStudent",listStudents);
        }
        
        #region Create

        public IActionResult Create()
        {
            ViewBag.Courses = _context.Courses.Select(c => c.Id);
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid) return View("Create", student);

            _context.Students.Add(student);
            _context.SaveChanges();

            ViewBag.Message = "New student is created!!";
            return View("Index", student);  
        }
        
        #endregion Create

        #region Edit

        public IActionResult Edit(string id)
        {
            if (String.IsNullOrEmpty(id)) return View("Error");

            var student = _context.Students.FirstOrDefault(c => c.Id == id);
            ViewBag.Courses = _context.Courses.Select(c => c.Id);

            return View("Edit", student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid) return View("Edit", student);

            _context.Students.Update(student);
            _context.SaveChanges();

            ViewBag.Message = "Student is edited!!";
            return View("Index", student); 
        }
        
        #endregion Edit
    }
}
using System.Collections.Generic;

namespace School.Models
{
    public class Student : SchoolBase
    {
        public List<Evaluation> Evaluations { get; set; }
        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}
using System.Collections.Generic;

namespace School.Models
{
    public class Area: SchoolBase
    {
        public string CourseId { get; set; }
        public Course Course { get; set; }
        public List<Evaluation> Evaluations { get; set; }
    }
}
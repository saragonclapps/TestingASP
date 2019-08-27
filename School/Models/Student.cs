using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class Student : SchoolBase
    {
        [Required]
        public override string Name { get; set; }
        public List<Evaluation> Evaluations { get; set; }
        [Required]
        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}
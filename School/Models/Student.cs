using System.Collections.Generic;

namespace School.Models
{
    public class Student : SchoolBase
    {
        public List<Evaluation> Evaluations { get; set; } = new List<Evaluation>();
    }
}
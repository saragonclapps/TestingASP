using System;

namespace School.Models
{
    public class Evaluations
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Student Student { get; set; }
        public Area Area  { get; set; }
        public float Nota { get; set; }

        public Evaluations() => Id = Guid.NewGuid().ToString();
    }
}
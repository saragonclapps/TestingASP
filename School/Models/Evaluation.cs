namespace School.Models
{
    public class Evaluation : SchoolBase
    {
        public Student Student { get; set; }
        public Area Area { get; set; }
        public float Note { get; set; }

        public override string ToString()
        {
            return $"{Note}, {Student.Name}, {Area.Name}";
        }
    }
}
namespace Lab11C.Models
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public IList<Enrollment> Enrollments { get; set; }
    }
}


namespace Lab11C.Models
{
    public class Grade
    {
        public Grade()
        {
            Students = new List<Student>();
        }
        public int GradeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<Student> Students { get; set; }
    }
}
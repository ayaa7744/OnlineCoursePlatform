namespace OnlineCoursePlatform.Models
{
    public class Instructor
    {
        public int Id { get; set; }  
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; } 
}

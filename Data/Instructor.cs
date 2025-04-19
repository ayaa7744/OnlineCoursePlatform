namespace OnlineCoursePlatform.Models
{
    public class Instructor
    {
        public int Id { get; set; }  // المفتاح الأساسي
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; }  // مدرس ممكن يدرس أكتر من كورس
    }
}

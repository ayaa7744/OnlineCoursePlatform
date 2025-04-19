namespace OnlineCoursePlatform.Models
{
    public class Student
    {
        public int Id { get; set; }  // المفتاح الأساسي
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Course> Courses { get; set; } // علاقات مع الكورسات (ممكن يكون طالب في أكتر من كورس)
    }
}

using SchoolProject.Models;

namespace SchoolProject.ViewModels
{
    public class RegisterViewModel
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public IEnumerable<Student>? Students { get; set; }
        public IEnumerable<Course>? Courses { get; set; }
    }
}

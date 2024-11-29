using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        [Range(0, 25)]
        public int CourseCapacity { get; set; }

    }
}

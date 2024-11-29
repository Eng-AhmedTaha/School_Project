using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [MaxLength(60)]
        [Required]
        [MinLength(10)]
        public String  Name { get; set; }
        [Required]
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}

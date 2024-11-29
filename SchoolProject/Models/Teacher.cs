using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        [MaxLength(60)]
        [Required]
        [MinLength(10)]
        public String Name { get; set; }
        [Required]
        [Range(22,70)]
        public int Age { get; set; }

      

    }
}

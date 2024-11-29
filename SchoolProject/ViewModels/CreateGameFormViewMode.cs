using System.ComponentModel.DataAnnotations;

namespace SchoolProject.ViewModels
{
    public class CreateGameFormViewMode
    {
        public int StudentId { get; set; }
        [MaxLength(60)]
        [Required]
        [MinLength(10)]
        public String Name { get; set; }
        [Required]
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}

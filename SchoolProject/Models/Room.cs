using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Room
    {
        public int Id { get; set; }
        [MaxLength(60)]
        [Required]
        [MinLength(10)]
        public String Name { get; set; }
   
    }
}

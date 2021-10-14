using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Avatar { get; set; }
    }
}

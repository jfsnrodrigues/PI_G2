using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Models
{
    public class User
    {
        [Display(Name = "ID")]
        public int UserId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Avatar")]
        public string Avatar { get; set; }
    }
}

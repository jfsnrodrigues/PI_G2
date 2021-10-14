using JRod_Application.Enums;
using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }

        [Required]
        public JRodTasksStatus Status { get; set; }
    }
}

using JRod_Application.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace JRod_Application.Data.DataModels
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public JRodTasksStatus Status { get; set; }
    }
}

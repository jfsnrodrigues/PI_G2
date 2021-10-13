using JRod_Application.Enums;

namespace JRod_Application.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public User User { get; set; }

        public JRodTasksStatus Status { get; set; }
    }
}

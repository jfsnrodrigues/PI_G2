using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Enums
{
    public enum JRodTasksStatus
    {
        [Display(Name = "Em espera")]
        Upcoming = 1,

        [Display(Name = "Em andamento")]
        InProgress,

        [Display(Name = "Bloqueada")]
        Blocked,

        [Display(Name = "Finalizada")]
        Completed
    }
}

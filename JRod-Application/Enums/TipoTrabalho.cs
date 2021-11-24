using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Enums
{
    public enum TipoTrabalho
    {
        [Display(Name = "Presencial")]
        Presencial = 1,

        [Display(Name = "Remoto")]
        Remoto
    }
}

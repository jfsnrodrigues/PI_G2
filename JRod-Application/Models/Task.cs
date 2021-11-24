using JRod_Application.Enums;
using System;
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

        public DateTime? DataInicio { get; set; }

        public string Protocolo { get; set; }
        public int Quantidade { get; set; }

        public string Interessado { get; set; }

        public string CreaspReg { get; set; }

        public string ProvidenciasAdotadas { get; set; }

        public DateTime? DataFim { get; set; }

        public TipoAtividade TipoAtividade { get; set; }

        public TipoTrabalho TipoTrabalho { get; set; }

        public Assunto Assunto { get; set; }

        public TipoServico TipoServico { get; set; }

        public Camara Camara { get; set; }
    }
}

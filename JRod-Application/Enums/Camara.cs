using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Enums
{
    public enum Camara
    {
        [Display(Name = "Nenhuma")]
        Nenhuma,
        [Display(Name = "Civil (CEEC)")]
        CivilCEEC,
        [Display(Name = "Elétrica (CEEE)")]
        EletricaCEEE,
        [Display(Name = "Mecânica (CEEMM)")]
        MecanicaCEEMM,
        [Display(Name = "Agronomia (CEA)")]
        AgronomiaCEA,
        [Display(Name = "Agrimensura (CEEA)")]
        AgrimensuraCEEA,
        [Display(Name = "Química (CEEQ)")]
        QuimicaCEEQ,
        [Display(Name = "Geologia e Minas (CAGE)")]
        GeologiaMinasCAGE,
        [Display(Name = "Segurança (CEEST)")]
        SegurancaCEEST,
        [Display(Name = "Diversas")]
        Diversas
    }
}

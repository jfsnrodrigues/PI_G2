using System.ComponentModel;

namespace JRod_Application.Enums
{
    public enum Camara
    {
        [Description("Nenhuma")]
        Nenhuma,
        [Description("Civil (CEEC)")]
        CivilCEEC,
        [Description("Elétrica (CEEE)")]
        EletricaCEEE,
        [Description("Mecânica (CEEMM)")]
        MecanicaCEEMM,
        [Description("Agronomia (CEA)")]
        AgronomiaCEA,
        [Description("Agrimensura (CEEA)")]
        AgrimensuraCEEA,
        [Description("Química (CEEQ)")]
        QuimicaCEEQ,
        [Description("Geologia e Minas (CAGE)")]
        GeologiaMinasCAGE,
        [Description("Segurança (CEEST)")]
        SegurancaCEEST,
        [Description("Diversas")]
        Diversas
    }
}

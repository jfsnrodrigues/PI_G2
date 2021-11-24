using System.ComponentModel;

namespace JRod_Application.Enums
{
    public enum Assunto
    {
        [Description("Acervo Analise Emissao")]
        AcervoAnaliseEmissao = 1,
        [Description("Acervo Despacho Gestor")]
        AcervoDespachoGestor,
        [Description("ART")]
        ART,
        [Description("Denuncia")]
        Denuncia,
        [Description("Empresa")]
        Empresa,
        [Description("Entidade")]
        Entidade,
        [Description("Financeiro")]
        Financeiro,
        [Description("Fiscalização")]
        Fiscalizacao,
        [Description("Escola")]
        Escola,
        [Description("Profissional")]
        Profissional,
        [Description("Outro")]
        Outro,
    }
}

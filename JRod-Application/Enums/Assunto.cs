using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Enums
{
    public enum Assunto
    {
        [Display(Name = "Acervo Analise Emissao")]
        AcervoAnaliseEmissao = 1,
        [Display(Name = "Acervo Despacho Gestor")]
        AcervoDespachoGestor,
        [Display(Name = "ART")]
        ART,
        [Display(Name = "Denuncia")]
        Denuncia,
        [Display(Name = "Empresa")]
        Empresa,
        [Display(Name = "Entidade")]
        Entidade,
        [Display(Name = "Financeiro")]
        Financeiro,
        [Display(Name = "Fiscalização")]
        Fiscalizacao,
        [Display(Name = "Escola")]
        Escola,
        [Display(Name = "Profissional")]
        Profissional,
        [Display(Name = "Outro")]
        Outro,
    }
}

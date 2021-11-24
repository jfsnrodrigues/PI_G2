using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Enums
{
    public enum TipoServico
    {
        [Display(Name = "CAT c/ Reg. Atestado - Ativ Concluída")]
        CatComRegAtestadoAtivConcluida = 1,
        [Display(Name = "CAT c/ Reg. Atestado - Ativ Andamento")]
        CatComRegAtestadoAtivAndamento,
        [Display(Name = "CAT c/ Reg. Atestado - Complementar")]
        CatComRegAtestadoComplementar,
        [Display(Name = "CAT sem Registro de Atestado")]
        CatSemRegistroAtestado,
        [Display(Name = "2ª via de CAT")]
        SegundaViaCat,
        [Display(Name = "Substituição de CAT c/ Novo Atestado")]
        SubstituicaoCatComNovoAtestado,
        [Display(Name = "Certidão")]
        Certidao,
        [Display(Name = "Consulta")]
        Consulta,
        [Display(Name = "Elaboração de Ofício")]
        ElaboracaoOficio,
        [Display(Name = "Elaboração de Memorando")]
        ElaboracaoMemorando,
        [Display(Name = "Regularização de ART")]
        RegularizacaoArt,
        [Display(Name = "Baixa ART - Rescisão Contratual")]
        BaixaArtRescisaoContratual,
        [Display(Name = "Baixa ART - Interrupção de Reg. do RT")]
        BaixaArtInterrupcaoRegRt,
        [Display(Name = "Baixa ART - Baixa de Cargo/Função")]
        BaixaArtBaixaCargoFuncao,
        [Display(Name = "Baixa ART - Paralisação de Obra/Serviço")]
        BaixaArtParalisacaoObraServico,
        [Display(Name = "Baixa ART - Substituição de RT")]
        BaixaArtSubstituicaoRt,
        [Display(Name = "Baixa ART - Reg. da Empresa Cancelado")]
        BaixaArtRegEmpresaCancelado,
        [Display(Name = "Canc. ART - Contrato não executado")]
        CancArtContratoNaoExecutado,
        [Display(Name = "Canc. ART - Ativ. Téc. não executada")]
        CancArtAtivTecNaoExecutada,
        [Display(Name = "Apuração de Denúncia")]
        ApuracaoDenuncia,
        [Display(Name = "Abertura de Processo")]
        AberturaProcesso,
        [Display(Name = "Registro Novo")]
        RegistroNovo,
        [Display(Name = "Alteração de Contrato Social/Estatuto")]
        AlteracaoContratoSocialEstatuto,
        [Display(Name = "Indicação de RT")]
        IndicacaoRt,
        [Display(Name = "Renovação de RT")]
        RenovacaoRt,
        [Display(Name = "Baixa de RT")]
        BaixaRt,
        [Display(Name = "Cancelamento com comprovação")]
        CancelamentoComComprovacao,
        [Display(Name = "Cancelamento sem comprovação")]
        CancelamentoSemComprovacao,
        [Display(Name = "Visto em Registro")]
        VistoEmRegistro,
        [Display(Name = "Reabilitação de Registro")]
        ReabilitacaoRegistro,
        [Display(Name = "Boleto de Anuidade(s)")]
        BoletoAnuidade,
        [Display(Name = "Parcelamento de Anuidade(s)")]
        ParcelamentoAnuidade,
        [Display(Name = "Documentos de Atualização")]
        DocumentosAtualizacao,
        [Display(Name = "Prestação de Contas")]
        PrestacaoContas,
        [Display(Name = "Solicitações diversas")]
        SolicitacoesDiversas,
        [Display(Name = "Desconto - Recém Formado")]
        DescontoRecemFormado,
        [Display(Name = "Desconto - Tempo de Registro")]
        DescontoTempoRegistro,
        [Display(Name = "Desconto - Portador de Doença Grave")]
        DescontoPortadorDoencaGrave,
        [Display(Name = "Reemb. Anuidade - Pgto a maior")]
        ReembAnuidadePgtoMaior,
        [Display(Name = "Reemb. Anuidade - Duplicidade")]
        ReembAnuidadeDuplicidade,
        [Display(Name = "Reemb. ART - Obra/serviço não exec.")]
        ReembArtObraServiçoNaoExec,
        [Display(Name = "Reemb. ART - Pgto a maior")]
        ReembArtPgtoMaior,
        [Display(Name = "Reemb. ART - Duplicidade")]
        ReembArtDuplicidade,
        [Display(Name = "Reemb. Taxa - Pgto a maior")]
        ReembTaxaPgtoMaior,
        [Display(Name = "Reemb. Taxa - Duplicidade")]
        ReembTaxaDuplicidade,
        [Display(Name = "Reemb. Taxa - Serviço não prestado")]
        ReembTaxaServicoNaoPrestado,
        [Display(Name = "Cadastramento Escola")]
        CadastramentoEscola,
        [Display(Name = "Cadastramento Curso")]
        CadastramentoCurso,
        [Display(Name = "Envio de documentos")]
        EnvioDocumentos,
        [Display(Name = "Registro com Atestado")]
        RegistroComAtestado,
        [Display(Name = "Registro com Diploma")]
        RegistroComDiploma,
        [Display(Name = "Efetivação de Registro")]
        EfetivacaoRegistro,
        [Display(Name = "Anotação em Registro")]
        AnotacaoRegistro,
        [Display(Name = "2ª via de Carteira")]
        SegundaViaCarteira,
        [Display(Name = "Prorrogação de Registro Provisório")]
        ProrrogacaoRegistroProvisorio,
        [Display(Name = "Recadastramento")]
        Recadastramento,
        [Display(Name = "Interrupção de Registro")]
        InterrupcaoRegistro,
        [Display(Name = "Recurso de Interrupção de Registro")]
        RecursoInterrupcaoRegistro,
        [Display(Name = "Cancelamento de Registro")]
        CancelamentoRegistro,
        [Display(Name = "Reciprocidade CONFEA/OEP")]
        ReciprocidadeConfeaOep,
        [Display(Name = "Outros")]
        Outros
    }
}

using System.ComponentModel;

namespace JRod_Application.Enums
{
    public enum TipoServico
    {
        [Description("CAT c/ Reg. Atestado - Ativ Concluída")]
        CatComRegAtestadoAtivConcluida = 1,
        [Description("CAT c/ Reg. Atestado - Ativ Andamento")]
        CatComRegAtestadoAtivAndamento,
        [Description("CAT c/ Reg. Atestado - Complementar")]
        CatComRegAtestadoComplementar,
        [Description("CAT sem Registro de Atestado")]
        CatSemRegistroAtestado,
        [Description("2ª via de CAT")]
        SegundaViaCat,
        [Description("Substituição de CAT c/ Novo Atestado")]
        SubstituicaoCatComNovoAtestado,
        [Description("Certidão")]
        Certidao,
        [Description("Consulta")]
        Consulta,
        [Description("Elaboração de Ofício")]
        ElaboracaoOficio,
        [Description("Elaboração de Memorando")]
        ElaboracaoMemorando,
        [Description("Regularização de ART")]
        RegularizacaoArt,
        [Description("Baixa ART - Rescisão Contratual")]
        BaixaArtRescisaoContratual,
        [Description("Baixa ART - Interrupção de Reg. do RT")]
        BaixaArtInterrupcaoRegRt,
        [Description("Baixa ART - Baixa de Cargo/Função")]
        BaixaArtBaixaCargoFuncao,
        [Description("Baixa ART - Paralisação de Obra/Serviço")]
        BaixaArtParalisacaoObraServico,
        [Description("Baixa ART - Substituição de RT")]
        BaixaArtSubstituicaoRt,
        [Description("Baixa ART - Reg. da Empresa Cancelado")]
        BaixaArtRegEmpresaCancelado,
        [Description("Canc. ART - Contrato não executado")]
        CancArtContratoNaoExecutado,
        [Description("Canc. ART - Ativ. Téc. não executada")]
        CancArtAtivTecNaoExecutada,
        [Description("Apuração de Denúncia")]
        ApuracaoDenuncia,
        [Description("Abertura de Processo")]
        AberturaProcesso,
        [Description("Registro Novo")]
        RegistroNovo,
        [Description("Alteração de Contrato Social/Estatuto")]
        AlteracaoContratoSocialEstatuto,
        [Description("Indicação de RT")]
        IndicacaoRt,
        [Description("Renovação de RT")]
        RenovacaoRt,
        [Description("Baixa de RT")]
        BaixaRt,
        [Description("Cancelamento com comprovação")]
        CancelamentoComComprovacao,
        [Description("Cancelamento sem comprovação")]
        CancelamentoSemComprovacao,
        [Description("Visto em Registro")]
        VistoEmRegistro,
        [Description("Reabilitação de Registro")]
        ReabilitacaoRegistro,
        [Description("Boleto de Anuidade(s)")]
        BoletoAnuidade,
        [Description("Parcelamento de Anuidade(s)")]
        ParcelamentoAnuidade,
        [Description("Documentos de Atualização")]
        DocumentosAtualizacao,
        [Description("Prestação de Contas")]
        PrestacaoContas,
        [Description("Solicitações diversas")]
        SolicitacoesDiversas,
        [Description("Desconto - Recém Formado")]
        DescontoRecemFormado,
        [Description("Desconto - Tempo de Registro")]
        DescontoTempoRegistro,
        [Description("Desconto - Portador de Doença Grave")]
        DescontoPortadorDoencaGrave,
        [Description("Reemb. Anuidade - Pgto a maior")]
        ReembAnuidadePgtoMaior,
        [Description("Reemb. Anuidade - Duplicidade")]
        ReembAnuidadeDuplicidade,
        [Description("Reemb. ART - Obra/serviço não exec.")]
        ReembArtObraServiçoNaoExec,
        [Description("Reemb. ART - Pgto a maior")]
        ReembArtPgtoMaior,
        [Description("Reemb. ART - Duplicidade")]
        ReembArtDuplicidade,
        [Description("Reemb. Taxa - Pgto a maior")]
        ReembTaxaPgtoMaior,
        [Description("Reemb. Taxa - Duplicidade")]
        ReembTaxaDuplicidade,
        [Description("Reemb. Taxa - Serviço não prestado")]
        ReembTaxaServicoNaoPrestado,
        [Description("Cadastramento Escola")]
        CadastramentoEscola,
        [Description("Cadastramento Curso")]
        CadastramentoCurso,
        [Description("Envio de documentos")]
        EnvioDocumentos,
        [Description("Registro com Atestado")]
        RegistroComAtestado,
        [Description("Registro com Diploma")]
        RegistroComDiploma,
        [Description("Efetivação de Registro")]
        EfetivacaoRegistro,
        [Description("Anotação em Registro")]
        AnotacaoRegistro,
        [Description("2ª via de Carteira")]
        SegundaViaCarteira,
        [Description("Prorrogação de Registro Provisório")]
        ProrrogacaoRegistroProvisorio,
        [Description("Recadastramento")]
        Recadastramento,
        [Description("Interrupção de Registro")]
        InterrupcaoRegistro,
        [Description("Recurso de Interrupção de Registro")]
        RecursoInterrupcaoRegistro,
        [Description("Cancelamento de Registro")]
        CancelamentoRegistro,
        [Description("Reciprocidade CONFEA/OEP")]
        ReciprocidadeConfeaOep,
        [Description("Outros")]
        Outros
    }
}

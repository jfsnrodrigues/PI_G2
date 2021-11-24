using System.ComponentModel;

namespace JRod_Application.Enums
{
    public enum TipoAtividade
    {
        [Description("Protocolo (Web)")]
        ProtocoloWeb = 1,

        [Description("Protocolo (Creadoc)")]
        ProtocoloCreadoc,

        [Description("Processo")]
        Processo,

        [Description("Ordem de Serviço")]
        OrdemServico,

        [Description("E-mail")]
        Email,

        [Description("Telefone")]
        Telefone,

        [Description("Mensagens Celular")]
        MensagensCelular,

        [Description("Arrumação/Separação de Carteiras")]
        ArrumaçãoSeparacaoCarteiras,

        [Description("Digitalização de Imagens")]
        DigitalizacaoImagens,

        [Description("Disparo de Carteiras")]
        DisparoCarteiras,

        [Description("Recebimento/Abertura de Malotes Diversos")]
        RecebimentoAberturaMalotesDiversos,

        [Description("Outros")]
        Outros,
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JRod_Application.Enums
{
    public enum TipoAtividade
    {
        [Display(Name = "Protocolo (Web)")]
        ProtocoloWeb = 1,

        [Display(Name = "Protocolo (Creadoc)")]
        ProtocoloCreadoc,

        [Display(Name = "Processo")]
        Processo,

        [Display(Name = "Ordem de Serviço")]
        OrdemServico,

        [Display(Name = "E-mail")]
        Email,

        [Display(Name = "Telefone")]
        Telefone,

        [Display(Name = "Mensagens Celular")]
        MensagensCelular,

        [Display(Name = "Arrumação/Separação de Carteiras")]
        ArrumaçãoSeparacaoCarteiras,

        [Display(Name = "Digitalização de Imagens")]
        DigitalizacaoImagens,

        [Display(Name = "Disparo de Carteiras")]
        DisparoCarteiras,

        [Display(Name = "Recebimento/Abertura de Malotes Diversos")]
        RecebimentoAberturaMalotesDiversos,

        [Display(Name = "Outros")]
        Outros,
    }
}

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Desafio_Stats.Models.Enum
{
    [Flags]
    public enum MotivoAlgema
    {
        [Display(Name = "Selecione um motivo algema")]
        Nenhum = 0,
        [Display(Name = "Resistência")]
        Resistencia = 1,
        [Display(Name = "Suspeito de fuga")]
        SuspeitoFuga = 2,
        [Display(Name = "Integridade física")]
        IntegridadeFisica = 4,
        [Display(Name = "Outros")]
        Outros = 8,
    }
}

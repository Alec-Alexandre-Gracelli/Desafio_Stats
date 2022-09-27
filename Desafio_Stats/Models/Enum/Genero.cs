using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Desafio_Stats.Models.Enum
{
    public enum IdentidadeGenero : byte
    {
        [EnumMember(Value = "N")]
        [Display(Name = "Nenhum")]
        Nenhum = 0,
        [EnumMember(Value = "M")]
        [Display(Name = "Masculino")]
        Masculino = 1,
        [EnumMember(Value = "F")]
        [Display(Name = "Feminino")]
        Feminino = 2
    }
}

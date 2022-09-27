using System.ComponentModel.DataAnnotations;

namespace Desafio_Stats.Models.Enum
{
    public enum TipoCondicaoEnvolvido : byte
    {
        [Display(Name = "Selecione um Tipo de Condição de Envolvimento")]
        Nenhum = 0,
        [Display(Name = "Vítima")]
        Vitima = 1,
        [Display(Name = "Autor")]
        Autor = 2,
        [Display(Name = "Indiciado")]
        Indiciado = 3,
        [Display(Name = "Sindicado")]
        Sindicado = 4,
        [Display(Name = "Testemunha")]
        Testemunha = 5,
        [Display(Name = "Condutor")]
        Condutor = 6,
        [Display(Name = "Proprietário")]
        Proprietario = 7,
        [Display(Name = "Passageiro")]
        Passageiro = 8,
        [Display(Name = "Pedestre")]
        Pedestre = 9,
        [Display(Name = "Parte não definida")]
        ParteNaoDefinida = 10,
        [Display(Name = "Averiguado")]
        Averiguado = 11
    }
}

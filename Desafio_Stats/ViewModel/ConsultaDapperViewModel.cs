using Desafio_Stats.Models.Enum;

namespace Desafio_Stats.ViewModel
{
    public class ConsultaDapperViewModel
    {
        public Guid OcorrenciaEnvolvidoId { get; set; }
        public int Qtd { get;set; }
        public TipoCondicaoEnvolvido Condicao { get; set; }     
    }
}
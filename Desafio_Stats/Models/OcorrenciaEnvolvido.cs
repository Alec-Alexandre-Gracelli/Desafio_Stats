using Desafio_Stats.Models.Enum;
using Desafio_Stats.Resources;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace Desafio_Stats.Models
{
    public class OcorrenciaEnvolvido
    {
        public Guid OcorrenciaEnvolvidoId { get; set; }

        [Display(Name = "Condição")]
        public TipoCondicaoEnvolvido Condicao { get; set; }

        [Display(Name = "Uso algemas")]
        public bool UsoAlgemas { get; set; } = false;

        public MotivoAlgema? MotivoAlgema { get; set; }
        [MaxLength(100, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string OutroMotivoAlgema { get; set; }

        [MaxLength(280, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [MaxLength(30, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        [DataType(DataType.PhoneNumber)]
        public string RG { get; set; }

        [Display(Name = "órgão expeditor")]
        [MaxLength(20, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Expeditor { get; set; }

        [Display(Name = "órgão emissor")]
        [MaxLength(2, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string UFEMissor { get; set; }

        [MaxLength(180, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        [Display(Name = "Mãe")]
        public string NomeMae { get; set; }

        [MaxLength(180, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        [Display(Name = "Pai")]
        public string NomePai { get; set; }

        [MaxLength(50, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Nacionalidade { get; set; }

        [MaxLength(50, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Naturalidade { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Data Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [NotMapped, Display(Name = "Gênero")]
        public bool? isMasculino
        {
            get
            {
                switch (Genero)
                {
                    case IdentidadeGenero.Masculino: return true;
                    case IdentidadeGenero.Feminino: return false;
                    default: return null;
                }
            }
            set
            {
                switch (value)
                {
                    case true: this.Genero = IdentidadeGenero.Masculino; break;
                    case false: this.Genero = IdentidadeGenero.Feminino; break;
                    default: this.Genero = null; break;
                }
            }
        }

        [Display(Name = "Gênero")]
        public IdentidadeGenero? Genero { get; set; }

        [Display(Name = "CEP")]
        [MaxLength(9, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string CEP { get; set; }

        [Display(Name = "Logradouro")]
        [MaxLength(250, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Logradouro { get; set; }

        [Display(Name = "Nº")]
        [MaxLength(10, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string EnderecoNumero { get; set; }

        [Display(Name = "Complemento")]
        [MaxLength(50, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Complemento { get; set; }

        [Display(Name = "Bairro")]
        [MaxLength(80, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [MaxLength(80, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Cidade { get; set; }

        [Display(Name = "Estado")]
        [MaxLength(80, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Estado { get; set; }

        [Display(Name = "Observações"), MaxLength(Int32.MaxValue, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Observacoes { get; set; }

        [Display(Name = "Profissão"), MaxLength(50, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Profissao { get; set; }

        [MaxLength(50, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string Empresa { get; set; }

        [MaxLength(45, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string TelefoneFixo { get; set; }

        [MaxLength(45, ErrorMessageResourceType = typeof(TextosValidacao), ErrorMessageResourceName = nameof(TextosValidacao.MaxLength))]
        public string TelefoneCelular { get; set; }
    }
}

using Desafio_Stats.Models;
using Microsoft.EntityFrameworkCore;

namespace Desafio_Stats.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<OcorrenciaEnvolvido> ocorrenciaEnvolvidos { get; set; }
    }
}

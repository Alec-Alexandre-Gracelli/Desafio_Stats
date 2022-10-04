using Dapper;
using Desafio_Stats.Data;
using Desafio_Stats.Models;
using Desafio_Stats.Models.Enum;
using Desafio_Stats.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Desafio_Stats.Controllers
{
    public class OcorrenciaEnvolvidosController : Controller
    {
        private readonly BancoContext _context;

        public OcorrenciaEnvolvidosController(BancoContext context)
        {
            _context = context;
        }

       

        public async Task<IActionResult> IndexDapper()
        {
            var sql = "Select Count(*) as qtd,  Condicao from OcorrenciaEnvolvidos Group by Condicao Order by qtd desc";

            var dapper = (await _context.Database.GetDbConnection()
             .QueryAsync<ConsultaDapperViewModel>(sql: sql)).ToList();

            return View(dapper);
        }
    }
}

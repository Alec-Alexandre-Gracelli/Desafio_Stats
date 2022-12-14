using Dapper;
using Desafio_Stats.Data;
using Desafio_Stats.Models;
using Desafio_Stats.Models.Enum;
using Desafio_Stats.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
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

            string quantidade="";//65, 59, 80, 81, 56, 55, 40
            string condicao=""; //"Ocorrência 01", "Tráfico", "Assalto", "Roubo", "Furto", "Morte"

            foreach (var item in dapper)
            {
                quantidade += item.Qtd + ","  ;
                condicao += $"'{item.Condicao}',";
            }

            ViewBag.Quantidade = quantidade;
            ViewBag.Condicao = condicao;

            return View(dapper);
        }
    }
}

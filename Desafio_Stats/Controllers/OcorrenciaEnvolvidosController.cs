using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Desafio_Stats.Data;
using Desafio_Stats.Models;

namespace Desafio_Stats.Controllers
{
    public class OcorrenciaEnvolvidosController : Controller
    {
        private readonly BancoContext _context;

        public OcorrenciaEnvolvidosController(BancoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
              return View(await _context.ocorrenciaEnvolvidos.ToListAsync());
        }

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.ocorrenciaEnvolvidos == null)
            {
                return NotFound();
            }

            var ocorrenciaEnvolvido = await _context.ocorrenciaEnvolvidos
                .FirstOrDefaultAsync(m => m.OcorrenciaEnvolvidoId == id);
            if (ocorrenciaEnvolvido == null)
            {
                return NotFound();
            }

            return View(ocorrenciaEnvolvido);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OcorrenciaEnvolvidoId,Condicao,UsoAlgemas,MotivoAlgema,OutroMotivoAlgema,NomeCompleto,RG,Expeditor,UFEMissor,NomeMae,NomePai,Nacionalidade,Naturalidade,DataNascimento,Genero,CEP,Logradouro,EnderecoNumero,Complemento,Bairro,Cidade,Estado,Observacoes,Profissao,Empresa,TelefoneFixo,TelefoneCelular")] OcorrenciaEnvolvido ocorrenciaEnvolvido)
        {
            if (ModelState.IsValid)
            {
                ocorrenciaEnvolvido.OcorrenciaEnvolvidoId = Guid.NewGuid();
                _context.Add(ocorrenciaEnvolvido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ocorrenciaEnvolvido);
        }

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.ocorrenciaEnvolvidos == null)
            {
                return NotFound();
            }

            var ocorrenciaEnvolvido = await _context.ocorrenciaEnvolvidos.FindAsync(id);
            if (ocorrenciaEnvolvido == null)
            {
                return NotFound();
            }
            return View(ocorrenciaEnvolvido);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("OcorrenciaEnvolvidoId,Condicao,UsoAlgemas,MotivoAlgema,OutroMotivoAlgema,NomeCompleto,RG,Expeditor,UFEMissor,NomeMae,NomePai,Nacionalidade,Naturalidade,DataNascimento,Genero,CEP,Logradouro,EnderecoNumero,Complemento,Bairro,Cidade,Estado,Observacoes,Profissao,Empresa,TelefoneFixo,TelefoneCelular")] OcorrenciaEnvolvido ocorrenciaEnvolvido)
        {
            if (id != ocorrenciaEnvolvido.OcorrenciaEnvolvidoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ocorrenciaEnvolvido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OcorrenciaEnvolvidoExists(ocorrenciaEnvolvido.OcorrenciaEnvolvidoId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(ocorrenciaEnvolvido);
        }

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.ocorrenciaEnvolvidos == null)
            {
                return NotFound();
            }

            var ocorrenciaEnvolvido = await _context.ocorrenciaEnvolvidos
                .FirstOrDefaultAsync(m => m.OcorrenciaEnvolvidoId == id);
            if (ocorrenciaEnvolvido == null)
            {
                return NotFound();
            }

            return View(ocorrenciaEnvolvido);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.ocorrenciaEnvolvidos == null)
            {
                return Problem("Entity set 'BancoContext.ocorrenciaEnvolvidos'  is null.");
            }
            var ocorrenciaEnvolvido = await _context.ocorrenciaEnvolvidos.FindAsync(id);
            if (ocorrenciaEnvolvido != null)
            {
                _context.ocorrenciaEnvolvidos.Remove(ocorrenciaEnvolvido);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OcorrenciaEnvolvidoExists(Guid id)
        {
          return _context.ocorrenciaEnvolvidos.Any(e => e.OcorrenciaEnvolvidoId == id);
        }
    }
}

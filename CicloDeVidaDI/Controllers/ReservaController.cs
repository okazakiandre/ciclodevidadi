using CicloDeVidaDI.Validacoes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CicloDeVidaDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservaController : ControllerBase
    {
        private IEnumerable<IValidacao> Validacoes { get; }

        public ReservaController(IEnumerable<IValidacao> vlds)
        {
            Validacoes = vlds;
        }

        [HttpPost]
        public IActionResult Incluir(Reserva reserva)
        {
            var msgs = new List<string>();
            foreach(var v in Validacoes)
            {
                if (!v.EhValido(reserva))
                {
                    msgs.Add(v.MensagemErro);
                }
            }

            if (msgs.Any())
            {
                return BadRequest(new { Mensagem = string.Join('\n', msgs) });
            }
            else
            {
                return Ok(new { Mensagem = "Reserva concluída com sucesso." });
            }
        }
    }
}

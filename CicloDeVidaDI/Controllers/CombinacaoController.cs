using CicloDeVidaDI.Combinacoes;
using CicloDeVidaDI.Contadores;
using CicloDeVidaDI.Dtos;
using CicloDeVidaDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CicloDeVidaDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CombinacaoController : ControllerBase
    {
        private IClasseSingletonScoped SingleScop { get; }
        private IClasseSingletonTransient SingleTran { get; }
        private IClasseScopedSingleton ScopSingle { get; }
        private IClasseScopedTransient ScopTran { get; }

        public CombinacaoController(IClasseSingletonScoped sngScp,
                                    IClasseSingletonTransient sngTrn,
                                    IClasseScopedSingleton scpSng,
                                    IClasseScopedTransient scpTrn)
        {
            SingleScop = sngScp;
            SingleTran = sngTrn;
            ScopSingle = scpSng;
            ScopTran = scpTrn;
        }

        [HttpGet("singleton")]
        public IActionResult ObterSingleton()
        {
            return Ok(new 
            { 
                SingletonComScoped = SingleScop.ObterTmsCriacao(),
                SingletonComTransient = SingleTran.ObterTmsCriacao(),
            });
        }

        [HttpGet("scoped")]
        public IActionResult ObterScoped()
        {
            return Ok(new
            {
                ScopedComSingleton = ScopSingle.ObterTmsCriacao(),
                ScopedComTransient = ScopTran.ObterTmsCriacao(),
            });
        }
    }
}

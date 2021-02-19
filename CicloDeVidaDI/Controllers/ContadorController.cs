using CicloDeVidaDI.Contadores;
using CicloDeVidaDI.Dtos;
using CicloDeVidaDI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CicloDeVidaDI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContadorController : ControllerBase
    {
        private IContadorSingleton ContSingleton { get; }

        private IClienteScopedService Cliente { get; }
        private IProdutoScopedService Produto { get; }
        
        private IAdvogadoTransientService Advogado { get; }
        private IJuizTransientService Juiz { get; }

        public ContadorController(IContadorSingleton contadorSng, 
                                  IClienteScopedService cli,
                                  IProdutoScopedService prod,
                                  IAdvogadoTransientService adv,
                                  IJuizTransientService juiz)
        {
            ContSingleton = contadorSng;
            Cliente = cli;
            Produto = prod;
            Advogado = adv;
            Juiz = juiz;
        }

        [HttpGet]
        public ContagemDto ObterContagem()
        {
            ContSingleton.SomarUmERetornar();

            Cliente.ConsultarContagem();
            var finalScop = Produto.ConsultarContagem();

            Advogado.ConsultarContagem();
            var finalTran = Juiz.ConsultarContagem();

            return new ContagemDto
            {
                TotalSingleton = ContSingleton.Atual,
                TotalScoped = finalScop,
                TotalTransient = finalTran
            };
        }
    }
}

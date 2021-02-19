using CicloDeVidaDI.Contadores;

namespace CicloDeVidaDI.Services
{
    public class ProdutoScopedService : IProdutoScopedService
    {
        private IContadorScoped ContScoped { get; }

        public ProdutoScopedService(IContadorScoped contadorScp)
        {
            ContScoped = contadorScp;
        }

        public int ConsultarContagem() => ContScoped.SomarUmERetornar();
    }
}

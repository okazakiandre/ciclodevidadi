using CicloDeVidaDI.Contadores;

namespace CicloDeVidaDI.Services
{
    public class ClienteScopedService : IClienteScopedService
    {
        private IContadorScoped ContScoped { get; }

        public ClienteScopedService(IContadorScoped contadorScp)
        {
            ContScoped = contadorScp;
        }

        public int ConsultarContagem() => ContScoped.SomarUmERetornar();
    }
}

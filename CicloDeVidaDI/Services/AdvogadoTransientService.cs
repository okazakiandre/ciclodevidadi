using CicloDeVidaDI.Contadores;

namespace CicloDeVidaDI.Services
{
    public class AdvogadoTransientService : IAdvogadoTransientService
    {
        private IContadorTransient ContTransient { get; }

        public AdvogadoTransientService(IContadorTransient contadorTrn)
        {
            ContTransient = contadorTrn;
        }

        public int ConsultarContagem() => ContTransient.SomarUmERetornar();
    }
}

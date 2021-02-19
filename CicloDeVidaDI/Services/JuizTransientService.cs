using CicloDeVidaDI.Contadores;

namespace CicloDeVidaDI.Services
{
    public class JuizTransientService : IJuizTransientService
    {
        private IContadorTransient ContTransient { get; }

        public JuizTransientService(IContadorTransient contadorTrn)
        {
            ContTransient = contadorTrn;
        }

        public int ConsultarContagem() => ContTransient.SomarUmERetornar();
    }
}

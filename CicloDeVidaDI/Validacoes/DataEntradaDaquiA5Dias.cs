using System;

namespace CicloDeVidaDI.Validacoes
{
    public class DataEntradaDaquiA5Dias : IValidacao
    {
        public string MensagemErro { get; private set; }

        public bool EhValido(Reserva reserva)
        {
            if (reserva.DataEntrada > DateTime.Today.AddDays(4))
            {
                MensagemErro = "A data de entrada mínima é daqui a 5 dias.";
                return false;
            }
            return true;
        }
    }
}

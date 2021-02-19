namespace CicloDeVidaDI.Validacoes
{
    public class EstadiaMinimaDe3Dias : IValidacao
    {
        public string MensagemErro { get; private set; }

        public bool EhValido(Reserva reserva)
        {
            var dias = (reserva.DataSaida - reserva.DataEntrada).TotalDays;
            if (dias < 3)
            {
                MensagemErro = "A estadia mínima é de 3 dias.";
                return false;
            }
            return true;
        }
    }
}

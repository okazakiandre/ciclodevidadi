namespace CicloDeVidaDI.Validacoes
{
    public class DataSaidaPosteriorAEntrada : IValidacao
    {
        public string MensagemErro { get; private set; }

        public bool EhValido(Reserva reserva)
        {
            if (reserva.DataEntrada < reserva.DataSaida)
            {
                MensagemErro = "A data de saída deve ser posterior à entrada.";
                return false;
            }
            return true;
        }
    }
}

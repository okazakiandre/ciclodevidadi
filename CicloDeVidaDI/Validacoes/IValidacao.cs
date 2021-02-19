namespace CicloDeVidaDI.Validacoes
{
    public interface IValidacao
    {
        string MensagemErro { get; }
        bool EhValido(Reserva reserva);
    }
}

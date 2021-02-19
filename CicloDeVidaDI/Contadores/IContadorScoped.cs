namespace CicloDeVidaDI.Contadores
{
    public interface IContadorScoped
    {
        int Atual { get; }
        int SomarUmERetornar();
    }
}

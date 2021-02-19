namespace CicloDeVidaDI.Contadores
{
    public interface IContadorSingleton
    {
        int Atual { get; }
        int SomarUmERetornar();
    }
}

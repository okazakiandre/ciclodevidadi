namespace CicloDeVidaDI.Contadores
{
    public interface IContadorTransient
    {
        int Atual { get; }
        int SomarUmERetornar();
    }
}

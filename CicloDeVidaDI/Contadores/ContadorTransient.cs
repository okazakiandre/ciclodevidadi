namespace CicloDeVidaDI.Contadores
{
    public class ContadorTransient : IContadorTransient
    {
        public int Atual { get; private set; } = 0;
        public int SomarUmERetornar()
        {
            Atual += 1;
            return Atual;
        }
    }
}

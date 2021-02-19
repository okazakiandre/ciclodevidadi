namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseScopedSingleton : IClasseScopedSingleton
    {
        private IClasseSingleton Classe { get; }
        public ClasseScopedSingleton(IClasseSingleton sng)
        {
            Classe = sng;
        }
        public string ObterTmsCriacao() => Classe.ObterTms();
    }
}

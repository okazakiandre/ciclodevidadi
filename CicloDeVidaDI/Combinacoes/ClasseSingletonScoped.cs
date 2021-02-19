namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseSingletonScoped : IClasseSingletonScoped
    {
        private IClasseScoped Classe { get; }
        public ClasseSingletonScoped(IClasseScoped scp)
        {
            Classe = scp;
        }
        public string ObterTmsCriacao() => Classe.ObterTms();
    }
}

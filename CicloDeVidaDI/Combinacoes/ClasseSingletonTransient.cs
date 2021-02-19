namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseSingletonTransient : IClasseSingletonTransient
    {
        private IClasseTransient Classe { get; }
        public ClasseSingletonTransient(IClasseTransient trn)
        {
            Classe = trn;
        }
        public string ObterTmsCriacao() => Classe.ObterTms();
    }
}

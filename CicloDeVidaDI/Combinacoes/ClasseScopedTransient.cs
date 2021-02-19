namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseScopedTransient : IClasseScopedTransient
    {
        private IClasseTransient Classe { get; }
        public ClasseScopedTransient(IClasseTransient trn)
        {
            Classe = trn;
        }
        public string ObterTmsCriacao() => Classe.ObterTms();
    }
}

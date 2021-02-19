using System;

namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseTransient : IClasseTransient
    {
        private string Timestamp { get; }
        public ClasseTransient()
        {
            Timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public string ObterTms() => Timestamp;
    }
}

using System;

namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseScoped : IClasseScoped
    {
        private string Timestamp { get; }
        public ClasseScoped()
        {
            Timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public string ObterTms() => Timestamp;
    }
}

using System;

namespace CicloDeVidaDI.Combinacoes
{
    public class ClasseSingleton : IClasseSingleton
    {
        private string Timestamp { get; }
        public ClasseSingleton()
        {
            Timestamp = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        public string ObterTms() => Timestamp;
    }
}

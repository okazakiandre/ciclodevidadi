﻿namespace CicloDeVidaDI.Contadores
{
    public class ContadorScoped : IContadorScoped
    {
        public int Atual { get; private set; } = 0;
        public int SomarUmERetornar()
        {
            Atual += 1;
            return Atual;
        }
    }
}

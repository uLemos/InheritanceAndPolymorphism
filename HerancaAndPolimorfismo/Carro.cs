using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public abstract class Carro
    {
        public int Ano { get; set; } = 2010;
        public string Modelo { get; private set; }

        public Carro()
        {
            Modelo = this.GetType().Name;
        }

        protected void AumentarUmAno()
        {
            Ano++;
        }
    }
}

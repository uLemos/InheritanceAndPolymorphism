using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    public abstract class Carro
    {
        public int Ano { get; set; } = 2010;
        public string modelo { get; private set; }

        public virtual void AumentarAno(int quantidadeAnos) { Ano = 2012; } //Métodos virtuais á para serem sobreescritos por quem herdar
        public Carro()
        {
            modelo = this.GetType().Name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class GolRallye : Gol
    {
        public new void Fabricar()
        {
            AumentarUmAno();
            AumentarUmAno();
        }
    }
}

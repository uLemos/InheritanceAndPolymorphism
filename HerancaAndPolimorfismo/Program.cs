using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            var Gol = new Gol();
            Console.WriteLine(Gol.Modelo);
            Console.WriteLine(Gol.Ano);
            Gol.Fabricar();
            Console.WriteLine(Gol.Ano);

            var GolRallye = new GolRallye();
            Console.WriteLine(GolRallye.Modelo);
            Console.WriteLine(GolRallye.Ano);
            GolRallye.Fabricar();
            Console.WriteLine(GolRallye.Ano);

            Console.ReadKey(); // Digitar qualquer tecla para realizar uma próxima ação
        }
    }
}

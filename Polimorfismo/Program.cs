using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //SEM OVERLOAD/SOBRECARGAS
            //var carros = new List<Carro>()
            //{
            //    new Gol(),
            //    new GolRallye(),
            //};

            //foreach (var item in carros)
            //{
            //    Console.WriteLine($"modelo: {item.modelo}, ano: {item.Ano}");
            //    item.AumentarAno(1);

            //    Console.WriteLine($"modelo: {item.modelo}, ano: {item.Ano}");
            //}



            //COM OVERLOAD/SOBRECARGA

            var golRallye = new GolRallye(); 
            golRallye.AumentarAno();
            Console.WriteLine(golRallye.Ano);

            golRallye.AumentarAno(1);
            Console.WriteLine(golRallye.Ano);

            golRallye.AumentarAno(2,4);
            Console.WriteLine(golRallye.Ano);

            Console.ReadKey();
        }
    }
}

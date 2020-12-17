using System;
using System.Globalization;

namespace CondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((2 > 4) ? 50 : 80);
            Console.WriteLine((10 != 3) ? "Maria" : "Alex");
            Console.WriteLine((10 != 3) ? "Maria" : "Alex");
            
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;
            

            Console.WriteLine(desconto);
            
            
        }
    }
}
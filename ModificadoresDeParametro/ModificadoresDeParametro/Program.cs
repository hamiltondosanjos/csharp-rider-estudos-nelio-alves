using System;

namespace ModificadoresDeParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 6);
            Console.WriteLine(s2);
            Console.WriteLine(s1);
        }
    }
}
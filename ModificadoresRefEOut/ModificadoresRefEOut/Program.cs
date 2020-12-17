using System;

namespace ModificadoresRefEOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 10;
            int triple;
            Calculator.Triple2(b, out triple);
            Console.WriteLine(triple);
        }
    }
}
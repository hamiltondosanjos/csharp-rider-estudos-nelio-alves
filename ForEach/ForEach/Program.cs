using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] {"Maria", "Bob", "Alex"};
            //Para cada 'obj' dentro do 'vect'
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
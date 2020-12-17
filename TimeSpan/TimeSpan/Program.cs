using System;

namespace TimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            System.TimeSpan t1 = new System.TimeSpan(0, 1, 30);
            System.TimeSpan t2 = new System.TimeSpan(900000000L);
            System.TimeSpan t3 = new System.TimeSpan(2, 11, 21);
            System.TimeSpan t4 = new System.TimeSpan(1, 2, 11, 21);
            System.TimeSpan t5 = new System.TimeSpan(1, 2, 11, 21, 321);

            System.TimeSpan t6 = System.TimeSpan.FromDays(1.5);
            System.TimeSpan t7 = System.TimeSpan.FromHours(1.5);
            System.TimeSpan t8 = System.TimeSpan.FromMilliseconds(1.5);
            System.TimeSpan t9 = System.TimeSpan.FromMinutes(1.5);
            System.TimeSpan t10 = System.TimeSpan.FromSeconds(1.5);
            System.TimeSpan t11 = System.TimeSpan.FromTicks(9000000000L);
            
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            
        }
    }
}
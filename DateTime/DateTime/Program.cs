using System;
using System.Globalization;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime d1 = new System.DateTime(2018, 11, 25);
            System.DateTime d2 = new System.DateTime(2018, 11, 25, 20, 45, 3);
            System.DateTime d3 = new System.DateTime(2018, 11, 25, 20, 45, 3, 500);

            System.DateTime d4 = System.DateTime.Now;
            System.DateTime d5 = System.DateTime.Today;
            System.DateTime d6 = System.DateTime.UtcNow;

            System.DateTime d7 = System.DateTime.Parse("2000-08-15 13:05:58");
            System.DateTime d8 = System.DateTime.Parse("15/09/2000 03:00:30");

            System.DateTime d9 = System.DateTime.ParseExact("2000-01-25", "yyyy-MM-dd", CultureInfo.InvariantCulture);
      
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
            Console.WriteLine(d9);
           


            
        }
    }
}
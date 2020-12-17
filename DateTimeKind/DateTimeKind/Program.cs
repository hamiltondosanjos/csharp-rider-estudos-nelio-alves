using System;

namespace DateTimeKind
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d01 = new DateTime(200, 8, 15, 13, 5, 58, System.DateTimeKind.Local);
            
            DateTime d02 = new DateTime(200, 8, 15, 13, 5, 58, System.DateTimeKind.Utc);
            
            DateTime d03 = new DateTime(200, 8, 15, 13, 5, 58); 

            Console.WriteLine("d01: " + d01);
            Console.WriteLine("d1 kind: " + d01.Kind);
            Console.WriteLine("d1 to local: " + d01.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d01.ToUniversalTime());
            
            Console.WriteLine("d02: " + d02);
            Console.WriteLine("d2 kind: " + d02.Kind);
            Console.WriteLine("d2 to local: " + d02.ToLocalTime());
            Console.WriteLine("d2 to UTC: " + d02.ToUniversalTime());
            
            Console.WriteLine("d03: " + d03);
            Console.WriteLine("d3 kind: " + d03.Kind);
            Console.WriteLine("d3 to local: " + d03.ToLocalTime());
            Console.WriteLine("d3 to UTC: " + d03.ToUniversalTime());
           
            
        }
    }
}
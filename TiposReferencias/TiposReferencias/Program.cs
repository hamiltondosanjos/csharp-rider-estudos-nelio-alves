using System;

namespace TiposReferencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
            
            
            //Nullable<double> m = null;
            //ou
            double? m = null;
            double? n = 10.0;
            
            Console.WriteLine(m.GetValueOrDefault());
            Console.WriteLine(n.GetValueOrDefault());

            Console.WriteLine(m.HasValue);
            Console.WriteLine(n.HasValue);

            if (m.HasValue)
            {
                Console.WriteLine(m.Value);
            }
            else
            {
                Console.WriteLine("M is null"); 
            }

            if (n.HasValue)
            {
                Console.WriteLine(n.Value);
            }
            else
            {
                Console.WriteLine("N is null");
            }
               
            //Oprerador de coalescência nula
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

            


        }
    }
}
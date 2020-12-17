using System;

namespace DesafioMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Defina a matriz");
            int n = int.Parse(Console.ReadLine());
            
            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i,i] + " " );
            }

            Console.WriteLine();
            int count = 0;
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers:" + count);
        }
    }
}
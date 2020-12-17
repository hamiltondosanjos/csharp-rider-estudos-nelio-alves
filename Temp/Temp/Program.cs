using System;
using System.Globalization;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[2, 3];

            Console.WriteLine(mat.Length);
            // Quantidade de linhas
            Console.WriteLine(mat.Rank);
            //Primeira dimensão - linhas
            Console.WriteLine(mat.GetLength(0));
            //Segunda dimensão - colunas
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
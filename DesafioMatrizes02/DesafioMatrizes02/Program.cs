using System;

namespace DesafioMatrizes02
{
    class Program
    {
        static void Main(string[] args)
        {
            int coluna = 3;
            int linha = 4;
            
            double[,] matrix = new double[3, 4] 
                {
                    {10, 08, 15, 12},
                    {21, 11, 23, 08},
                    {14, 05, 13, 19}
                    
                };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i,j] == 8)
                    {
                        Console.WriteLine("Número: " + matrix[i,j]);
                        
                        Console.WriteLine("Posição: " + i + ", " + j);

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, (j - 1)]);
                        }
                        
                        if (j < 4 -1)
                        {
                            Console.WriteLine("Right: " + matrix[i, (j + 1)]);
                        }
                        
                        if (i < 3 -1)
                        {
                            Console.WriteLine("Down: " +  matrix[(i + 1),j]);   
                        }
                        if ( i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[ i - 1 ,j]); 
                        }
                    }                    
                }
            }
            
            
        }
    }
}
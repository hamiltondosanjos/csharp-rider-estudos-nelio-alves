using System;
using System.Diagnostics;

namespace ExercicioHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            Registro[] rooms = new Registro[9];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Número do quarto: ");
                int rent = int.Parse(Console.ReadLine());

                rooms[rent] = new Registro {Name = name, Email = email, Rent = rent};
            }

            for (int i = 0; i < rooms.Length; i++)
                
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine("Nome "+ rooms[i].Name + " Email: " + rooms[i].Email + " Número do Quarto: " + rooms[i].Rent);
                }
               
            }
        }
    }
}
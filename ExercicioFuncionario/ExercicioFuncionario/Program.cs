using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            
            List<Registro> funcionarios = new List<Registro>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employees - " + (i+1));
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                funcionarios.Add(new Registro {Id = id, Name = name, Salary = salary});
            }

            Console.WriteLine("Enter the employees id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());

            Registro comparacao = funcionarios.Find(x => x.Id == idIncrease);
            //List<Registro> comparacao = funcionarios.FindAll(x => x.Id == idIncrease);

            if (comparacao != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = Double.Parse(Console.ReadLine());
                comparacao.AumentaSalario(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }
            
            foreach (Registro obj in funcionarios)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
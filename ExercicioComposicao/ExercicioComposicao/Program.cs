using System;
using System.Globalization;
using ExercicioComposicao.Entities;
using ExercicioComposicao.Entities.Enums;

namespace ExercicioComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            //Convertendo string em tipo 'Enum'
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            
            Console.Write("Bsse Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Instanciando departamento
            Department dept = new Department(deptName);
            //Instanciando worker
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MMYYY/): ");
                
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                //instanciando contrato
                HourContract contract = new HourContract(date, valuePerHour, hours);
                //Adicionando o contrato para o worker
                worker.AddContract(contract);
            }

            Console.WriteLine("________________________________________________");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            //Subtraindo os 2 primeiros numeros da string acima
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
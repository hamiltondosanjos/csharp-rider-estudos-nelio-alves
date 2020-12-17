using System;
using System.Globalization;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            CaixaEletronico conta01 = new CaixaEletronico();
            
            Console.Write("Entre com o número da conta: ");
            conta01.NumeroConta = int.Parse(Console.ReadLine());

            Console.Write("Nome do titular da conta: ");
            conta01.Nome = Console.ReadLine();
            
            string iDeposito;
            Console.WriteLine("Deseja fazer um depósito inicial (s/n)? ");
            iDeposito = Console.ReadLine();
            
            if (iDeposito == "s")
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                conta01.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }

            /*Console.WriteLine("Conta " + conta01.NumeroConta + 
                              ", titular: " + conta01.Nome + "" 
                              + ", saldo " + conta01.Rendimento.ToString("F2", CultureInfo.InvariantCulture));*/
            Console.WriteLine(conta01);

            Console.WriteLine("Entre com um valor para depósito: ");
            conta01.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
           

            Console.WriteLine("Entre com um valor para saque: ");
            conta01.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            
            /*Console.WriteLine("Conta " + conta01.NumeroConta + 
                              ", titular: " + conta01.Nome + "" 
                              + ", saldo " + conta01.Rendimento.ToString("F2", CultureInfo.InvariantCulture));*/
            Console.WriteLine(conta01);

        }

    }

    
}
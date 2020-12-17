using System.Globalization;

namespace Exercicio07
{
    public class CaixaEletronico
    {
       public int NumeroConta { get;  set; } 
       public string Nome { get; set; }
       public double Rendimento { get;private set; }

       public CaixaEletronico(int numeroConta, string nome)
       {
           NumeroConta = numeroConta;
           Nome = nome;
       }
       public CaixaEletronico()
       {
       }

       public double Deposito(double deposito)
       {
           return Rendimento += deposito;
       }

       public double Saque(double saque)
       {
           return Rendimento = Rendimento - saque - 5;
       }

       public override string ToString()
       {
           return "Conta: " + NumeroConta + ", Titular: " + Nome + ", Saldo R$ " 
                  + Rendimento.ToString("F2", CultureInfo.InvariantCulture) ;
       }
    }
}
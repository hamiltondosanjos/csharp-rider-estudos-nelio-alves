using System.Globalization;

namespace ExercicioFuncionario
{
    public class Registro
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        

        public void AumentaSalario(double porcentagem)
        {
            Salary += Salary * porcentagem / 100;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Name: " 
                   + Name + ", Salary: $" 
                   + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
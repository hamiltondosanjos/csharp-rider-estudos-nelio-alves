using System.Globalization;

namespace Temp
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int qnt)
        {
            Quantidade += qnt;
        }

        public void RemoverProdutos(int qnt)
        {
            Quantidade -= qnt;
        }

        public override string ToString()
        {
            return "Dados do Produto: "
                   + Nome + ", Preço $"
                   + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                   + Quantidade + " Unidades, Total: $" + ValorTotalEmEstoque();
        }
    }
}
using System.Globalization;
namespace GerenciamentoDeEstoque
    
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()  //override = Sobreposição
        {
            return Nome 
                + ", $" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Globalization;

namespace GerenciamentoDeEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("Tv 4k");

            Console.WriteLine(p.GetNome());  //Minuto 11
        }
    }
}

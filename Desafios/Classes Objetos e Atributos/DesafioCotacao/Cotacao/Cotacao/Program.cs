using System;
using System.Globalization;

namespace Cotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotaçao do dólar: " + ConversorDeMoeda.DolarHoje.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.Write("Quantos dólares você vai comprar? ");
            double compraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pagoReais = ConversorDeMoeda.ValorEmReais(compraDolar);
            double valorComTaxa = ConversorDeMoeda.Taxa(pagoReais);
            Console.WriteLine("Valor a ser pago em reais = " + valorComTaxa.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

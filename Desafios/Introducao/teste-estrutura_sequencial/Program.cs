using System;

namespace teste_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exercício 1.1

            //int codigo1, qtd1, codigo2, qtd2;
            //float valor1, valor2, valorTotal;

            //Console.WriteLine("Exercício 1.1:");
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("Entrada:");
            //string entrada1 = Console.ReadLine();
            //string[] partes1 = entrada1.Split(' ');//Divide a string por espaços
            //codigo1 = int.Parse(partes1[0]); //Convert para int
            //qtd1 = int.Parse(partes1[1]);
            //valor1 = float.Parse(partes1[2]); //Convert para float

            //string entrada2 = Console.ReadLine();
            //string[] partes2 = entrada2.Split(' ');
            //codigo2 = int.Parse(partes2[0]);
            //qtd2 = int.Parse(partes2[1]);
            //valor2 = float.Parse(partes2[2]);

            //Console.Clear();

            //Console.WriteLine("Exercício 1.1:");
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("Entrada:");
            //Console.WriteLine($"Código: {codigo1}, Quantidade: {qtd1}, Valor: R${valor1:F2}");
            //Console.WriteLine($"Código: {codigo2}, Quantidade: {qtd2}, Valor: R${valor2:F2}");
            //Console.WriteLine("------------------------------------------------------------");

            //valorTotal = (qtd1 * valor1) + (qtd2 * valor2);
            //Console.WriteLine($"Valor a pagar: R${valorTotal:F2}");

            #endregion

            #region Exercício 1.2

            double valorRaio, valorSaida;            

            Console.WriteLine("Exercício 1.2:");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Qual o valor do raio? ");
            string entrada = Console.ReadLine();
            valorRaio = double.Parse(entrada); //Converte a entrada para double

            valorSaida = Math.PI * Math.Pow(valorRaio, 2); // Calcula a área: pi * raio^2 usando Math()

            Console.WriteLine();
            Console.WriteLine($"O valor da área é {valorSaida:F4}");

            #endregion
        }
    }
}

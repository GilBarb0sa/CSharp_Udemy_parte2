using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exemplo-1
            //string produto1 = "Conputador";
            //string produto2 = "Mesa de escri´torio";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
            //Console.WriteLine($"{produto2}, cujo preço é ${preco2}");

            //Console.WriteLine($"Registro: {idade} anos de idades, código {codigo} e gênero: {genero}");

            //Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            //Console.WriteLine($"Arredondado (três casa decimais: {medida:F3}");
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F2", CultureInfo.InvariantCulture));  //CultureInfo.InvariantCulture retira a virgula e substitui por ponto
            #endregion

            #region Exemplo-2
            //int n1 = int.Parse(Console.ReadLine());
            //char ch = char.Parse(Console.ReadLine());
            //double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // Para acrescentar ponto no lugar da virgula

            //string[] vet = Console.ReadLine().Split(' ');
            //string nome = vet[0];
            //char sexo = char.Parse(vet[1]);
            //int idade = int.Parse(vet[2]);
            //double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            //Console.WriteLine("Você digitou:");
            //Console.WriteLine(n1);
            //Console.WriteLine(ch);
            //Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region Exercício de Fixação
            Console.WriteLine("Entre com o seu nome completo");
            string n = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int age = int.Parse(vet[1]);
            double height = double.Parse(vet[2]);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine(n);
            Console.WriteLine(q);
            Console.WriteLine($"{p:F2}");
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
            #endregion
        }
    }
}

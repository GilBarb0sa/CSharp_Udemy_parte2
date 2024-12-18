﻿using System;
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
            //Console.WriteLine("Entre com o seu nome completo");
            //string n = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //int q = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de um produto:");
            //double p = double.Parse(Console.ReadLine());
            //Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            //string[] vet = Console.ReadLine().Split(' ');
            //string name = vet[0];
            //int age = int.Parse(vet[1]);
            //double height = double.Parse(vet[2]);

            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine(n);
            //Console.WriteLine(q);
            //Console.WriteLine($"{p:F2}");
            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine(height);
            #endregion

            #region Exercícios de Fixacao - If / Else

            //Exercício 1
            //int n = int.Parse(Console.ReadLine());
            //if (n < 0) {
            //    Console.WriteLine("Negativo!");
            //} 
            //else {
            //    Console.WriteLine("Não Negativo");
            //}

            //Exercício 2
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0)
            //{
            //    Console.WriteLine("PAR!");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR!");
            //}

            //Exercício 3
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //if (n % m == 0 || m % n == 0)
            //{
            //    Console.WriteLine("São Multiplos!");
            //}
            //else
            //{
            //    Console.WriteLine("Não São Multiplos");
            //}

            //Exercício 4
            //int entrada = int.Parse(Console.ReadLine());
            //int saida = int.Parse(Console.ReadLine());
            //if (entrada < saida)
            //{
            //    int durou = saida - entrada;
            //    Console.WriteLine($"O jogo durou {durou} hora(s)");
            //}
            //else if (entrada > saida)
            //{
            //    int durou = (24 - entrada) + (saida);
            //    Console.WriteLine($"O jogo durou {durou} hora(s)");
            //}
            //else if (entrada == 0 && saida == 0)
            //{
            //    Console.WriteLine("O jogo durou 24 horas!");
            //}

            //Exercício 5
            //Console.WriteLine("-------------------------------------");
            //Console.Write("Codigo".PadRight(10));
            //Console.Write("Especificação".PadRight(17));
            //Console.WriteLine("Preço");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1".PadRight(10) + "Cachorro Quente".PadRight(17) + "R$4,00");
            //Console.WriteLine("2".PadRight(10) + "X-Salada".PadRight(17) + "R$4,50");
            //Console.WriteLine("3".PadRight(10) + "X-Bacon".PadRight(17) + "R$5,00");
            //Console.WriteLine("4".PadRight(10) + "Torrada Simples".PadRight(17) + "R$2,00");
            //Console.WriteLine("5".PadRight(10) + "Refrigerante".PadRight(17) + "R$1,50");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("Insira o código do produto e a quantidade pedido:");
            //double valor;
            //double pagar;
            //int codigo = int.Parse(Console.ReadLine());
            //int qtd = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------");
            //if (codigo == 1)
            //{
            //    valor = 4.00;
            //    pagar = valor * qtd;
            //    Console.WriteLine($"O valor a conta foi R${pagar:F2}.");
            //}
            //else if (codigo == 2)
            //{
            //    valor = 4.50;
            //    pagar = valor * qtd;
            //    Console.WriteLine($"O valor a conta foi R${pagar:F2}.");
            //}
            //else if (codigo == 3)
            //{
            //    valor = 5.00;
            //    pagar = valor * qtd;
            //    Console.WriteLine($"O valor a conta foi R${pagar:F2}.");
            //}
            //else if (codigo == 4)
            //{
            //    valor = 2.00;
            //    pagar = valor * qtd;
            //    Console.WriteLine($"O valor a conta foi R${pagar:F2}.");
            //}
            //else if (codigo == 5)
            //{
            //    valor = 1.50;
            //    pagar = valor * qtd;
            //    Console.WriteLine($"O valor a conta foi R${pagar:F2}.");
            //}

            //Exercício 6
            //Console.WriteLine("Digite um número e veja qual dos intervalos ele se encontra");
            //Console.WriteLine("Exemplo: ([0,25], [25,50], [50,75], [75,100])");
            //Console.WriteLine("-----------------------------------------------------------");
            //double n = double.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------------------------------------------");
            //if (n >= 0 && n <= 25)
            //{
            //    Console.WriteLine("Intervalo [0, 25]");
            //}
            //else if (n > 25 && n <= 50)
            //{
            //    Console.WriteLine("Intervalo [25, 50]");
            //}
            //else if (n > 50 && n <= 75)
            //{
            //    Console.WriteLine("Intervalo [50, 75]");
            //}
            //else if (n > 75 && n <= 100)
            //{
            //    Console.WriteLine("Intervalo [75, 100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora do Intervalo!");
            //}

            //Exercício 7
            //Console.Write("Valor de x: ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("Valor de y: ");
            //double y = double.Parse(Console.ReadLine());
            //Console.WriteLine("------------------------------");
            //Console.Write("Quadrante: ");
            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0 && y < 0) 
            //{
            //    Console.WriteLine("Q3");
            //}
            //else if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("Q4");
            //}
            //else if (x == 0 && y == 0)
            //{
            //    Console.WriteLine("Origem!");
            //}

            //Exercício 7 
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("Renda".PadRight(27) + "Imposto de Renda");
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine("de 0.00 a R$2000.00".PadRight(27) + "Insento");
            //Console.WriteLine("de R$2000.01 a R$3000.00".PadRight(27) + "8%");
            //Console.WriteLine("de 3000.01 a R$4500.00".PadRight(27) + "18%");
            //Console.WriteLine("acima de R$4500.00".PadRight(27) + "28%");
            //Console.WriteLine("---------------------------------------------");
            //Console.Write("Valor de sua renda: R$");
            //double n = double.Parse(Console.ReadLine());
            //double imposto;
            //if (n>=0 && n<=2000)
            //{
            //    Console.WriteLine("Você esta insento de impostos.");
            //}
            //else if (n>=2000.01 && n<=3000)
            //{
            //    imposto = (1000 * 0.8) + (2 * 0.18);
            //    Console.WriteLine($"Você irá pagar R${imposto} de imposto.");
            //}
            //else if (n>=3000.01 && n<=4500)
            //{
            //    imposto = (1000 *0.18) + (2 * 0.18);
            //    Console.WriteLine($"Você irá pagar R${imposto} de imposto.");
            //}
            //else if (n>=4500.01)
            //{
            //    imposto = (1000 * 0.28) + (2 * 0.18);
            //    Console.WriteLine($"Você irá pagar R${imposto} de imposto.");
            //}

            //Resolução do Professor, ele pensou de outra forma a esquematização!
            //double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double imposto;
            //if (salario <= 2000.0)
            //{
            //    imposto = 0.0;
            //}
            //else if (salario <= 3000.0)
            //{
            //    imposto = (salario - 2000.0) * 0.08;
            //}
            //else if (salario <= 4500.0)
            //{
            //    imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            //}
            //else
            //{
            //    imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            //} 

            //if (imposto == 0.0)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else
            //{
            //    Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            //}
            #endregion

            #region Funções (sintaxe)
            //Console.WriteLine("Digite três números:");
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //int n3 = int.Parse(Console.ReadLine());
            //double resultado = Maior(n1, n2, n3);
            //Console.WriteLine("Maior = " + resultado);
            #endregion

            #region Estrutura de Repetição (While)

            //Console.Write("Digite um número: ");
            //double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (x >= 0.0)
            //{
            //    double raiz = Math.Sqrt(x);
            //    Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
            //    Console.Write("Digite outro número: ");
            //    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}
            //Console.WriteLine("Número negativo");
            #endregion

            #region Exercícios de Fixação - While
            //Exercício 1
            //int senhaCerta = 2002;
            //Console.Write("Digite a senha de acesso:");
            //int senha = int.Parse(Console.ReadLine());
            //while (senha != senhaCerta)
            //{
            //    Console.WriteLine("Senha Invalida!");
            //    int s = int.Parse(Console.ReadLine());
            //    senha = s;
            //}
            //Console.WriteLine("Acesso Permitido!");

            //Exercício 2
            //Console.Write("Digite o valor do vetor x e y: ");
            //string[] vet = Console.ReadLine().Split(' ');
            //int a = int.Parse(vet[0]);
            //int b = int.Parse(vet[1]);
            //while(a != 0 && b != 0)
            //{

            //    if(a > 0 && b > 0)
            //    {
            //        Console.WriteLine("Primeiro Quadrante.");
            //    }
            //    else if(a > 0 && b < 0)
            //    {
            //        Console.WriteLine("Segundo Quadrante.");
            //    }
            //    else if(a < 0 && b < 0)
            //    {
            //        Console.WriteLine("Terceiro Quadrante.");
            //    }
            //    else if(a < 0 && b > 0)
            //    {
            //        Console.WriteLine("Quarto Quadrante.");
            //    }
            //    Console.WriteLine("--------------------------------");
            //    Console.Write("Digite o valor do vetor x e y: ");
            //    string[] n = Console.ReadLine().Split(' ');
            //    int x = int.Parse(n[0]);
            //    int y = int.Parse(n[1]);
            //    a = x;
            //    b = y;
            //}
            //Console.WriteLine("Existe um número nulo!");

            //Exercício 3
            //Console.Write("Digite um número: ");
            //int n = int.Parse(Console.ReadLine());
            //while(n != 4)
            //{
            //    if(n == 1) 
            //    {
            //        Console.WriteLine("Alcool: 1");
            //    }
            //    else if(n ==2 )
            //    {
            //        Console.WriteLine("Gasolina: 2");
            //    }
            //    else if(n == 3)
            //    {
            //        Console.WriteLine("Diesel: 3");
            //    }
            //    Console.WriteLine("----------------------------");
            //    Console.Write("Digite um número: ");
            //    int numero = int.Parse(Console.ReadLine());
            //    n = numero;
            //}
            //Console.WriteLine("Muito Obrigado!");
            #endregion

            #region Estrutura de Repetição (For)
            //Console.Write("Quantos números inteiros você vai digitar? ");
            //int n = int.Parse(Console.ReadLine());
            //int soma = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write($"Valor #{i}: ");
            //    int x = int.Parse(Console.ReadLine());
            //    soma = soma + x;
            //}
            //Console.WriteLine($"O valor total é {soma}");
            #endregion

            #region Exercícios de Fixação For
            //Exercício 1
            //Console.Write("Digite um número e veja seus números ímpares: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }                
            //}

            //Exercício 2
            Console.Write("Quer que veja quantos números: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------");
            int dentroIntervalo = 0;
            int foraIntervalo = 0;
            for(int i = 1; i <= x; i++)
            {
                Console.Write("Digite um número e veja os números que estão entre 10 e 20:  ");
                int vet = int.Parse(Console.ReadLine());
                // Verifica se o número está entre 10 e 20
                if (vet >= 10 && vet <= 20)
                {
                    dentroIntervalo++;
                }
                else
                {
                    foraIntervalo++;
                }
            }
            // Exibe os resultados
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Números entre 10 e 20: {dentroIntervalo}");
            Console.WriteLine($"Números fora do intervalo de 10 e 20: {foraIntervalo}");

            #endregion


        }

        static int Maior(int a, int b, int c)
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }
}
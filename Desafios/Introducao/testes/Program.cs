using System;

namespace teste_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estrutura Sequencial
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

            //double valorRaio, valorSaida;            

            //Console.WriteLine("Exercício 1.2:");
            //Console.WriteLine("------------------------------------------------------------");
            //Console.Write("Qual o valor do raio? ");
            //string entrada = Console.ReadLine();
            //valorRaio = double.Parse(entrada); //Converte a entrada para double

            //valorSaida = Math.PI * Math.Pow(valorRaio, 2); // Calcula a área: pi * raio^2 usando Math()

            //Console.WriteLine();
            //Console.WriteLine($"O valor da área é {valorSaida:F4}");

            #endregion

            //Estrutura Condicional
            #region Exercícios 2.1

            //int codigo, qtd;
            //double valor, total;

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Codigo     Especificação     Preço");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1          Cachoro Quente    R$4,00");
            //Console.WriteLine("2          X-Salada          R$4,50");
            //Console.WriteLine("3          X-Bacon           R$5,00");
            //Console.WriteLine("4          Torrada Simples   R$2,00");
            //Console.WriteLine("5          Refrigerante      R$1,50");
            //Console.WriteLine("-----------------------------------------\n");

            //Console.WriteLine("Entrada:");

            //string entrada = Console.ReadLine();
            //string[] separar = entrada.Split(' ');
            //codigo = int.Parse(separar[0]);
            //qtd = int.Parse(separar[1]);

            //if (codigo == 1)
            //{
            //    valor = 4;
            //}
            //else if (codigo == 2)
            //{
            //    valor = 4.5;
            //}
            //else if (codigo == 3)
            //{
            //    valor = 5;
            //}
            //else if ( codigo == 4)
            //{
            //    valor = 2;
            //}
            //else
            //{
            //    valor = 1.5;
            //}

            //total = valor * qtd;

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine($"Total: R${total:F2}");

            #endregion

            #region Exercício 2.2

            //double a, b, c, x1, x2, delta;

            //Console.WriteLine("Calculo de Bhaskara");

            //string entradas = Console.ReadLine();
            //string[] separador = entradas.Split(' ');
            //a = double.Parse(separador[0]);
            //b = double.Parse(separador[1]);
            //c = double.Parse(separador[2]);

            //delta = Math.Pow(b, 2) - (4 * (a * c));

            //if (a != 0 && delta > 0 )
            //{
            //    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //    x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //    Console.WriteLine($"X1 = {x1:F5}");
            //    Console.WriteLine($"X2 = {x2:F5}");
            //}
            //else
            //{
            //    Console.WriteLine("Impossivel Calcular!");
            //}            

            #endregion

            //Estrutura Repetitivas
            #region Exercício 3.1

            //int senha;
            //int valor = 2002;         

            //do
            //{
            //    Console.Write("Digite a senha: ");
            //    string entrada = Console.ReadLine();
            //    senha = int.Parse(entrada);

            //    if (senha == valor)
            //    {
            //        Console.WriteLine("Acesso Permitido!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Senha Invalida!");
            //    }
            //} while (senha != valor);

            #endregion

            #region Exercício 3.2

            int n;
            int cont = 0;
            int dentro = 0; // Contador para os números entre 10 e 20
            int fora = 0;  // Contador para os números fora do intervalo 10-20

            Console.Write("Quer lê quantos números? ");
            n = int.Parse(Console.ReadLine());

            int[] leia = new int[n]; // Declaração do array para armazenar os números
         

            while (cont < n)
            {
                Console.Write("Digite o Valor: ");
                leia[cont] = int.Parse(Console.ReadLine()); // Armazena cada entrada no índice correspondente do array
                cont++;
            }

            Console.Clear();

            // Exibindo os valores inseridos 
            Console.WriteLine("Você digitou os seguintes números:");
            for (int i = 0; i < leia.Length; i++)
            {
                Console.WriteLine(leia[i]);
                if (leia[i] > 10 && leia[i] <20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"{dentro} In");
            Console.WriteLine($"{fora} Out");
            
            #endregion 

        }
    }
}

using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);  //pega o primeiro número digitado e definimos como linha
            int n = int.Parse(line[1]);  //pega o segundo número digitado e definimos como colunas
            //Com isso vc define o tamanho da matrix conforme os dados inseridos
            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' '); //Inseri os valores em linha
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);  //Aqui converte para inteiro
                }
            }

            int x = int.Parse(Console.ReadLine());  //Detalhe pega todos os números que são iguais ao valor solicitado

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x) //Verifica se tem algum numero na matrix igual o x!
                    {
                        Console.WriteLine("Position " + i + ", " + j + ":");  //Apresenta a posição do número x na matriz
                        if (j > 0)  //Lógica para apresentar o número a esquerda na matriz, referente ao x
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)  //Lógica para apresentar o número acima na matriz, referente ao x
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1)  //Lógica para apresentar o número a direita na matriz, referente ao x
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)  //Lógica para apresentar o número abaixo na matriz, referente ao x
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}

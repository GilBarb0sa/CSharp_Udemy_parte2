using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplos
            /*double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));*/
            #endregion

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n]; //instanciando uma matriz

            for (int i = 0; i < n; i++) //percorre as linhas
            {
                string[] values = Console.ReadLine().Split(' '); // para dar espaçamento entre os números                
                for (int j = 0; j < n; j++) //percorre as colunas e converte a string de values para int, inserindo nas respectivas linhas e colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }            
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative numbers: " + count);
        }
    }
}

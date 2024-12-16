using System;
using System.Collections.Generic;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();  //Insira a pasta que será lida

            try
            {
                using (StreamReader sr = File.OpenText(path))  //Abre o arquivo
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();  //Cria uma lista dictionary

                    while(!sr.EndOfStream) //Senão chegar ao final faça a ação debaixo
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');  //Lê a linha do arquivo. Divide a linha em um array usando a vírgula como delimitador
                        string candidate = votingRecord[0];  //Contém o nome do candidato
                        int votes = int.Parse(votingRecord[1]);   //Contém a quantidade de votos

                        if (dictionary.ContainsKey(candidate))  //Verifica se o candidato já existe no dicionário.
                        {
                            dictionary[candidate] += votes;  // soma os votos atuais com os novos.
                        }
                        else
                        {
                            dictionary[candidate] = votes;  //adiciona o candidato e a quantidade de votos.
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);  //percorre o dicionário e imprime cada chave (nome do candidato) e valor (número total de votos).
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}

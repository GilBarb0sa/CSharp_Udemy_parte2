using System;
using System.IO;
using System.Collections.Generic;
using InterfaceIComparable.Entities;

namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\40357200896\Documents\Gilberto\C# Udemy\Interface\IComparable\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))  //abre o caminho
                {
                    List<Employee> list = new List<Employee>(); //Cria uma lista
                    while (!sr.EndOfStream)  //percorre o arquivo enquanto não for o final do arquivo, vai se adicionando
                    {
                        list.Add(new Employee(sr.ReadLine()));  //add as informações de todas as linhas
                    }
                    list.Sort(); //ordena a lista
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
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

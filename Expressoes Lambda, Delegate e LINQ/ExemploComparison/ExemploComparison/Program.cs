﻿using System;
using System.Collections.Generic;
using ExemploComparison.Entities;

namespace ExemploComparison
{
    class Program
    {
        public static int globalValue = 3;

        static void Main(string[] args)
        {

            #region Parte 1
            //List<Product> list = new List<Product>();

            //list.Add(new Product("TV", 900.00));
            //list.Add(new Product("Notebook", 1200.00));
            //list.Add(new Product("Tablet", 450.00));            

            //list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));  //ordena a lista, expressão lambda inline

            //foreach (Product p in list)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Parte 2
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));
            }

            private static void ChangeOddValues(int[] numbers)
            {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
            }
        #endregion
    }
}

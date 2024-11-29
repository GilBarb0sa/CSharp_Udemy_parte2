using System;
using System.Collections.Generic;
using ColecoesHash.Entities;

namespace ColecoesHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("Tv", 900.00));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10); //Quando o tipo é struct, vai comparar por conteudo e não por referencia
            Console.WriteLine(b.Contains(p));
        }
    }
}

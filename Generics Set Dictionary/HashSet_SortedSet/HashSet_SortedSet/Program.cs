using System;
using System.Collections.Generic;

namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HASHSET");
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Computer"));
            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine();

            Console.WriteLine("SORTEDSET");
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //PrintCollection(a);
            // union
            SortedSet<int> c = new SortedSet<int>(a);  //Todos os conjuntos c vai ter o a, sortedset apresenta os valores ordenados
            c.UnionWith(b); //inserindo em c todos os valores de b sem repetição!
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a); // apresenta os elementos repetidos nos conjuntos
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);  // exclui os elementos repetidos
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection) 
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

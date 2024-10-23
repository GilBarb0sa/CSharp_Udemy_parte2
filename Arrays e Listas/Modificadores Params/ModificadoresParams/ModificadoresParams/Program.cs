using System;

namespace ModificadoresParams
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int s1 = Calculator.Sum(new int[] { 2, 3 });
            int s2 = Calculator.Sum(new int[] { 2, 4, 3 });
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);

            int b = 20;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);*/

            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

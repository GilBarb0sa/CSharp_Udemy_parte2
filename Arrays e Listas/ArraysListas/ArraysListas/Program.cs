using System;
using System.Globalization;

namespace ArraysListas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Structs
            /*Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
            

            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }
            double avg = sum / 3;
            Console.WriteLine($"Altura média: {avg.ToString("F2", CultureInfo.InvariantCulture)}");*/
            #endregion

            #region Classes
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine($"Preço médio: R${avg.ToString("F2",CultureInfo.InvariantCulture)}");
            #endregion
        }
    }
}

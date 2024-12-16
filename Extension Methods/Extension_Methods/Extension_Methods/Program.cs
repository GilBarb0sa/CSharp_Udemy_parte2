using System;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = new DateTime(2024, 12, 15, 20, 10, 45);
            //Console.WriteLine(dt.ElapsedTime());

            string s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}

using System;
using TryCacth.Entities;
using System.Globalization;

namespace TryCacth
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {            
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw Limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdraw);
            Console.WriteLine(account);
            }
            catch (Exception e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}

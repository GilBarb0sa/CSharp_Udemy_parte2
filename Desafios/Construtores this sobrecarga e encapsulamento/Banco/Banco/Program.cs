using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();

            Console.Write("Entre com o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            conta.NumeroConta(numeroConta);

            Console.Write("Entre o titular da conta: ");
            conta.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine();
            if (depositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: $ ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                conta.Deposito(deposito);
            }
            else if (depositoInicial == "n")
            {
                conta.DepositoSemSaldo();
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:\n" + conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: $");
            double deposito2 = double.Parse(Console.ReadLine());
            conta.Deposito(deposito2);
            Console.WriteLine("Dados da conta atualizados:\n" + conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: $");
            double saque = double.Parse(Console.ReadLine());
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:\n" + conta);
        }
    }
}

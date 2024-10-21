using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    class ContaBancaria
    {
        public string Nome { get; set; }
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public int NumeroConta(int conta)
        {
            Conta = conta;
            return Conta;
        }

        public void DepositoSemSaldo()
        {
            Saldo = 0.00;
        }
        public void Deposito(double saldo)
        {
            Saldo += saldo;
        }

        public void Saque(double saque)
        {
            if (saque <= Saldo)
            {
                Saldo = Saldo - saque - 5;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!\n");
            }            
        }

        public override string ToString()  //override = Sobreposição
        {
            return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesafioTSA
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            double sl = SalarioBruto - Imposto;
            return sl;
        }

        public void AumentarSalario(double porcentagem) 
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem/100);
        }

        public override string ToString()
        {
            return Nome
                + ", $ " 
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

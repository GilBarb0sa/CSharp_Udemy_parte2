using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DesafioTSA
{
    class Aluno
    {
        public string Nome;
        public double A;
        public double B;
        public double C;
       

        public double NotaFinal()
        {
            double nota = A + B + C;
            return nota;
        }


        public void Avaliacao()
        {
            if (NotaFinal() >= 60)
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                double falta = NotaFinal() - 60;
                Console.WriteLine("REPROVADO!");
                Console.WriteLine($"FALTARAM {Math.Abs(falta):F2} PONTOS.");
            }
        }

    }
}

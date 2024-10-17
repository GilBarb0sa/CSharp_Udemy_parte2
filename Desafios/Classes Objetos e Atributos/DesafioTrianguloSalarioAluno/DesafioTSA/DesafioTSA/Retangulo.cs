using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTSA
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            double a = Largura * Altura;
            return a;
        }

        public double Perimetro()
        {
            double p = 2 * Largura + 2 * Altura;
            return p;
        }

        public double Diagonal()
        {
            double d = Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
            return d;
        }
    }
}

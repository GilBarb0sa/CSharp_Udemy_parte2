using System;

namespace CalculandoAreaTrinagulo
{
    class Triangulo
    {
        public double A; //Atributos
        public double B;
        public double C;

        public double Area() //Metodo
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B)* (p - C));
        }
    }
}

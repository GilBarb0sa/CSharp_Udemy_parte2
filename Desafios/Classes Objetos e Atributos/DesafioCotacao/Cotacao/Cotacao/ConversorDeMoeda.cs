namespace Cotacao
{
    class ConversorDeMoeda
    {
        public static double DolarHoje = 3.10;
       
        public static double ValorEmReais(double r)
        {
            return r * DolarHoje;
        }

        public static double Taxa(double t)
        {            
            return t + t * 0.06; // Calcula 6% do valor em reais
        }
       
    }
}

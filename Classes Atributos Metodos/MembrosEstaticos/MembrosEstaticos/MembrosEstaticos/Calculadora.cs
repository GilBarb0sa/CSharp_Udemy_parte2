namespace MembrosEstaticos
{
    class Calculadora
    {
        public static double Pi = 3.14;  //declarando os metodos com o prefixo static,
        //faz com o que que permite que eles sejam chamados sem estanciar os objetos

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}

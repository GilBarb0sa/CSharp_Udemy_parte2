using System;
using System.Globalization;

namespace DesafioTSA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio 1
            //Retangulo r;
            //r = new Retangulo();
            //Console.WriteLine("Entra a largura e altura do retângulo:");
            //r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Area = " + r.Area().ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine();
            //Console.WriteLine("Perímetro = " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));

            //Console.WriteLine();
            //Console.WriteLine("Diagonal = " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            #region Exercicio 2
            //Funcionario x;
            //x = new Funcionario();

            //Console.Write("Nome: ");
            //x.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //x.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //x.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine("Funcionario: " + x.Nome + ", $ " + x.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double p = double.Parse(Console.ReadLine());
            //x.AumentarSalario(p);
            //Console.WriteLine("Dados atualizados: " + x);
            #endregion

            #region Exercicio 3
            Aluno x;
            x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
           
            Console.Write("Digite a nota A (máximo 30): ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x.A > 30 || x.A < 0)
            {
                Console.Write("Nota inválida! A nota A deve estar entre 0 e 30. Digite novamente: ");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
                        
            Console.Write("Digite a nota B (máximo 35): ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x.B > 35 || x.B < 0)
            {                
                Console.Write("Nota inválida! A nota B deve estar entre 0 e 35. Digite novamente: ");
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
                       
            Console.Write("Digite a nota C (máximo 35): ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (x.C > 35 || x.C < 0) 
            {
                Console.Write("Nota inválida! A nota C deve estar entre 0 e 35. Digite novamente: ");
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine();
            Console.WriteLine("Nota Final = " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            x.Avaliacao();
            #endregion
        }
    }
}

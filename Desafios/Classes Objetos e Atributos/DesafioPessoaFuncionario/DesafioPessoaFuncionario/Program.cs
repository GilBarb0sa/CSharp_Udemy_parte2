using System;
using System.Globalization;

namespace DesafioPessoaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pessoa
            //Pessoa x, y;
            //x = new Pessoa();         
            //y = new Pessoa();           

            //Console.WriteLine("Dados da primeira pessoa: ");          

            //Console.Write("Nome: ");
            //x.Nome = (Console.ReadLine());
            //Console.Write("Idade: ");
            //x.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("------------------------------------");

            //Console.WriteLine("Dados da segunda pessoa: ");         

            //Console.Write("Nome: ");
            //y.Nome = (Console.ReadLine());
            //Console.Write("Idade: ");
            //y.Idade = int.Parse(Console.ReadLine());

            //Console.Clear();

            //Console.WriteLine("Dados da primeira pessoa: ");
            //Console.WriteLine($"Nome: {x.Nome}" );
            //Console.WriteLine($"Idade: {x.Idade}");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Dados da segunda pessoa: ");
            //Console.WriteLine($"Nome: {y.Nome}");
            //Console.WriteLine($"Idade: {y.Idade}");
            //Console.WriteLine("------------------------------------");
            //if (x.Idade > y.Idade)
            //{
            //    Console.WriteLine($"Pessoa mais velha: {x.Nome}");
            //} else
            //{
            //    Console.WriteLine($"Pessoa mais velha: {y.Nome}");
            //}
            #endregion

            #region Funcionario
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            y.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine($"Nome: {x.Nome}");
            Console.WriteLine("Salário: " + x.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine($"Nome: {y.Nome}");
            Console.WriteLine("Salário: " + y.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("------------------------------------");
            double m = (x.Salario + y.Salario) / 2;
            Console.WriteLine("Salário médio = " + m.ToString("F2", CultureInfo.InvariantCulture));        

            #endregion
        }
    }
}

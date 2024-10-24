using System;
using System.Collections.Generic;
using System.Globalization;

namespace SalarioDosFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());  //Vai ser a quantidade de funcionario registrado

            List<Employee> list = new List<Employee>(); //instancia uma lista de funcionario

            for (int i = 1; i < n+1; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));  //No final do for vai sendo add na lista Employee
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());  //Pelo id adiciona um aumento de salario

            Employee emp = list.Find(x => x.Id == searchId);  // Procura na lista um Id semelhante a do solicitado em searchId
            if (emp != null) //Se for diferente de nulo, faz a ação abaixo
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage); //utiliza o metodo criado na classe Employee
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees: ");
            foreach (Employee obj in list)  //Pega a lista e coloca as informações na Classe Employee no obj e faz uma varreuda apresentando o conteudo conforme o override da classe
            {
                Console.WriteLine(obj);
            }
        }
    }
}

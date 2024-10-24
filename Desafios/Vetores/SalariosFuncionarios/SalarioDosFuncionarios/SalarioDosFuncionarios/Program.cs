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
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

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
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);  // Procura na lista um Id semelhante a do solicitado searchId
            if (emp != null) //Se for diferente de nulo, faz a ação abaixo
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees");
            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

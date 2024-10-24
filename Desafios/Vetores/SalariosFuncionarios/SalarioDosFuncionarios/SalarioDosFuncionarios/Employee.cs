using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SalarioDosFuncionarios
{
    class Employee
    {
        public int Id { get; set; }  //propriedades
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) //construtor
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)  //metodo
        {
            Salary += Salary * percentage / 100;
        }

        public override string ToString()  //sobrescreve
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}

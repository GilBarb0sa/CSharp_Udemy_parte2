using System;
using System.Globalization;

namespace InterfaceIComparable.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)  //Esse método é a implementação da interface IComparable
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not Employee");
            }
            Employee other = obj as Employee;  //Cast para Employee: O objeto obj é convertido para Employee com o operador as. Isso é seguro porque já foi verificado que o tipo é Employee.
            return Name.CompareTo(other.Name);
        }
    }
}

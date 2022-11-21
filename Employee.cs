using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Employee
    {
        public Employee(string name, DateTime dateOfBirth)
        {
            Console.WriteLine("Now {0} object accessed", GetType().Name);
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string? ToString()
        {
            return String.Format("{0} - {1} ", Name, DateOfBirth.ToString("D"));
        }
    }
}

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
            Name = name;
            DateOfBirth = dateOfBirth;
        }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string? ToString()
        {
            return String.Format("NAME : {0} - DATE OF BIRTH : {1} ", Name, DateOfBirth.ToString("D"));
        }
    }
}

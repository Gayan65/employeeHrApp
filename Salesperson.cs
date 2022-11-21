using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Salesperson : Employee
    {
      
        public Salesperson(string name, DateTime dateOfBirth, double bonus) : base(name, dateOfBirth)
        {
            Console.WriteLine("Now {0} object accessed", GetType().Name);
            Bonus = bonus;
        }

        public double Bonus { get; set; }

        public override string? ToString()
        {
            return base.ToString() + String.Format(" - Bonus : {0}", Bonus);
        }
    }
}

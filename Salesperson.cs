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
            Bonus = bonus;
        }

        public double Bonus { get; set; }

        public override string? ToString()
        {
            return base.ToString() + String.Format(" - BONUS : {0}%", Bonus);
        }
    }
}

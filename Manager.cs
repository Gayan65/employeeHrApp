using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Manager : Employee
    {
        public Manager(string name, DateTime dateOfBirth, int stock) : base(name, dateOfBirth)
        {
            Stock = stock;
        }

        public int Stock { get; set; }

        public override string? ToString()
        {
            return base.ToString() + String.Format(" - STOCK OPTION : {0}", Stock);
        }
    }
}

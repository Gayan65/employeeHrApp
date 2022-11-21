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
            Console.WriteLine("Now {0} object accessed", GetType().Name);
            Stock = stock;
        }

        public int Stock { get; set; }

        public override string? ToString()
        {
            return base.ToString() + String.Format(" - Stock : {0}", Stock);
        }
    }
}

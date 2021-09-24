using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Customer
    {
        public string Name => "david";

        public int Age => 35;

        public int GetOrdersByName(string name)
        {
            return string.IsNullOrEmpty(name) ? throw new ArgumentException("fail") : 100;
        }


    }
}

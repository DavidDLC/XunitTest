using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Names
    {
        public string  NickName { get; set; }

        public string MakfullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}

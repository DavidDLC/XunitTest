using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class DefaultPasswordValidator : IPasswordValidator
    {
        public bool validate(string password)
        {
            throw new NotImplementedException();
        }
    }
}

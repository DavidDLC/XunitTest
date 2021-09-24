using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Test
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest()
        {
            var names = new Names();
            var result = names.MakfullName("david", "cruz");
            Assert.Equal("david cruz", result);
            Assert.Equal("daviD cruz", result, ignoreCase: true);
            //Assert.Contains("David", result, StringComparison.CurrentCultureIgnoreCase);
            //Assert.Contains(" david", result, StringComparison.InvariantCultureIgnoreCase);
            //Assert.StartsWith("dav", result);//is case senstive
            //Assert.EndsWith("cruz", result); //is case senstive

            ////expression
            //Assert.Matches("[A-Z]{1}[a-z]+[A-Z]{1}[a-z]+", result);
        }

        

    }
}

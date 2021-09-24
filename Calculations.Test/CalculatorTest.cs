using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_givenTwoIntValues()
        {
            //arrange
            var cal = new Calculator();

            //act
            var result = cal.Add(1, 1);

            //asserts
            Assert.Equal(2,result);
        }

        [Fact]
        public void Add_givenTwoDoubleValues_ReturnsDouble()
        {
            //arrange
            var cal = new Calculator();

            //act
            var result = cal.AddDouble(1.2, 3.5);

            //asserts
            Assert.Equal(4.7, result,1);
        }
    }
}

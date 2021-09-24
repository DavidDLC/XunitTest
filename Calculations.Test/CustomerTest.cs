using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Test
{
    public class CustomerTest
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));

        }
        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();
            Assert.InRange(customer.Age, 25, 40);

        }

        [Fact]
        public void GetOrderByNanmeNotNull()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            
        }

        [Fact]
        public void GetOrderByNanmeNotNull2()
        {
            var customer = new Customer();
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("fail", exceptionDetails.Message);
        }

    }
}

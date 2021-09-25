using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculations.Test
{
    [Collection("Customer")]

    public class CustomerTest
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTest(CustomerFixture customerFixture )
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = _customerFixture.cust;
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));

        }
        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = _customerFixture.cust;
            Assert.InRange(customer.Age, 25, 40);

        }

        [Fact]
        public void GetOrderByNanmeNotNull()
        {
            var customer = _customerFixture.cust;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            
        }

        [Fact]
        public void GetOrderByNanmeNotNull2()
        {
            var customer = _customerFixture.cust;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));
            Assert.Equal("fail", exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(102);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }

    }
}

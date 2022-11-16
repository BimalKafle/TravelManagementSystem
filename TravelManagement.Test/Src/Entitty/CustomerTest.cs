using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.CoreLayer.Entity;
using Xunit;

namespace TravelManagement.Test.Entity
{
    public class CustomerTest
    {
        private readonly Customer customer;
        CustomerTest()
        {
           customer =  new Customer("Sushil", "Pokhara", "sushil@gmail.com");
        }
        [Fact]
        public void Test_Customer_Create_new_instance_with_default_data_successfully()
        {
            Assert.Equal("Sushil", customer.Name);
            Assert.Equal("Pokhara", customer.Address);
            Assert.Equal("sushil@gmail.com", customer.MailAddress);
        }
        [Fact]
        public void Test_IsActive_returns_True_if_class_IsActive()
        {
                Assert.True(customer.IsActive());
        }
        [Fact]
        public void Test_Activate_returns_True_if_class_Activate()
        {
            customer.Deactivate();
            customer.Activate();
            Assert.True(customer.IsActive());
        }
        [Fact]
        public void Test_Deactivate_returns_True_if_class_Deactivate()
        {
            customer.Deactivate();
            Assert.False(customer.IsActive());
        }
    }
}

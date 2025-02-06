using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpTraining_Jan2725;
namespace TestProject1
{
    //xunit
    //Moq framework
    //TDD
    public class CustomerTest
    {
        [Fact]
        public void TestCustomerCount()
        {
            Customer customer = new Customer();
            List<Customer> list = new List<Customer>();
            list.Add(new Customer { Id = 1, Name = "A", Type = "P" });
            list.Add(new Customer { Id = 2, Name = "B", Type = "T" });
            list.Add(new Customer { Id = 3, Name = "C", Type = "P" });
            Assert.Equal(3,customer.GetEmployeeCount(list));// Pass
        }
        [Fact]
        public void CreateCustomer()
        {
            Customer customer = new Customer();
            Assert.Equal(true, customer.Create(customer));
        }
    }
}

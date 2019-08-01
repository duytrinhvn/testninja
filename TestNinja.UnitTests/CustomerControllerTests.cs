﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);
            
            //NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //NotFound or any of its derivatives
            //Assert.That(result, Is.InstanceOf<NotFound>());
        }
        
        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);
            
            Assert.That(result, Is.TypeOf<Ok>());
            
            //Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
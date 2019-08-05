using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Me
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFoundClass()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnOkClass()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(4);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}

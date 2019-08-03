using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Me
{
    [TestFixture]
    class MathTests
    {
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var math = new Math();

            var result = math.Add(299, 100);

            Assert.That(result, Is.EqualTo(399));
        }

        [Test]
        public void Max_WhenFirstArgumentIsGreater_ReturnFirstArgument()
        {
            var math = new Math();

            var result = math.Max(188, 97);

            Assert.That(result, Is.EqualTo(188));
        }

        [Test]
        public void Max_WhenSecondArgumentIsGreater_ReturnSecondArgument()
        {
            var math = new Math();

            var result = math.Max(28, 37);

            Assert.That(result, Is.EqualTo(37));
        }

        [Test]
        public void Max_WhenArgumentsAreEqual_ReturnOneArgument()
        {
            var math = new Math();

            var result = math.Max(28, 28);

            Assert.That(result, Is.EqualTo(28));
        }
    }
}

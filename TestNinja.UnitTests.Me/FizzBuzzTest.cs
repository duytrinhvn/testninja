using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Me
{
    [TestFixture]
    class FizzBuzzTest
    {
        [Test]
        public void GetOutput_InputIsDivisableBy3Only_ReturnFizz() {
            var result = FizzBuzz.GetOutput(3);
            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_InputIsDivisableBy5Only_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(5);
            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_InputIsDivisableBy3And5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);
            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_InputIsNotDivisableBy3Or5_ReturnSameNumber()
        {
            var result = FizzBuzz.GetOutput(16);
            Assert.That(result, Is.EqualTo("16"));
        }
    }
}

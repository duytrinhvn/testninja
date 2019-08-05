using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Me
{
    [TestFixture]
    class MathTests
    {
        private Math _math;
        // TearDown
        // SetUp
        [SetUp]
        public void Setup()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(299, 100);

            Assert.That(result, Is.EqualTo(399));
        }

        [Test]
        [TestCase(28, 39, 39)]
        [TestCase(44, 33, 44)]
        [TestCase(55, 55, 55)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbers()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new[] {3, 1, 5 }));
        }

        [Test]
        public void GetOddNumbers_LimitIsZero_ReturnEmpty()
        {
            var result = _math.GetOddNumbers(0);

            Assert.That(result, Is.Empty);
        }

        [Test]
        public void GetOddNumbers_LimitIsLessThanZero_ReturnEmpty()
        {
            var result = _math.GetOddNumbers(-2);

            Assert.That(result, Is.Empty);
        }
    }
}

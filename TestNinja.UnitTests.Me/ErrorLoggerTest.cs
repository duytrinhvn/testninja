﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Me
{
    [TestFixture]
    class ErrorLoggerTest
    {
        private ErrorLogger _logger;
        [SetUp]
        public void SetUp()
        {
            _logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetLastErrorProperty()
        {
            _logger.Log("a");

            Assert.That(_logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That( () => _logger.Log(error), Throws.ArgumentNullException);
        }
    }
}

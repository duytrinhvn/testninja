using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Me
{
    [TestFixture]
    public class ReservasitionTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange (Tested Object) 
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result == true);
        }

        [Test]
        public void CanBeCancelledBy_AnotherCancelling_ReturnsFalse()
        {
            // Arrange (Tested Object) 
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = false });

            // Assert
            Assert.That(result == false);
        }

        [Test]
        public void CanBeCancelledBy_UserCancelling_ReturnsTrue()
        {
            // Arrange (Tested Object) 
            var reservation = new Reservation();

            // Act
            var reservedUser = new User();
            reservation.MadeBy = reservedUser;
            var result = reservation.CanBeCancelledBy(reservedUser);

            // Assert
            Assert.That(result == true);
        }
    }
}

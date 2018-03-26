using System;
using NUnit.Framework;
using DipTestingExercises.UnitTests.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    public class MotorVehicleTests
    {
        private MotorVehicle _motorVehicle;

        [SetUp]
        public void MotorVehicleSetUp()
        {
            _motorVehicle = new FakeMotorVehicle(new FakeDriver(), 100, 50, 2);
        }

        [Test]
        public void FakeMotorvehicleConstructor_WhenCalled_ReturnsCorrectAttributes()
        {
            // Assert
            Assert.That(_motorVehicle.maxFuel, Is.EqualTo(100));
            Assert.That(_motorVehicle.currentFuel, Is.EqualTo(50));
            Assert.That(_motorVehicle.litresPerKM, Is.EqualTo(2));
        }

        [Test]
        public void GetFuelRemaining_WhenCalled_ReturnsCurrentFuel()
        {
            // Act
            var result = _motorVehicle.getFuelRemaining();

            // Assert
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void Refuel_WhenCalled_ReturnsNewCurrentFuel()
        {
            // Act 
            _motorVehicle.refuel(50);

            // Assert
            Assert.That(_motorVehicle.currentFuel, Is.EqualTo(100));
        }
        
        [Test]
        [TestCase(51, "Vehicle cannot hold that much fuel!")]
        [TestCase(-1, "Someone is stealing fuel!!")]
        public void Refuel_WhenCalled_ThrowsExceptions(int input, string exceptionMessage)
        {
            // Act
            var ex = Assert.Throws<Exception>(() => _motorVehicle.refuel(input));

            // Assert
            Assert.That(ex.Message, Is.EqualTo(exceptionMessage));
        }

        [Test]
        public void Travel_WhenCalled_ReturnsCorrectFuelRemaining()
        {
            // Act
            _motorVehicle.travel(10);
            var result = _motorVehicle.getFuelRemaining();

            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Refuel_WhenCalled_ThrowsOutOfFuelExceptionMessage()
        {
            // Act
            var ex = Assert.Throws<Exception>(() => _motorVehicle.travel(26));

            // Assert
            Assert.That(ex.Message, Is.EqualTo("Out of Fuel!"));
        }
    }
}

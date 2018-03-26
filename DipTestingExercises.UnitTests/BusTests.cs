using System;
using NUnit.Framework;
using DipTestingExercises.UnitTests.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    public class BusTests
    {
        private FakeBus _bus;
        private IPerson _passengers;
        private IPerson _driver;

        [SetUp]
        public void BusSetUp()
        {
            _bus = new FakeBus(new FakeDriver(), 100, 50, 2, 1);
            _passengers = new FakePassenger();
            _driver = new FakeDriver();
        }

        [Test]
        public void FakeBusConstructor_WhenCalled_ReturnsCorrectAttributes()
        {
            // Assert
            Assert.That(_bus.maxPassengers, Is.EqualTo(1));
        }
        [Test]
        public void GetPassengerCount_BusIsEmpty_ReturnCorrentValue()
        {
            // Act
            var result = _bus.getPassengerCount();

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GetPassengerCount_AfterAddingPassenger_ReturnCorrentValue()
        {
            // Act
            _bus.passengers.Add(_passengers);
            var result = _bus.getPassengerCount();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void EmbarkPassenger_HasRoomForPassenger_ReturnsCorrectValue()
        {
            // Act
            _bus.embarkPassenger(_passengers);
            var result = _bus.getPassengerCount();

            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void EmbarkPassenger_BusIsFull_ThrowExceptionMessage()
        {
            // Act
            _bus.embarkPassenger(_passengers);
            var ex = Assert.Throws<Exception>(() => _bus.embarkPassenger(_passengers));

            // Assert
            // Assert
            Assert.That(ex.Message, Is.EqualTo("Bus is Already Full!"));
        }
    }
}

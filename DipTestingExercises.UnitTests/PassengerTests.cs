using System;
using NUnit.Framework;
using DipTestingExercises.UnitTests.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    class PassengerTests
    {
        private FakePassengerClass _passenger;

        [SetUp]
        public void PassengerSetUp()
        {
            _passenger = new FakePassengerClass("Barry", "Allen", "Male", "Full Fare");
        }

        [Test]
        public void PassengerConstructor_WhenCalled_ReturnsCorrectValues()
        {
            // Assert
            Assert.That(_passenger.fname, Is.EqualTo("Barry"));
            Assert.That(_passenger.lname, Is.EqualTo("Allen"));
        }

        [Test]
        public void GetLicenceType_WhenCalled_ReturnsCorrectValue()
        {
            // Act
            var result = _passenger.getTicketType();

            // Assert
            Assert.That(result, Is.EqualTo("Full Fare"));
        }

        [Test]
        [Ignore("Because Barry Allen doesn't need public transport :)")]
        public void Test_To_Ignore()
        { }
    }
}

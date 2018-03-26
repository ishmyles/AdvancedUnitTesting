using System;
using NUnit.Framework;
using DipTestingExercises.UnitTests.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    class DriverTests
    {
        private FakeDriverClass _driver;

        [SetUp]
        public void DriverSetUp()
        {
            _driver = new FakeDriverClass("Peter", "Parker", "Male", "Car");
        }

        [Test]
        public void DriverConstructor_WhenCalled_ReturnsCorrectValues()
        {
            // Assert
            Assert.That(_driver.fname, Is.EqualTo("Peter"));
            Assert.That(_driver.lname, Is.EqualTo("Parker"));
        }

        [Test]
        public void GetLicenceType_WhenCalled_ReturnsCorrectValue()
        {
            // Act
            var result = _driver.getLicenceType();

            // Assert
            Assert.That(result, Is.EqualTo("Car"));
        }
    }
}

using System;
using NUnit.Framework;
using DipTestingExercises.UnitTests.Mocking;

namespace DipTestingExercises.UnitTests
{
    [TestFixture]
    class PersonTests
    {
        private FakePerson _person;

        [SetUp]
        public void PersonSetUp()
        {
            _person = new FakePerson("Jon", "Snow", "Male");
        }

        [Test]
        public void Person_WhenCalled_ReturnsCorrectValues()
        {
            // Assert
            Assert.That(_person.fname, Is.EqualTo("Jon"));
            Assert.That(_person.lname, Is.EqualTo("Snow"));
        }

        [Test]
        public void GetName_WhenCalled_ReturnsFullName()
        {
            // Act
            var result = _person.getName();

            // Assert
            Assert.That(result, Is.EqualTo("Jon Snow"));
        }

        [Test]
        public void GetName_WhenCalled_ReturnsGender()
        {
            // Act
            var result = _person.getGender();

            // Assert
            Assert.That(result, Is.EqualTo("Male"));
        }
    }
}

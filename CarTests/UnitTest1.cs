using CarRental_BlazorApp.Models;
using DataAccessLibrary.Models;

namespace CarTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DisplayCarModel car = new DisplayCarModel();
            car.Registration = "Testing";
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void setRegistration()
        {
            DisplayCarModel car = new DisplayCarModel();
            car.Registration = "Testing";

            Assert.True(car.Registration.Equals("Testing"));
        }
    }
}
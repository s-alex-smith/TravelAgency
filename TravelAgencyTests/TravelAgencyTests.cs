using System;
using Xunit;
using TravelAgency;

namespace TravelAgencyTests
{
    public class EmployeeTest
    {
        private string defaultFirstName = "Bob";
        private string defaultSurname = "Builder";

        [Fact]
        public void GetsEmployeeFirstAndLastName()
        {
            // arrange

            // act
            var employee = new Employee(defaultFirstName, defaultSurname);

            // assert
            Assert.Equal(defaultFirstName, employee.FirstName);
            Assert.Equal(defaultSurname, employee.Surname);
        }

        [Fact]
        public void CheckGuidIsNotEmpty()
        {
            var employee = new Employee(defaultFirstName, defaultSurname);

            Assert.NotEqual(Guid.Empty, employee.Id);
        }
    }

    public class HotelTest
    {
        private string defaultName = "Marriott";
        private double defaultCost = 35.60;
        private double star = 4.5;


        [Fact]
        public void GetsEmployeeFirstAndLastName()
        {
            // arrange

            // act
            var hotel = new Hotel(defaultName, defaultCost, star);

            // assert
            Assert.Equal(defaultName, hotel.Name);
            Assert.Equal(defaultCost, hotel.CostPerNight);
            Assert.Equal(star, hotel.StarRating);
        }

        [Fact]
        public void CheckGuidIsNotEmpty()
        {
            var hotel = new Hotel(defaultName, defaultCost, star);

            Assert.NotEqual(Guid.Empty, hotel.Id);
        }
    }

    public class CustomerTest
    {
        private string defaultFirstName = "David";
        private string defaultSurname = "Boreanaz";
        private bool isAcceptingMarketing = true;


        [Fact]
        public void GetsCustomerFirstAndLastName()
        {
            // arrange

            // act
            var customer = new Customer(defaultFirstName, defaultSurname, isAcceptingMarketing);

            // assert
            Assert.Equal(defaultFirstName, customer.FirstName);
            Assert.Equal(defaultSurname, customer.Surname);
            Assert.Equal(isAcceptingMarketing, customer.IsAcceptingMarketing);
        }

        [Fact]
        public void CheckGuidIsNotEmpty()
        {
            var customer = new Customer(defaultFirstName, defaultSurname, isAcceptingMarketing);

            Assert.NotEqual(Guid.Empty, customer.Id);
        }
    }
}

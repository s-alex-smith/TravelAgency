using System;
using Xunit;
using TravelAgency;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

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

    public class AgencyTests
    {
        [Fact]
        public void CheckEmployeeListIsNotEmpty()
        {
            // arrange
            var employee1 = new Employee ("John", "Dillon");
            var employee2 = new Employee ("Pope","Francis");
            var listOfEmployees = new List<Employee>()
            {
                employee1,
                employee2
            };
            var mockParser = new Mock<ILoadData>();
            mockParser.Setup(parser => parser.LoadEmployeeData()).Returns(Task.FromResult(listOfEmployees));
            var agency = new Agency(mockParser.Object);

            // act

            // assert
            Assert.True(agency.Employees.Count > 0);
        }

        [Fact]
        public void CheckHotelListIsNotEmpty()
        {
            // arrange
            var hotel1 = new Hotel("5* Hotel", 200.00, 10.0);
            var hotel2 = new Hotel("5*+ Hotel", 300.50, 10.0);
            var listOfHotels = new List<Hotel>()
            {
                hotel1,
                hotel2
            };
            var mockParser = new Mock<ILoadData>();
            mockParser.Setup(parser => parser.LoadHotelData()).Returns(Task.FromResult(listOfHotels));
            var agency = new Agency(mockParser.Object);

            // act

            // assert
            Assert.True(agency.Hotels.Count > 0);
        }
    }
}

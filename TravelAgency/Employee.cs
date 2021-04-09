using System;

namespace TravelAgency
{
    public class Employee
    {

        public Guid Id { get; private set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public Employee(string firstName, string surname) 
        {
            FirstName = firstName;
            Surname = surname;
            Id = Guid.NewGuid();

        }
    }
}

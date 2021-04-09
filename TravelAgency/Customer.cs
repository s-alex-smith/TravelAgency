using System;

namespace TravelAgency
{
    public class Customer : Employee
    {
        public bool IsAcceptingMarketing { get; set; } = false;

        public Customer(string firstName, string surname, bool isAcceptingMarketing) : base(firstName, surname)
        {
            IsAcceptingMarketing = isAcceptingMarketing;
        }
    }
}

using System;
namespace TravelAgency
{
    public class Hotel
    {
        public string Name { get; set; }
        public Guid Id { get; private set; }
        public double CostPerNight { get; set; }
        public double StarRating { get; set; }

        public Hotel(string name, double costPerNight, double starRating)
        {
            Name = name;
            Id = Guid.NewGuid();
            CostPerNight = costPerNight;
            StarRating = starRating;
        }
    }
}
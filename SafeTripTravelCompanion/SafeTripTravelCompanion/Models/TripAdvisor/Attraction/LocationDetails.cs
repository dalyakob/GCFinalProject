using System;
namespace SafeTripTravelCompanion.Models.TripAdvisor.Attraction
{
    public class LocationDetails
    {
        public string location_id { get; set; }

        public string name { get; set; }

        public string location_string { get; set; }

        public string rating { get; set; }

        public string ranking { get; set; }

        public string description { get; set; }

        public string phone { get; set; }

        public string website { get; set; }

        public string address { get; set; }

        public Photo photo { get; set; }

        public AddressObject address_obj { get; set; }
    }
}

namespace SafeTripTravelCompanion.Models.TripAdvisor.ResultObject
{
    public class ResultObject
    {
        public string location_id { get; set; }

        public string name { get; set; }

        public string latitude { get; set; }

        public string longitude { get; set; }

        public Photo photo { get; set; }

        public string location_string { get; set; }

        public string address { get; set; }

        public AddressObject address_obj { get; set; }
    }
}
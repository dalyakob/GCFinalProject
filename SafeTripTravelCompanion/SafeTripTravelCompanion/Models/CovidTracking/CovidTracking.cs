namespace SafeTripTravelCompanion.Models
{
    public class CovidTracking
    {
        public int date { get; set; }
        public string state { get; set; }
        public int positiveIncrease { get; set; }
        public int positive { get; set; }
        public int totalTestResultsIncrease { get; set; }
        public int totalTestResults { get; set; }

    }
}
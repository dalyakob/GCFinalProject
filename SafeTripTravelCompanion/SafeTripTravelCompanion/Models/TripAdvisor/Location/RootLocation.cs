using SafeTripTravelCompanion.Models.TripAdvisor.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.TripAdvisor.Location
{
    public class RootLocation
    {
        public IEnumerable<DataLocation> data { get; set; }
    }
}

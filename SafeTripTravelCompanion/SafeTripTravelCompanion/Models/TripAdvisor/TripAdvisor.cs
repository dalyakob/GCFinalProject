using SafeTripTravelCompanion.Models.TripAdvisor.ResultObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.TripAdvisor
{
    public class TripAdvisor
    {
        public IEnumerable<DataLocation> data { get; set; }
    }
}

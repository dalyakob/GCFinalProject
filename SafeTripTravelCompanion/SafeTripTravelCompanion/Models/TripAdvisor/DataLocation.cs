using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.TripAdvisor.ResultObject
{
    public class DataLocation
    {
        public string result_type { get; set; }
        public ResultObject result_object { get; set; }
    }
}

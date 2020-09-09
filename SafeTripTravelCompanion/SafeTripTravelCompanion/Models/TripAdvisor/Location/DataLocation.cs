using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.TripAdvisor.Location
{
    public class DataLocation
    {
        [JsonPropertyName("result_object")]
        public ThingsToDo resultobject { get; set; }
    }
}

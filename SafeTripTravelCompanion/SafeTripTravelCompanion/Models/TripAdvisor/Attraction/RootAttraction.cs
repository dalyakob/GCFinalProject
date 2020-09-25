using System;
using System.Collections;
using System.Collections.Generic;

namespace SafeTripTravelCompanion.Models.TripAdvisor.Attraction
{
    public class RootAttraction
    {
        public IEnumerable<LocationDetails> data { get; set; }

        internal bool Any()
        {
            throw new NotImplementedException();
        }
    }
}

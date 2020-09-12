using SafeTripTravelCompanion.Models;
using SafeTripTravelCompanion.Models.DataUSA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public class ApiCovidTrackingService : ICovidTrackingService
    {
        private readonly HttpClient _client;

        public ApiCovidTrackingService(HttpClient client)
        {
            _client = client;
        }

        public async Task<double>  GetCovidRate(string state)
        {
            state = state.ToUpper().Trim();

            if (state.Length > 2)
                state = ConvertState(state);

            var statePositive = await _client.GetFromJsonAsync<IEnumerable<CovidTracking>>($"{state}/daily.json");

            double population = await FindPopulation(state);

            return (statePositive.ElementAt(0).positive / population); // returning percentage of covid infection 
        }

        public async Task<int> FindPopulation(string state)
        {

            state = state.ToUpper().Trim();

            if (state.Length == 2)
                state = ConvertState(state);

            //brings a list of state populations
            var UsPopulation = await _client.GetFromJsonAsync<DataUSA>("https://datausa.io/api/data?drilldowns=State&measures=Population&year=latest");
            
            foreach (var item in UsPopulation.data)
            {
                if (item.state == state)
                {
                    return item.population;
                }
            }

            return -1;
        }
        public string ConvertState(string state) // AL || alabama
        {
            var states = new Dictionary<string, string>();

            states.Add("AL", "Alabama");
            states.Add("AK", "Alaska");
            states.Add("AZ", "Arizona");
            states.Add("AR", "Arkansas");
            states.Add("CA", "California");
            states.Add("CO", "Colorado");
            states.Add("CT", "Connecticut");
            states.Add("DE", "Delaware");
            states.Add("DC", "District of Columbia");
            states.Add("FL", "Florida");
            states.Add("GA", "Georgia");
            states.Add("HI", "Hawaii");
            states.Add("ID", "Idaho");
            states.Add("IL", "Illinois");
            states.Add("IN", "Indiana");
            states.Add("IA", "Iowa");
            states.Add("KS", "Kansas");
            states.Add("KY", "Kentucky");
            states.Add("LA", "Louisiana");
            states.Add("ME", "Maine");
            states.Add("MD", "Maryland");
            states.Add("MA", "Massachusetts");
            states.Add("MI", "Michigan");
            states.Add("MN", "Minnesota");
            states.Add("MS", "Mississippi");
            states.Add("MO", "Missouri");
            states.Add("MT", "Montana");
            states.Add("NE", "Nebraska");
            states.Add("NV", "Nevada");
            states.Add("NH", "New Hampshire");
            states.Add("NJ", "New Jersey");
            states.Add("NM", "New Mexico");
            states.Add("NY", "New York");
            states.Add("NC", "North Carolina");
            states.Add("ND", "North Dakota");
            states.Add("OH", "Ohio");
            states.Add("OK", "Oklahoma");
            states.Add("OR", "Oregon");
            states.Add("PA", "Pennsylvania");
            states.Add("RI", "Rhode Island");
            states.Add("SC", "South Carolina");
            states.Add("SD", "South Dakota");
            states.Add("TN", "Tennessee");
            states.Add("TX", "Texas");
            states.Add("UT", "Utah");
            states.Add("VT", "Vermont");
            states.Add("VA", "Virginia");
            states.Add("WA", "Washington");
            states.Add("WV", "West Virginia");
            states.Add("WI", "Wisconsin");
            states.Add("WY", "Wyoming");
            
            if (states.ContainsKey(state))
                return states[state];
            else if(states.ContainsValue(state))
                return states.FirstOrDefault(x => x.Value == state).Key;

            /* error handler is to return an empty string rather than throwing an exception */
            return "";
        }

    }
}

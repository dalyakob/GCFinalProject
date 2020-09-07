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
        public async Task<IEnumerable<CovidTracking>> GetState(string state)
        {
            return await _client.GetFromJsonAsync<IEnumerable<CovidTracking>>($"{state}/daily.json");
        }
        public async Task<double>  GetCovidRate(string state)
        {
            var statePositive = await _client.GetFromJsonAsync<IEnumerable<CovidTracking>>($"{state}/daily.json");

            double population = await FindPopulation(state);

            return (statePositive.ElementAt(2).positive / population) *100; // returning percentage of covid infection 
        }

        public async Task<int> FindPopulation(string state)
        {
            state = ConvertStateFromAbv(state);

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
        public string ConvertStateFromAbv(string stateAbv)
        {
            string state;

            switch (stateAbv)
            {
                case "AZ":
                    state = "Arizona";
                    break;

                default:
                    state = null;
                    break;
            }

            return state;
        }

    }
}

using SafeTripTravelCompanion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public class ApiTripAdvisorService : ITripAdvisorService
    {
        private readonly HttpClient _client;

        public ApiTripAdvisorService(HttpClient client)
        {
            _client = client;
        }
        public async Task<TripAdvisor> Get(int id)
        {
            return await _client.GetFromJsonAsync<TripAdvisor>($" /{id}");
        }

        public async  Task<IEnumerable<TripAdvisor>> GetAll()
        {
            return await _client.GetFromJsonAsync<IEnumerable<TripAdvisor>>("");
        }
    }
}

using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using SafeTripTravelCompanion.Models.TripAdvisor;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;

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

        public async  Task<TripAdvisor> GetLocation(string search)
        {
            var UrlSearch = HttpUtility.UrlEncode(search);
            return await _client.GetFromJsonAsync<TripAdvisor>($"auto-complete?lang=en_US&units=km&query=London");
        }
    }
}
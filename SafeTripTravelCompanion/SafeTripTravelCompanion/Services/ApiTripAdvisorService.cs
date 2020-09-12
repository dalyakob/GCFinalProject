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
            return await _client.GetFromJsonAsync<TripAdvisor>($"https://tripadvisor1.p.rapidapi.com/locations/search?location_id=1&limit=30&sort=relevance&offset=0&lang=en_US&currency=USD&units=km&query={UrlSearch}");
        }
    }
}
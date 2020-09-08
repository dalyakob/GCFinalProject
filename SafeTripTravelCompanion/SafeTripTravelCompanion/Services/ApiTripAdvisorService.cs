using Newtonsoft.Json;
using SafeTripTravelCompanion.Models.TripAdvisor;
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

        public async  Task<IEnumerable<TripAdvisor>> GetAll(string search)
        {
            QueryStringConverter converter = new QueryStringConverter();
            //if (converter.CanConvert(typeof(Int32)))
            //    converter.ConvertStringToValue("123", typeof(Int32));
            //int value = 321;
            //string strValue = converter.ConvertValueToString(value, typeof(Int32));
            //Console.WriteLine("the value = {0}, the string representation of the value = {1}", value, strValue);
            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(search);
            return await _client.GetFromJsonAsync<IEnumerable<TripAdvisor>>($"auto-complete?lang=en_US&units=km&query={values}");
        }
    }
}
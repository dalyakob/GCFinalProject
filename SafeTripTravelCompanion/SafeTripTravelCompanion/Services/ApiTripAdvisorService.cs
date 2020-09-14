using SafeTripTravelCompanion.Models.TripAdvisor.Location;
using SafeTripTravelCompanion.Models.TripAdvisor.Attraction;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using SafeTripTravelCompanion.Models.DataBase;
using System.Linq;

namespace SafeTripTravelCompanion.Services
{
    public class ApiTripAdvisorService : ITripAdvisorService
    {
        private readonly HttpClient _client;

        public ApiTripAdvisorService(HttpClient client)
        {
            _client = client;
        }
        public async Task<RootAttraction> Get(int id)
        {
            return await _client.GetFromJsonAsync<RootAttraction>($"attractions/list?lang=en_US&currency=USD&sort=recommended&lunit=km&location_id={id}");
        }

        public async Task<IEnumerable<LocationDetails>> GetBucketList(List<BucketList> bucketListIds)
        {
            var bucketList = new List<LocationDetails>();
            foreach (var item in bucketListIds) 
            {
                var listItem = await _client.GetFromJsonAsync<RootAttraction>($"attractions/list?lang=en_US&currency=USD&sort=recommended&lunit=km&location_id={item.BucketListId}");
                bucketList.Add(listItem.data.ElementAt(0));
            }
            return bucketList;
        }

        public async  Task<RootLocation> GetLocation(string search)
        {
            var UrlSearch = HttpUtility.UrlEncode(search);
            return await _client.GetFromJsonAsync<RootLocation>($"locations/search?location_id=1&limit=30&sort=relevance&offset=0&lang=en_US&currency=USD&units=km&query={UrlSearch}");
        }

    }
}
using SafeTripTravelCompanion.Models.TripAdvisor.Location;
using SafeTripTravelCompanion.Models.TripAdvisor.Attraction;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;
using System.Collections.Generic;
using SafeTripTravelCompanion.Models.DataBase;
using System.Linq;
using System;
using System.Linq.Expressions;
using Microsoft.CodeAnalysis;

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

        public async Task<RootAttraction> GetBucketList(List<BucketList> bucketListItems)
        {
            var bucketList = new List<LocationDetails>();
            foreach (var item in bucketListItems) 
            {
                var listItem = await _client.GetFromJsonAsync<RootAttraction>($"attractions/list?lang=en_US&currency=USD&sort=recommended&lunit=km&location_id={item.LocationID}");
                if (listItem.data.Any())
                    bucketList.Add(listItem.data.FirstOrDefault());
                    
            }
            return new RootAttraction() { data = new List<LocationDetails>(bucketList)};
        }

        public async Task<RootLocation> GetLocation(string search)
        {
            var resultDataList = new List<DataLocation>();

            var UrlSearch = HttpUtility.UrlEncode(search);
            var rootLocation = await _client.GetFromJsonAsync<RootLocation>($"locations/search?location_id=1&limit=30&sort=relevance&offset=0&lang=en_US&currency=USD&units=km&query={UrlSearch}");

            foreach (var item in rootLocation.data)
            {
                if (item.result_type == "things_to_do" || item.result_type == "lodging" || item.result_type == "activities")
                {
                    if (item.result_object.address_obj.country == "United States")
                    {
                        resultDataList.Add(item);
                    }
                }
            }
            return new RootLocation() { data = new List<DataLocation>(resultDataList) };
        }

        public async Task<IEnumerable<RootLocation>> GetTwoLocations(List<string> search)
        {
            var resultList = new List<RootLocation>();
            var resultDataList = new List<DataLocation>();
            var rand = new Random();
            var lastSuccessfulSearch = "";
            var badSearch = "";
            var count = 0;


            while (resultList.Count < 2 && count < 100)
            {
                var result = search[rand.Next(search.Count())];
                if (lastSuccessfulSearch != result && badSearch != result)
                {  
                    var UrlSearch = HttpUtility.UrlEncode(result);
                    var rootLocation = await _client.GetFromJsonAsync<RootLocation>($"locations/search?location_id=1&limit=30&sort=relevance&offset=0&lang=en_US&currency=USD&units=km&query={UrlSearch}");
                    foreach (var item in rootLocation.data)
                    {
                        if (item.result_type == "things_to_do" || item.result_type == "lodging" || item.result_type == "activities")
                        { 
                            if(item.result_object.address_obj.country == "United States")
                            {
                                resultDataList.Add(item);
                            }
                        }
                    }
                    if (resultDataList.Count() >= 3)
                    {
                        resultList.Add(new RootLocation() { data = new List<DataLocation>(resultDataList) });
                        lastSuccessfulSearch = result;
                    }
                    else
                    {
                        badSearch = result;
                    }
                    resultDataList = new List<DataLocation>();
                }

                count++;
            }
            if (count >= 100)
                return new List<RootLocation>();

            return resultList;
        }
        public List<string> QuestionaireSelector(Questionaire questionaire)
        {
            var activeCheckList = new List<string>();

            activeCheckList.Add(questionaire.Answer1);
            activeCheckList.Add(questionaire.Answer2);
            activeCheckList.Add(questionaire.Answer3);
            if (questionaire.Hiking)
                activeCheckList.Add(nameof(questionaire.Hiking));
            if (questionaire.Museum)
                activeCheckList.Add(nameof(questionaire.Museum));
            if (questionaire.AmusementPark)
                activeCheckList.Add(nameof(questionaire.AmusementPark));
            if (questionaire.Concert)
                activeCheckList.Add(nameof(questionaire.Concert));
            if (questionaire.Fishing)
                activeCheckList.Add(nameof(questionaire.Fishing));
            if (questionaire.Shopping)
                activeCheckList.Add(nameof(questionaire.Shopping));

            return activeCheckList;
        }
    }
}
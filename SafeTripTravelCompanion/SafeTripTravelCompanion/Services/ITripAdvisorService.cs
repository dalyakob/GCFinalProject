using SafeTripTravelCompanion.Models.DataBase;
using SafeTripTravelCompanion.Models.TripAdvisor.Attraction;
using SafeTripTravelCompanion.Models.TripAdvisor.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public interface ITripAdvisorService
    {
        Task<RootLocation> GetLocation(string search);
        Task<RootAttraction> Get(int id);
        Task<RootAttraction> GetBucketList(List<BucketList> bucketListID);
        Task<IEnumerable<RootLocation>> GetTwoLocations(List<string> search);
        List<string> QuestionaireSelector(Questionaire questionaire);


    }
}

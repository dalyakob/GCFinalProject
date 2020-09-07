using SafeTripTravelCompanion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public interface ICovidTrackingService
    {
        Task<IEnumerable<CovidTracking>> GetState(string state);
        Task<double> GetCovidRate(string state);
        Task<int> FindPopulation(string state);

        string ConvertStateFromAbv(string stateAbv);
    }
}

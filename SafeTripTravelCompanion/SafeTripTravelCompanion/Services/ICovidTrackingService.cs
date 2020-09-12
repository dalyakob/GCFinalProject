using SafeTripTravelCompanion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public interface ICovidTrackingService
    {
        Task<double> GetCovidRate(string state);
        Task<int> FindPopulation(string state);

        string ConvertState(string stateAbv);
    }
}

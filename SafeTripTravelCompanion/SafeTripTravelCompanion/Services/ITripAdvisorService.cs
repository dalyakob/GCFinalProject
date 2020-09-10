using SafeTripTravelCompanion.Models.TripAdvisor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public interface ITripAdvisorService
    {
        Task<TripAdvisor> GetLocation(string search);
        Task<TripAdvisor> Get(int id);
    }
}

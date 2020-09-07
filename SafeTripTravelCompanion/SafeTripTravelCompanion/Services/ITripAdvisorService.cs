using SafeTripTravelCompanion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Services
{
    public interface ITripAdvisorService
    {
        Task<IEnumerable<TripAdvisor>> GetAll();
        Task<TripAdvisor> Get(int id);
    }
}

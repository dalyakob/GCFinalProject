using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Profiles.Any())
            {
                context.SaveChanges();

            }
        }
    }
}

﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeTripTravelCompanion.Models.DataBase;

namespace SafeTripTravelCompanion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<BucketList> BucketLists { get; set; }

        public DbSet<Questionaire> Questionaire { get; set; }
    }
}

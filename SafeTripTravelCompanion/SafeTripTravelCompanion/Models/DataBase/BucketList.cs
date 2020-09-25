using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.DataBase
{
    public class BucketList
    {
        public int BucketListId { get; set; }

        [Required]
        [StringLength(30)]
        public string LocationID { get; set; }

        public IdentityUser User { get; set; }
    }
}

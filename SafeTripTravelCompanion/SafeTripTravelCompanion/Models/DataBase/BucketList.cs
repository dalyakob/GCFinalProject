﻿using System;
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
        public string LocationID { get; set; }
    }
}
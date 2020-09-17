using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.DataBase
{
    public class Questionaire
    {
        public int QuestionaireID { get; set; }
        [Required]
        public string Answer1 { get; set; }
        [Required]
        public string Answer2 { get; set; }
        [Required]
        public string Answer3 { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafeTripTravelCompanion.Models.DataBase
{
    public class Questionaire
    {
        public List<string> Checklist { get; set; }
        
        public int QuestionaireID { get; set; }
        [Required]
        public string Answer1 { get; set; }
        [Required]
        public string Answer2 { get; set; }
        [Required]
        public string Answer3 { get; set; }

        //public bool Museum { get; set; }
        
        //public bool Hiking { get; set; }

        //public bool Shopping { get; set; }

        //public bool Fishing { get; set; }

        //[Display (Name = "Amusement Park")]
        //public bool AmusementPark {get; set;}

        //public bool Concert { get; set; }
    }
}

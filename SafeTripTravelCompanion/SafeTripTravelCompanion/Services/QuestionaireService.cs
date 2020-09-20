using System;
using SafeTripTravelCompanion.Models.DataBase;
using System.Collections.Generic;

namespace SafeTripTravelCompanion.Services
{
    public class QuestionaireService : IQuestionaireService
    {
        public List<string> GetChecklist()
        {
            return new List<string>
            {
                "Museum",
                "Hiking",
                "Shopping",
                "Fishing",
                "Amusement Park",
                "Concert"
            };
        }

        public List<string> QuestionaireSelector(Questionaire questionaire)
        {
            return null;
            //var randomizer = new Random(questionaire.Checklist.Count);

            //var activeChecklist = new List<string>();
            
            //activeChecklist.Add(questionaire.Checklist[randomizer.Next()]);

            //randomizer = new Random(3);
            //switch (randomizer.Next())
            //{
            //    case 0:
            //        activeChecklist.Add(questionaire.Answer1);
            //        break;
            //    case 1:
            //        activeChecklist.Add(questionaire.Answer2);
            //        break;
            //    case 2:
            //        activeChecklist.Add(questionaire.Answer3);
            //        break;
            //    default:
            //        break;
            //}

            //return activeChecklist;
        }
    }
}

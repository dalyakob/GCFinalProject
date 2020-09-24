using System;
using SafeTripTravelCompanion.Models.DataBase;
using System.Collections.Generic;

namespace SafeTripTravelCompanion.Services
{
    public class QuestionaireService : IQuestionaireService
    {

        public List<string> QuestionaireSelector(Questionaire questionaire)
        {
            var activeChecklist = new List<string>();
            var random = new Random();
            while(activeChecklist.Count < 2)
            {
                switch (random.Next(9))
                {
                    case 0:
                        activeChecklist.Add(questionaire.Answer1);
                        break;
                    case 1:
                        activeChecklist.Add(questionaire.Answer2);
                        break;
                    case 2:
                        activeChecklist.Add(questionaire.Answer3);
                        break;
                    case 3:
                        if (questionaire.Hiking)
                            activeChecklist.Add(nameof(questionaire.Hiking));
                        break;
                    case 4:
                        if (questionaire.Museum)
                            activeChecklist.Add(nameof(questionaire.Museum));
                        break;
                    case 5:
                        if (questionaire.Concert)
                            activeChecklist.Add(nameof(questionaire.Concert));
                        break;
                    case 6:
                        if (questionaire.Fishing)
                            activeChecklist.Add(nameof(questionaire.Fishing));
                        break;
                    case 7:
                        if (questionaire.AmusementPark)
                            activeChecklist.Add(nameof(questionaire.AmusementPark));
                        break;
                    case 8:
                        if (questionaire.Shopping)
                            activeChecklist.Add(nameof(questionaire.Shopping));
                        break;
                    default:
                        break;
                }
            }

            return activeChecklist;
        }
    }
}

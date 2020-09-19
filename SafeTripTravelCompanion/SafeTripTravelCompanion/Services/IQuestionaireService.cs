using System;
using SafeTripTravelCompanion.Models.DataBase;
using System.Collections.Generic;

namespace SafeTripTravelCompanion.Services
{
    public interface IQuestionaireService
    {
        public List<string> GetChecklist();
        public List<string> QuestionaireSelector(Questionaire questionaire);
    }
}

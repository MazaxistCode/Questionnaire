using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    public class AnswerSurvey
    {
        public int Id { get; set; }
        public int? SurveyId { get; set; }
        public Survey Survey { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    public class AnswerQuestion
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public Question Question { get; set; }
        public int? AnswerId { get; set; }
        public Answer Answer { get; set; }
        public int? AnswerSurveyId { get; set; }
        public AnswerSurvey AnswerSurvey { get; set; }
    }
}

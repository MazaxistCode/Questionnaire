using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}

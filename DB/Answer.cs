using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    public class Answer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTrue { get; set; } = false;
        public int? QuestionId { get; set; }
        public Question Question { get; set; }
    }
}

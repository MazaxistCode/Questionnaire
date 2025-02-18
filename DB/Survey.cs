using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    public class Survey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ball { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}

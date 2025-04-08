using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс таблицы AnswerSurveies в БД
    /// </summary>
    public class AnswerSurvey
    {
        /// <summary>
        /// Id ответа на опрос
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id опроса
        /// </summary>
        public int? SurveyId { get; set; }
        /// <summary>
        /// Опрос
        /// </summary>
        public Survey Survey { get; set; }
        /// <summary>
        /// Id пользователя
        /// </summary>
        public int? UserId { get; set; }
        /// <summary>
        /// Пользователь
        /// </summary>
        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс таблицы Questions в БД
    /// </summary>
    public class Question
    {
        /// <summary>
        /// Id вопроса
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя вопроса
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Id опроса
        /// </summary>
        public int? SurveyId { get; set; }
        /// <summary>
        /// Опрос
        /// </summary>
        public Survey Survey { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс таблицы Answers в БД
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Id ответа
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// имя ответа
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// балл ответа
        /// </summary>
        public int Ball { get; set; }
        /// <summary>
        /// Id вопроса
        /// </summary>
        public int? QuestionId { get; set; }
        /// <summary>
        /// Вопрос
        /// </summary>
        public Question Question { get; set; }
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

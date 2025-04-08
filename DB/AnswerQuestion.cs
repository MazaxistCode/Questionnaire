using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс таблицы AnswerQuestions в БД
    /// </summary>
    public class AnswerQuestion
    {
        /// <summary>
        /// Id ответа на вопрос
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id вопроса
        /// </summary>
        public int? QuestionId { get; set; }
        /// <summary>
        /// Вопрос
        /// </summary>
        public Question Question { get; set; }
        /// <summary>
        /// Id ответа
        /// </summary>
        public int? AnswerId { get; set; }
        /// <summary>
        /// Ответ
        /// </summary>
        public Answer Answer { get; set; }
        /// <summary>
        /// Id ответа на опрос
        /// </summary>
        public int? AnswerSurveyId { get; set; }
        /// <summary>
        /// Ответ на опрос
        /// </summary>
        public AnswerSurvey AnswerSurvey { get; set; }
    }
}

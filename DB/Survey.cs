using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс таблицы Surveies в БД
    /// </summary>
    public class Survey
    {
        /// <summary>
        /// Id опроса
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя опроса
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Баллы за опрос
        /// </summary>
        public int Ball { get; set; }
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

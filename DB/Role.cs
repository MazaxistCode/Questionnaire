using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс таблицы Roles в БД
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Id роли
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Имя роли
        /// </summary>
        public string Name { get; set; }
    }
}

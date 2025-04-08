using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire.DB
{
    /// <summary>
    /// Класс контекста БД
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Таблица Users
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Таблица Roles
        /// </summary>
        public DbSet<Role> Roles { get; set; }
        /// <summary>
        /// Таблица Surveies
        /// </summary>
        public DbSet<Survey> Surveies { get; set; }
        /// <summary>
        /// Таблица Questions
        /// </summary>
        public DbSet<Question> Questions { get; set; }
        /// <summary>
        /// Таблица Answers
        /// </summary>
        public DbSet<Answer> Answers { get; set; }
        /// <summary>
        /// Таблица AnswerSurveies
        /// </summary>
        public DbSet<AnswerSurvey> AnswerSurveies { get; set; }
        /// <summary>
        /// Таблица AnswerQuestions
        /// </summary>
        public DbSet<AnswerQuestion> AnswerQuestions { get; set; }
        /// <summary>
        /// Конструктор контекста
        /// </summary>
        public Context() => Database.EnsureCreated();
        /// <summary>
        /// Конфигуратор контекста
        /// </summary>
        /// <param name="optionsBuilder">Параметры настройки контекста</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "DB").Replace("bin\\Release\\net9.0-windows", "DB") + "DB.mdf"};Integrated Security=True;");
        }
    }
}

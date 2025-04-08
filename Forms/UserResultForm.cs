using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Questionnaire.DB;

namespace Questionnaire.Forms
{
    /// <summary>
    /// Класс формы результата опроса
    /// </summary>
    public partial class UserResultForm : Form
    {
        /// <summary>
        /// Конструктор формы результата опроса
        /// </summary>
        /// <param name="surveyName">Имя пройденного опроса</param>
        /// <param name="userEmail">Почта авторизованного пользователя</param>
        public UserResultForm(string surveyName, string userEmail)
        {
            using(Context context = new())
            {
                User = context.Users.First(user => user.Email == userEmail);
                Survey = context.Surveies.First(survey => survey.Name == surveyName);
                AnswerSurvey = context.AnswerSurveies.First(answerSurvey => answerSurvey.UserId == User.Id && answerSurvey.SurveyId == Survey.Id);
                answerQuestions = context.AnswerQuestions.Where(answerQuestion => answerQuestion.AnswerSurveyId == AnswerSurvey.Id).ToArray();
                foreach (var answerQuestion in answerQuestions)
                    answers.Add(context.Answers.First(answer => answer.Id == answerQuestion.AnswerId));
            }
            InitializeComponent();
        }
        /// <summary>
        /// Пользователь, который прошёл опрос
        /// </summary>
        User User { get; set; }
        /// <summary>
        /// Пройденный опрос
        /// </summary>
        Survey Survey { get; set; }
        /// <summary>
        /// Ответ опроса
        /// </summary>
        AnswerSurvey AnswerSurvey { get; set; }
        /// <summary>
        /// Ответы на вопросы пройденного пользователем опроса
        /// </summary>
        AnswerQuestion[] answerQuestions { get; set; }
        /// <summary>
        /// Ответы опроса
        /// </summary>
        List<Answer> answers { get; set; } = [];

        /// <summary>
        /// Загрузчик формы результата опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void UserResultForm_Load(object sender, EventArgs e)
        {
            SurveyNameLabel.Text = Survey.Name;
            SurveyBallLabel.Text = $"{Survey.Ball}";
            ResultBar.Maximum = Survey.Ball;
            int ball = 0;
            foreach (var answer in answers)
                ball += answer.Ball;
            ResultBar.Value = ball;
            UserBallLabel.Text = $"{ball}";
        }
        /// <summary>
        /// Кнопка перехода в главное меню
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

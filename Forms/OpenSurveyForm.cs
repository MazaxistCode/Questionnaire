using Questionnaire.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire.Forms
{
    /// <summary>
    /// Класс формы прохождения опроса
    /// </summary>
    public partial class OpenSurveyForm : Form
    {
        /// <summary>
        /// Конструктор формы прохождения опроса
        /// </summary>
        /// <param name="surveyName"></param>
        /// <param name="userEmail"></param>
        public OpenSurveyForm(string surveyName, string userEmail)
        {
            using (Context context = new())
            {
                User = context.Users.First(user => user.Email == userEmail);
                Survey = context.Surveies.First(survey => survey.Name == surveyName);
                questions = context.Questions.Where(question => question.SurveyId == Survey.Id).ToArray();
                answers = context.Answers.Where(answer => answer.SurveyId == Survey.Id).ToArray();
                AnswerSurvey = new() { Survey = Survey, User = User };
                answerQuestions = new AnswerQuestion[questions.Length];
                for (int i = 0; i < questions.Length; i++)
                    answerQuestions[i] = new() { AnswerSurvey = AnswerSurvey, Question = questions[i] };
            }
            InitializeComponent();
        }
        /// <summary>
        /// Пользователь, проходящий опрос
        /// </summary>
        User User { get; set; }
        /// <summary>
        /// Опрос, который проходит пользователь
        /// </summary>
        Survey Survey { get; set; }
        /// <summary>
        /// Вопросы опроса
        /// </summary>
        Question[] questions { get; set; }
        /// <summary>
        /// Выбранный вопрос
        /// </summary>
        Question? QuestionOn { get; set; }
        /// <summary>
        /// Ответы опроса
        /// </summary>
        Answer[] answers { get; set; }
        /// <summary>
        /// Ответ на опрос
        /// </summary>
        AnswerSurvey AnswerSurvey { get; set; }
        /// <summary>
        /// Ответы на вопросы опроса
        /// </summary>
        AnswerQuestion[] answerQuestions { get; set; }

        /// <summary>
        /// Загрузчик формы прохождения опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void OpenSurveyForm_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                QuestionsListBox.Items.Clear();
                foreach (Question question in questions)
                    QuestionsListBox.Items.Add(question.Name);
            }

        }

        /// <summary>
        /// Кнопка записи ответа на вопрос
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (QuestionOn != null && AnswersListBox.Text != string.Empty)
            {
                Answer answer = answers.First(answer => answer.Name == AnswersListBox.Text && answer.QuestionId == QuestionOn.Id);
                answerQuestions[Array.IndexOf(answerQuestions, answerQuestions.First(answerQuestion => answerQuestion.Question.Id == QuestionOn.Id))].Answer = answer;
                QuestionCountLabel.Text = $"{answerQuestions.Count(answer => answer.Answer is not null)} | {answerQuestions.Length}";
                int index = QuestionsListBox.SelectedIndex;
                if (index < QuestionsListBox.Items.Count - 1)
                {
                    QuestionsListBox.SelectedIndex = index + 1;
                    QuestionsListBox_SelectedIndexChanged(sender, e);
                }
            }
        }

        /// <summary>
        /// Нажатие на список вопросов
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionsListBox.Text != string.Empty)
            {
                QuestionOn = questions.First(question => question.Name == QuestionsListBox.Text);
                QuestionLabel.Text = QuestionsListBox.Text;
                AnswersListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.QuestionId == QuestionOn.Id))
                    AnswersListBox.Items.Add(answer.Name);
            }
        }

        /// <summary>
        /// Кнопка завершения прохождения
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void EndButton_Click(object sender, EventArgs e)
        {
            using(Context context = new())
            {
                if (!answerQuestions.Any(answerQuestion => answerQuestion.Answer == null))
                {
                    context.AnswerSurveies.Add(new() { Survey = context.Surveies.First(survey => survey.Id == Survey.Id), User = context.Users.First(user => user.Id == User.Id) });
                    context.SaveChanges();
                    AnswerSurvey = context.AnswerSurveies.First(answerSurvey => answerSurvey.SurveyId == Survey.Id && answerSurvey.UserId == User.Id);
                    foreach (var answerQuestion in answerQuestions)
                        context.AnswerQuestions.Add(new()
                        {
                            AnswerSurvey = context.AnswerSurveies.First(answerSurvey => answerSurvey.SurveyId == Survey.Id && answerSurvey.UserId == User.Id),
                            Question = context.Questions.First(question => question.Id == answerQuestion.Question.Id),
                            Answer = context.Answers.First(answer => answer.Id == answerQuestion.Answer.Id)
                        });
                    context.SaveChanges();
                    UserResultForm form = new(Survey.Name, User.Email);
                    Visible = false;
                    form.Location = Location;
                    form.ShowDialog();
                    Location = form.Location;
                    Visible = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ответьте на все вопросы.");
                }
            }
        }
    }
}

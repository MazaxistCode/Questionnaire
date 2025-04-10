﻿using Questionnaire.DB;
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
    /// Класс формы меню опросов пользователя
    /// </summary>
    public partial class UserSurveiesForm : Form
    {
        /// <summary>
        /// Конструктор формы меню опросов пользователя
        /// </summary>
        /// <param name="email">Почта авторизированного пользователя</param>
        /// <param name="isAdmin">Админ ли зашёл в форму</param>
        public UserSurveiesForm(string email, bool isAdmin = false)
        {
            this.isAdmin = isAdmin;
            UserEmail = email;
            InitializeComponent();
        }
        /// <summary>
        /// Админ ли зашёл в форму
        /// </summary>
        bool isAdmin;
        /// <summary>
        /// Почта авторизированного пользователя
        /// </summary>
        private string UserEmail { get; set; }

        /// <summary>
        /// Загрузчик формы меню опросов пользователя
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void UserSurveysForm_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                if (isAdmin)
                {
                    CreateSurveyButton.Visible = false;
                    EditSurveyButton.Visible = false;
                    foreach (var survey in context.Surveies)
                    {
                        SurveiesListBox.Items.Add(survey.Name);
                    }
                }
                else
                {
                    foreach (var survey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
                    {
                        SurveiesListBox.Items.Add(survey.Name);
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка поиска опросов пользователя
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies.Where(survey => survey.Name.Contains(SearchBox.Text) && survey.User.Email == UserEmail))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка создания опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            CreateSurveyForm form = new(UserEmail);
            Visible = false;
            form.Location = Location;
            form.ShowDialog();
            Location = form.Location;
            Visible = true;
            using (Context context = new())
            {
                SearchBox.Text = string.Empty;
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка редактирования опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void EditSurveyButton_Click(object sender, EventArgs e)
        {
            if (SurveiesListBox.Text != string.Empty)
            {
                CreateSurveyForm form;
                using (Context context = new())
                {
                    form = new(UserEmail, context.Surveies.First(survey => survey.Name == SurveiesListBox.Text));
                }
                Visible = false;
                form.Location = Location;
                form.ShowDialog();
                Location = form.Location;
                Visible = true;
                using (Context context = new())
                {
                    SearchBox.Text = string.Empty;
                    SurveiesListBox.Items.Clear();
                    foreach (var survey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
                    {
                        SurveiesListBox.Items.Add(survey.Name);
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка удаления опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void DeleteSurveyButton_Click(object sender, EventArgs e)
        {
            if (SurveiesListBox.Text != string.Empty)
            {
                using (Context context = new())
                {
                    Survey survey = context.Surveies.First(survey => survey.Name == SurveiesListBox.Text);
                    List<Question> questions = context.Questions.Where(question => question.SurveyId == survey.Id).ToList();
                    List<Answer> answers = context.Answers.Where(answer => answer.SurveyId == survey.Id).ToList();
                    AnswerSurvey[] answerSurveys = context.AnswerSurveies.Where(answerSurbey => answerSurbey.SurveyId == survey.Id).ToArray();
                    List<AnswerQuestion> answerQuestions = [];
                    foreach(var answerSurvey in answerSurveys)
                        answerQuestions.AddRange(context.AnswerQuestions.Where(answerQuestion => answerQuestion.AnswerSurveyId == answerSurvey.Id).ToList());
                    context.AnswerQuestions.RemoveRange(answerQuestions);
                    context.AnswerSurveies.RemoveRange(answerSurveys);
                    context.Answers.RemoveRange(answers);
                    context.Questions.RemoveRange(questions);
                    context.Surveies.RemoveRange(survey);
                    context.SaveChanges();
                    SearchBox.Text = string.Empty;
                    SurveiesListBox.Items.Clear();
                    if (!isAdmin)
                    {
                        foreach (var userSurvey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
                        {
                            SurveiesListBox.Items.Add(userSurvey.Name);
                        }
                    }
                    else
                    {
                        foreach (var userSurvey in context.Surveies)
                        {
                            SurveiesListBox.Items.Add(userSurvey.Name);
                        }
                    }
                }
            }
        }
    }
}

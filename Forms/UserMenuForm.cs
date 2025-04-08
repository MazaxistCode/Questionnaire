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
    /// Класс формы главного меню
    /// </summary>
    public partial class UserMenuForm : Form
    {
        /// <summary>
        /// Конструктор формы главного меню
        /// </summary>
        /// <param name="email">Почта авторизованного пользователя</param>
        public UserMenuForm(string email)
        {
            UserEmail = email;
            InitializeComponent();
        }
        /// <summary>
        /// Почта авторизованного пользователя
        /// </summary>
        private string UserEmail { get; set; }

        /// <summary>
        /// Загрузчик формы главного меню
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void UserMenu_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                foreach (var survey in context.Surveies)
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка поиска опросов
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies.Where(survey => survey.Name.Contains(SearchBox.Text)))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка личного кабинета
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm form = new(UserEmail);
            Visible = false;
            form.Location = new() { X = Location.X + 87, Y = Location.Y + 75 };
            form.ShowDialog();
            if (form.AvatarPictureBox.Image != null)
                form.AvatarPictureBox.Image.Dispose();
            form.AvatarPictureBox.Image = null;
            Location = new() { X = form.Location.X - 87, Y = form.Location.Y - 75 };
            Visible = true;
        }

        /// <summary>
        /// Кнопка создания опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            CreateSurveyForm createSurveyForm = new(UserEmail);
            Visible = false;
            createSurveyForm.Location = Location;
            createSurveyForm.ShowDialog();
            UserSurveiesForm userSurveiesForm = new(UserEmail);
            userSurveiesForm.Location = createSurveyForm.Location;
            userSurveiesForm.ShowDialog();
            Location = userSurveiesForm.Location;
            Visible = true;
            using (Context context = new())
            {
                SearchBox.Text = string.Empty;
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies)
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка меню опросов пользователя
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void UserSurveiesButton_Click(object sender, EventArgs e)
        {
            UserSurveiesForm userSurveiesForm = new(UserEmail);
            Visible = false;
            userSurveiesForm.Location = Location;
            userSurveiesForm.ShowDialog();
            Location = userSurveiesForm.Location;
            Visible = true;
            using (Context context = new())
            {
                SearchBox.Text = string.Empty;
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies)
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка прохождения опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void OpenSurveyButton_Click(object sender, EventArgs e)
        {
            if (SurveiesListBox.Text != string.Empty)
            {
                using(Context context = new())
                {
                    User user = context.Users.First(user => user.Email == UserEmail);
                    Survey survey = context.Surveies.First(survey => survey.Name == SurveiesListBox.Text);
                    if(!context.AnswerSurveies.Any(answerSurvey => answerSurvey.UserId == user.Id && answerSurvey.SurveyId == survey.Id))
                    {
                        OpenSurveyForm openSurveyForm = new(SurveiesListBox.Text, UserEmail);
                        Visible = false;
                        openSurveyForm.Location = Location;
                        openSurveyForm.ShowDialog();
                        Location = openSurveyForm.Location;
                        Visible = true;
                    }
                    else
                    {
                        UserResultForm form = new(survey.Name, user.Email);
                        Visible = false;
                        form.Location = Location;
                        form.ShowDialog();
                        Location = form.Location;
                        Visible = true;
                    }
                }
            }
        }
    }
}

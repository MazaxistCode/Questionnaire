
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using Questionnaire.DB;
using Questionnaire.Forms;

namespace Questionnaire.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm(bool isTest = false, bool createDB = false, string email = "admin@gmail.com")
        {
            UserEmail = email;
            this.isTest = isTest;
            this.createDB = createDB;
            InitializeComponent();
        }
        private bool isTest;
        private bool createDB;
        private string UserEmail { get; set; }
        private void StartForm_Load(object sender, EventArgs e)
        {
            StartDB();
            if (isTest)
            {
                UserMenuForm form = new(UserEmail);
                Visible = false;
                form.ShowDialog();
                Close();
            }
        }
        private void StartDB()
        {
            if (createDB)
            {
                using (Context context = new())
                {
                    context.Users.RemoveRange(context.Users);
                    context.Roles.RemoveRange(context.Roles);
                    context.Surveies.RemoveRange(context.Surveies);
                    context.Questions.RemoveRange(context.Questions);
                    context.Answers.RemoveRange(context.Answers);
                    context.AnswerSurveies.RemoveRange(context.AnswerSurveies);
                    context.AnswerQuestions.RemoveRange(context.AnswerQuestions);
                    context.SaveChanges();
                }
                using (Context context = new())
                {
                    Role adminRole = new() { Name = "Admin" };
                    Role userRole = new() { Name = "User" };
                    context.Roles.AddRange(adminRole, userRole);
                    context.SaveChanges();

                    User adminUser = new() { Login = "Admin", Email = "admin@gmail.com", Password = "Admin".GetHash(), Role = adminRole };
                    User user1 = new() { Login = "12341234", Email = "user@gmail.com", Password = "1234".GetHash(), Role = userRole };
                    User userqgc = new() { Login = "qgc", Email = "qgc.cor@bk.ru", Password = "qgc".GetHash(), Role = userRole };
                    context.Users.AddRange(adminUser, user1, userqgc);
                    context.SaveChanges();

                    Survey survey1 = new() { Name = "quest 1", User = user1 };
                    context.Surveies.AddRange(survey1);
                    context.SaveChanges();

                    Question question1_1 = new() { Name = "1 == 1", Survey = survey1 };
                    context.Questions.AddRange(question1_1);
                    context.SaveChanges();

                    Answer answer1_1_1 = new() { Name = "T", IsTrue = true, Question = question1_1, Survey = survey1 };
                    Answer answer1_1_2 = new() { Name = "F", Question = question1_1, Survey = survey1 };
                    Answer answer1_1_3 = new() { Name = "NS", Question = question1_1, Survey = survey1 };
                    context.Answers.AddRange(answer1_1_1, answer1_1_2, answer1_1_3);
                    context.SaveChanges();

                    Question question1_2 = new() { Name = "1 == 2", Survey = survey1 };
                    context.Questions.AddRange(question1_2);
                    context.SaveChanges();

                    Answer answer1_2_1 = new() { Name = "T", Question = question1_2, Survey = survey1 };
                    Answer answer1_2_2 = new() { Name = "F", IsTrue = true, Question = question1_2, Survey = survey1 };
                    Answer answer1_2_3 = new() { Name = "NS", Question = question1_2, Survey = survey1 };
                    context.Answers.AddRange(answer1_2_1, answer1_2_2, answer1_2_3);
                    context.SaveChanges();

                    Question question1_3 = new() { Name = "a == b", Survey = survey1 };
                    context.Questions.AddRange(question1_3);
                    context.SaveChanges();

                    Answer answer1_3_1 = new() { Name = "T", Question = question1_3, Survey = survey1 };
                    Answer answer1_3_2 = new() { Name = "F", Question = question1_3, Survey = survey1 };
                    Answer answer1_3_3 = new() { Name = "NS", IsTrue = true, Question = question1_3, Survey = survey1 };
                    context.Answers.AddRange(answer1_3_1, answer1_3_2, answer1_3_3);
                    context.SaveChanges();

                    Answer empty = new() { Name = "Ќе найден" };
                    context.Answers.Add(empty);
                    context.SaveChanges();
                }
                using (Context context = new())
                {
                    User user2 = new() { Login = "78907890", Email = "1234@gmail.com", Password = "7890".GetHash(), Role = context.Roles.Where(role => role.Name == "User").First() };
                    context.Users.AddRange(user2);

                    string thisIdSurvay = "quest 1";
                    Survey survayAnswer = context.Surveies.Where(survay => survay.Name == thisIdSurvay).First();
                    List<Question> questions = context.Questions.Where(quest => quest.Survey.Id == survayAnswer.Id).ToList();
                    List<string> usersAnswers = new() { "T", "T", "NS" };
                    List<Answer> answers = new();
                    for (int i = 0; i < questions.Count; i++)
                    {
                        answers.Add(context.Answers.Where(answer => answer.Name == usersAnswers[i] && answer.Question.Id == questions[i].Id).First());
                    }

                    AnswerSurvey answerSurvey = new() { Survey = survayAnswer, User = user2 };
                    context.AnswerSurveies.AddRange(answerSurvey);

                    List<AnswerQuestion> answerQuestions = [];
                    for (int i = 0; i < questions.Count && i < answers.Count; i++)
                    {
                        context.AnswerQuestions.Add(new() { Question = questions[i], Answer = answers[i], AnswerSurvey = answerSurvey });
                    }
                    context.SaveChanges();
                }
            }
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PassBox.Text;
            if (login == string.Empty || password == string.Empty)
                MessageBox.Show("зполните все пол€");
            else
            {
                using Context context = new Context();
                if (context.Users.Where(user => user.Login == login || user.Email == login).Any())
                {
                    if (context.Users.Where(user => user.Password == password.GetHash()).Any())
                    {
                        UserMenuForm form = new(context.Users.Where(user => user.Login == login).First().Email);
                        Visible = false;
                        form.ShowDialog();
                        Close();
                    }
                    else
                        MessageBox.Show("дл€ авторизации - впешите правильный пароль.");
                }
                else
                    MessageBox.Show("вы не зарегистрированы");
            }
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            LogOnForm form = new();
            Visible = false;
            form.Location = Location;
            form.LoginBox.Text = LoginBox.Text;
            form.ShowDialog();
            Location = form.Location;
            Visible = true;
            if (form.isFinish)
                LoginBox.Text = form.LoginBox.Text;
            PassBox.Text = string.Empty;
        }
    }
}
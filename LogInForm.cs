
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Questionnaire
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        // експеримент с фреймами, а именно с передачей данных, передавал, как всю форму, так и как тут... текст.

        //public StartForm(string text)
        //{
        //    InitializeComponent();
        //    Show();
        //    label1.Text = text;
        //}
        public (List<string> email, List<string> password, List<int> code) SendEmail = new([], [], []);

        // сделал всё в лоадере, чтобы не добавлять лишнюю кнопку, лень :P
        private void StartForm_Load(object sender, EventArgs e)
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

                User adminUser = new() { Login = "Admin", Email = "admin@gmail.com", Password = GetMD5Hash("Admin"), Role = adminRole };
                User user1 = new() { Login = "12341234", Email = "user@gmail.com", Password = GetMD5Hash("1234"), Role = userRole };
                context.Users.AddRange(adminUser, user1);
                context.SaveChanges();

                Survey survey1 = new() { Name = "quest 1", User = user1 };
                context.Surveies.AddRange(survey1);
                context.SaveChanges();

                Question question1_1 = new() { Name = "1 == 1", Survey = survey1 };
                context.Questions.AddRange(question1_1);
                context.SaveChanges();

                Answer answer1_1_1 = new() { Name = "T", IsTrue = true, Question = question1_1 };
                Answer answer1_1_2 = new() { Name = "F", Question = question1_1 };
                Answer answer1_1_3 = new() { Name = "NS", Question = question1_1 };
                context.Answers.AddRange(answer1_1_1, answer1_1_2, answer1_1_3);
                context.SaveChanges();

                Question question1_2 = new() { Name = "1 == 2", Survey = survey1 };
                context.Questions.AddRange(question1_2);
                context.SaveChanges();

                Answer answer1_2_1 = new() { Name = "T", Question = question1_2 };
                Answer answer1_2_2 = new() { Name = "F", IsTrue = true, Question = question1_2 };
                Answer answer1_2_3 = new() { Name = "NS", Question = question1_2 };
                context.Answers.AddRange(answer1_2_1, answer1_2_2, answer1_2_3);
                context.SaveChanges();

                Question question1_3 = new() { Name = "a == b", Survey = survey1 };
                context.Questions.AddRange(question1_3);
                context.SaveChanges();

                Answer answer1_3_1 = new() { Name = "T", Question = question1_3 };
                Answer answer1_3_2 = new() { Name = "F", Question = question1_3 };
                Answer answer1_3_3 = new() { Name = "NS", IsTrue = true, Question = question1_3 };
                context.Answers.AddRange(answer1_3_1, answer1_3_2, answer1_3_3);
                context.SaveChanges();
            }
            using (Context context = new())
            {
                User user2 = new() { Login = "78907890", Email = "1234@gmail.com", Password = GetMD5Hash("7890"), Role = context.Roles.Where(role => role.Name == "User").First() };
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
        // експериментировал с фреймами, типо включение других фреймов, чтобы было)))

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //MessageBox.Show("ok.");
        //    //StartForm form = new StartForm("34534");
        //    //Hide();
        //}

        // експериментировал с хешированием, выводил его вот так, а не через лабели, тут проверял,
        // чтобы при введении разных значений - разный хеш, а при одинаковых - одинаковый

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(GetMD5Hash(textBox1.Text));
        //    //MessageBox.Show(GetMD5Hash(textBox2.Text));
        //}

        // хеширование. взято целиком с инета, пока не важно как работает, главное, что оно вообще работает.
        private static string GetMD5Hash(string text)
        {
            using var hashAlg = MD5.Create();
            byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
            var builder = new StringBuilder(hash.Length * 2);
            for (int i = 0; i < hash.Length; i++)
            {
                builder.Append(hash[i].ToString("X2"));
            }
            return builder.ToString();
        }
        // ленивая регистрация и авторизация, в будущем будет через почту, в разных кнопках, по красоте и т.п. а пока для проверки работы бд сойдёт

        private void InButton_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text;
            string password = passBox.Text;
            if (login == string.Empty || password == string.Empty)
                MessageBox.Show("зполните все поля");
            else
            {
                using Context context = new Context();
                if (context.Users.Where(user => user.Login == login || user.Email == login).Any())
                {
                    if (context.Users.Where(user => user.Password == GetMD5Hash(password)).Any())
                        MessageBox.Show("вы авторизированы.");
                    else
                        MessageBox.Show("для авторизации - впешите правильный пароль.");
                }
                else
                    MessageBox.Show("вы не зарегистрированы");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LogOnForm form = new();
            Visible = false;
            form.Location = Location;
            form.ShowDialog();
            Location = form.Location;
            Visible = true;
            loginBox.Text = form.loginBox.Text;
            passBox.Text = string.Empty;
        }
    }
}
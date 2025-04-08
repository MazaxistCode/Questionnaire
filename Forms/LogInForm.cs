
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

using Questionnaire.DB;
using Questionnaire.Forms;

namespace Questionnaire.Forms
{
    /// <summary>
    /// ����� ����� �����������
    /// </summary>
    public partial class LogInForm : Form
    {
        /// <summary>
        /// ����������� ����� �����������
        /// </summary>
        /// <param name="isTest">���������� �� ������ ���� (���� �� ���������� ���� ����������� � �����������)</param>
        /// <param name="createDB">������������ ��</param>
        /// <param name="email">����� ����������������� ������������</param>
        public LogInForm(bool isTest = false, bool createDB = false, string email = "qgc.cor@bk.ru")
        {
            UserEmail = email;
            this.isTest = isTest;
            this.createDB = createDB;
            InitializeComponent();
        }
        /// <summary>
        /// ���������� ����� (��/���)
        /// </summary>
        private bool isTest;
        /// <summary>
        /// ������������ �� (��/���)
        /// </summary>
        private bool createDB;
        /// <summary>
        /// ����� ����������������� ������������
        /// </summary>
        private string UserEmail { get; set; }
        /// <summary>
        /// ��������� ����� �����������
        /// </summary>
        /// <param name="sender">������ ���������� �������</param>
        /// <param name="e">������ ������</param>
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
        /// <summary>
        /// ����� �� ������������ ��
        /// </summary>
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
                    User userqgc = new() { Login = "qgc", Email = "qgc.cor@bk.ru", Password = "qgc".GetHash(), Role = userRole };
                    context.Users.AddRange(adminUser, userqgc);
                    context.SaveChanges();

                    Survey survey = new() { Name = "��������� � ���� ������� ����?", User = userqgc };
                    Question[] questions =
                    {
                        new() { Name = "��� � ���� ����?", Survey = survey },
                        new() { Name = "� ���� ����� ��� �������?", Survey = survey },
                        new() { Name = "������ �� �� ������ ����� �� ������� �����?", Survey = survey }
                    };
                    Answer[] answers =
                    {
                        new() { Name = "�������", Ball = 10, Question = questions[0], Survey = survey },
                        new() { Name = "������", Ball = 5, Question = questions[0], Survey = survey },
                        new() { Name = "���������", Ball = 3, Question = questions[0], Survey = survey },
                        new() { Name = "������", Ball = 1, Question = questions[0], Survey = survey },
                        new() { Name = "������", Ball = 0, Question = questions[0], Survey = survey },

                        new() { Name = "��������!", Ball = 10, Question = questions[1], Survey = survey },
                        new() { Name = "2", Ball = 4, Question = questions[1], Survey = survey },
                        new() { Name = "3", Ball = 3, Question = questions[1], Survey = survey },
                        new() { Name = "4", Ball = 2, Question = questions[1], Survey = survey },
                        new() { Name = "5 / 4 �� 2", Ball = 1, Question = questions[1], Survey = survey },
                        new() { Name = "���� ����...", Ball = 0, Question = questions[1], Survey = survey },

                        new() { Name = "�������!", Ball = 10, Question = questions[2], Survey = survey },
                        new() { Name = "��", Ball = 5, Question = questions[2], Survey = survey },
                        new() { Name = "������� ��", Ball = 4, Question = questions[2], Survey = survey },
                        new() { Name = "�� ����", Ball = 3, Question = questions[2], Survey = survey },
                        new() { Name = "�������� ���", Ball = 2, Question = questions[2], Survey = survey },
                        new() { Name = "���", Ball = 1, Question = questions[2], Survey = survey },
                        new() { Name = "�������!", Ball = 0, Question = questions[2], Survey = survey }
                    };
                    int maxBall = 0;
                    foreach (var question in questions)
                    {
                        int maxBallQuestion = 0;
                        foreach (var answer in answers.Where(answer => answer.Question.Name == question.Name).ToArray())
                        {
                            if (answer.Ball > maxBallQuestion)
                                maxBallQuestion = answer.Ball;
                        }
                        maxBall += maxBallQuestion;
                    }
                    survey.Ball = maxBall;

                    context.Surveies.Add(survey);
                    context.Questions.AddRange(questions);
                    context.Answers.AddRange(answers);
                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// ������ �����������
        /// </summary>
        /// <param name="sender">������ ���������� �������</param>
        /// <param name="e">������ ������</param>
        private void InButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PassBox.Text;
            if (login == string.Empty || password == string.Empty)
                MessageBox.Show("�������� ��� ����");
            else
            {
                using Context context = new Context();
                if (context.Users.Where(user => user.Login == login || user.Email == login).Any())
                {
                    if (context.Users.Where(user => user.Password == password.GetHash()).Any())
                    {
                        if(context.Users.First(user => user.Login == login || user.Email == login).RoleId == context.Roles.First(role => role.Name == "Admin").Id)
                        {
                            UserSurveiesForm form = new(context.Users.Where(user => user.Login == login).First().Email, true);
                            Visible = false;
                            form.ShowDialog();
                            Close();
                        }
                        else
                        {
                            UserMenuForm form = new(context.Users.Where(user => user.Login == login).First().Email);
                            Visible = false;
                            form.ShowDialog();
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("��� ����������� - ������� ���������� ������.");
                }
                else
                    MessageBox.Show("�� �� ����������������");
            }
        }

        /// <summary>
        /// ������ �����������
        /// </summary>
        /// <param name="sender">������ ���������� �������</param>
        /// <param name="e">������ ������</param>
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
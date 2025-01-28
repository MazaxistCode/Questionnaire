
using System.Text;
using System.Security.Cryptography;

namespace Questionnaire
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        // ����������� � ��������, � ������ � ��������� ������, ���������, ��� ��� �����, ��� � ��� ���... �����.

        //public StartForm(string text)
        //{
        //    InitializeComponent();
        //    Show();
        //    label1.Text = text;
        //}

        // ������ �� � �������, ����� �� ��������� ������ ������, ���� :P
        private void StartForm_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                context.Database.EnsureCreated();
                foreach (var role in context.Roles) { context.Roles.Remove(role); }
                foreach (var user in context.Users) { context.Users.Remove(user); }
                foreach (var survey in context.Surveies) { context.Surveies.Remove(survey); }
                foreach (var question in context.Questions) { context.Questions.Remove(question); }
                foreach (var answer in context.Answers) { context.Answers.Remove(answer); }
                foreach (var answerSurvey in context.AnswerSurveies) { context.AnswerSurveies.Remove(answerSurvey); }
                foreach (var questionQuestion in context.AnswerQuestions) { context.AnswerQuestions.Remove(questionQuestion); }
                context.SaveChanges();
            }
            using (Context context = new())
            {
                Role adminRole = new() { Name = "Admin" };
                Role userRole = new() { Name = "User" };
                context.Roles.AddRange(adminRole, userRole);

                User adminUser = new() { Login = "Admin", Email = "admin@gmail.com", Password = GetMD5Hash("Admin"), Role = adminRole };
                User user1 = new() { Login = "12341234", Email = "user@gmail.com", Password = GetMD5Hash("1234"), Role = userRole };
                context.Users.AddRange(adminUser, user1);

                Survey survey1 = new() { Name = "quest 1", User = user1 };
                context.Surveies.AddRange(survey1);

                Question question1_1 = new() { Name = "1 == 1", Survey = survey1 };
                context.Questions.AddRange(question1_1);

                Answer answer1_1_1 = new() { Name = "T", IsTrue = true, Question = question1_1 };
                Answer answer1_1_2 = new() { Name = "F", Question = question1_1 };
                Answer answer1_1_3 = new() { Name = "NS", Question = question1_1 };
                context.Answers.AddRange(answer1_1_1, answer1_1_2, answer1_1_3);

                Question question1_2 = new() { Name = "1 == 2", Survey = survey1 };
                context.Questions.AddRange(question1_2);

                Answer answer1_2_1 = new() { Name = "T", Question = question1_2 };
                Answer answer1_2_2 = new() { Name = "F", IsTrue = true, Question = question1_2 };
                Answer answer1_2_3 = new() { Name = "NS", Question = question1_2 };
                context.Answers.AddRange(answer1_2_1, answer1_2_2, answer1_2_3);

                Question question1_3 = new() { Name = "a == b", Survey = survey1 };
                context.Questions.AddRange(question1_3);

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
            using (Context context = new())
            {
                string text1 = string.Empty;
                foreach (var user in context.Users)
                {
                    text1 +=
                        user.Id + "   " +
                        user.Login + "   " +
                        user.Password + "   " +
                        user.Email + "   "
                        + '\n';
                }
                label1.Text = text1;
                text1 = string.Empty;
                foreach (var user in context.Roles)
                {
                    text1 +=
                        user.Id + "   " +
                        user.Name + "   "
                        + '\n';
                }
                label2.Text = text1;
                text1 = string.Empty;
                foreach (var user in context.Surveies)
                {
                    text1 +=
                        user.Id + "   " +
                        user.Name + "   "
                        + "\n";
                }
                label3.Text = text1;
                text1 = string.Empty;
                foreach (var user in context.Questions)
                {
                    text1 +=
                        user.Id + "   " +
                        user.Name + "   "
                        + "\n";
                }
                label4.Text = text1;
                text1 = string.Empty;
                foreach (var user in context.Answers)
                {
                    text1 +=
                        user.Id + "   " +
                        user.Name + "   " +
                        user.IsTrue + "   "
                        + "\n";
                }
                label5.Text = text1;
                text1 = string.Empty;
                foreach (var user in context.AnswerSurveies)
                {
                    text1 +=
                        user.Id + "   "
                        + "\n";
                }
                label6.Text = text1;
                text1 = string.Empty;
                foreach (var user in context.AnswerQuestions)
                {
                    text1 +=
                        user.Id + "   " +
                        user.AnswerSurvey.Id + "   "
                        + "\n";
                }
                label7.Text = text1;
            }
        }
        // ����������������� � ��������, ���� ��������� ������ �������, ����� ����)))

        //private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    //MessageBox.Show("ok.");
        //    //StartForm form = new StartForm("34534");
        //    //Hide();
        //}

        // ����������������� � ������������, ������� ��� ��� ���, � �� ����� ������, ��� ��������,
        // ����� ��� �������� ������ �������� - ������ ���, � ��� ���������� - ����������

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show(GetMD5Hash(textBox1.Text));
        //    //MessageBox.Show(GetMD5Hash(textBox2.Text));
        //}

        // �����������. ����� ������� � �����, ���� �� ����� ��� ��������, �������, ��� ��� ������ ��������.
        private static string GetMD5Hash(string text) 
        {
            using (var hashAlg = MD5.Create())
            {
                byte[] hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(text));
                var builder = new StringBuilder(hash.Length * 2);
                for (int i = 0; i < hash.Length; i++)
                {
                    builder.Append(hash[i].ToString("X2"));
                }
                return builder.ToString();
            }
        }
        // ������� ����������� � �����������, � ������� ����� ����� �����, � ������ �������, �� ������� � �.�. � ���� ��� �������� ������ �� �����
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
                MessageBox.Show("������� ����� � ������.");
            else {
                using (Context context = new())
                {
                    if (context.Users.Where(user => user.Login == textBox1.Text).Any())
                    {
                        if (context.Users.Where(user => user.Password == GetMD5Hash(textBox2.Text)).Any())
                            MessageBox.Show("�� ��������������");
                        else
                            MessageBox.Show("���� ����� ��� ����������,\n��� ����������� �������� ����� �� ����������,\n� ��� ����������� - ������� ���������� ������");
                    }
                    else
                    {
                        Role role = context.Roles.Where(role => role.Name == "User").First();
                        User newUser = new() { Login = textBox1.Text, Password = GetMD5Hash(textBox2.Text), Role = role, Email = "" };
                        context.Users.Add(newUser);
                        context.SaveChanges();
                        string text = string.Empty;
                        foreach (var user in context.Users)
                        {
                            text +=
                                user.Id + "   " +
                                user.Login + "   " +
                                user.Password + "   " +
                                user.Email + "   "
                                + '\n';
                        }
                        label1.Text = text;
                        MessageBox.Show("�� ����������������");
                    }
                }
            }
        }
    }
}
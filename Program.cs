using Microsoft.EntityFrameworkCore;
using Questionnaire;
using System.Net.Mail;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Questionnaire
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartForm());
        }
    }
}
// ���������� �� (����������) ������ ����� ������� �� �������� � Entity Framework ���� ������ �� ����.........
public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Survey> Surveies { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<AnswerSurvey> AnswerSurveies { get; set; }
    public DbSet<AnswerQuestion> AnswerQuestions { get; set; }
    public Context() => Database.EnsureCreated();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\Questionnaire\DB.mdf;");
    }
}
// ��� ������� �� (����� �������) �� ��� ���� ������������,
// �� ������� ����, �������� ���-������ ���������
// �������� � User Role � RoleId, �� ���� ����, ����� ����
public class User
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public int? RoleId { get; set; }
    public Role Role { get; set; }
}
public class Role
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Survey
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? UserId { get; set; }
    public User User { get; set; }
}
public class Question
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? SurveyId { get; set; }
    public Survey Survey { get; set; }
}
public class Answer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsTrue { get; set; } = false;
    public int? QuestionId { get; set; }
    public Question Question { get; set; }
}
public class AnswerSurvey
{
    public int Id { get; set; }
    public int? SurveyId { get; set; }
    public Survey Survey { get; set; }
    public int? UserId { get; set; }
    public User User { get; set; }
}
public class AnswerQuestion
{
    public int Id { get; set; }
    public int? QuestionId { get; set; }
    public Question Question { get; set; }
    public int? AnswerId { get; set; }
    public Answer Answer { get; set; }
    public int? AnswerSurveyId { get; set; }
    public AnswerSurvey AnswerSurvey { get; set; }
}
public static class Email
{
    public static void SendMessageOnEmail(string userEmail, int code)
    {
        try
        {
            MailAddress from = new("danil_loginov_07@mail.ru", $"Questionnaire");
            MailAddress to = new(userEmail);
            MailMessage myMail = new(from, to)
            {
                Subject = "������������� �����.",
                SubjectEncoding = System.Text.Encoding.UTF8,
                Body = $"{code}",
                BodyEncoding = System.Text.Encoding.UTF8,
                IsBodyHtml = false
            };
            SmtpClient mySmtpClient = new("smtp.mail.ru", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("danil_loginov_07@mail.ru", "y9Awk12Gcd8bdPpikg0J")
            };
            mySmtpClient.Send(myMail);
        }
        catch (Exception)
        {
            MessageBox.Show("������ ��������");
        }
    }
}
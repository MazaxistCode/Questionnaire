using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire
{
    /// <summary>
    /// Класс отправки письма на почту
    /// </summary>
    public static class Email
    {
        /// <summary>
        /// Метод по отправке письма на почту
        /// </summary>
        /// <param name="userEmail">Почта пользователя</param>
        /// <param name="code">Код, который будет в письме</param>
        public static void SendMessageOnEmail(string userEmail, int code)
        {
            try
            {
                MailAddress from = new("danil_loginov_07@mail.ru", $"Questionnaire");
                MailAddress to = new(userEmail);
                MailMessage myMail = new(from, to)
                {
                    Subject = "Подтверждение почты.",
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
                MessageBox.Show("ошибка отправки");
            }
        }
    }
}

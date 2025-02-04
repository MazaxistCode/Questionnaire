using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class LogOnForm : Form
    {
        public LogOnForm()
        {
            InitializeComponent();
        }
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
        private void LogOnForm_Load(object sender, EventArgs e)
        {

        }
        private void OnButton_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == string.Empty || passBox.Text == string.Empty)
                MessageBox.Show("Впишите логин и пароль.");
            else
            {
                Context context = new();
                if (context.Users.Where(user => user.Login == loginBox.Text || user.Email == loginBox.Text).Any())
                    MessageBox.Show("пользователь с таким логином уже существует.");
                else
                {
                    string[] emails = ["gmail.com", "mail.ru", "yandex.ru", "bk.ru"];
                    if (loginBox.Text.Contains('@') && emails.Contains(loginBox.Text.Split('@')[1]))
                    {
                        Random rand = new();
                        int code = rand.Next(1784736, 9897435) - 2767;
                        Email.SendMessageOnEmail(loginBox.Text, code);
                        EnterCodeForm form = new();
                        Visible = false;
                        form.Location = Location;
                        System.Timers.Timer timer = new System.Timers.Timer(60000);
                        form.ShowDialog();
                        Location = form.Location;
                        string enterCode = form.codeBox.Text;
                        if ($"{code}" == enterCode)
                        {
                            Role role = context.Roles.Where(role => role.Name == "User").First();
                            User newUser = new() { Login = loginBox.Text, Password = GetMD5Hash(passBox.Text), Role = role, Email = loginBox.Text };
                            context.Users.Add(newUser);
                            context.SaveChanges();
                            MessageBox.Show("вы зарегистрированы.");
                            Close();
                        }
                        else
                            Visible = true;
                    }
                    else
                        MessageBox.Show("для регистрации впишите почту в поле для логина.");
                }
            }
        }
    }
}

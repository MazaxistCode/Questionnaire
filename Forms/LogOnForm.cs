using Questionnaire.DB;
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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool isFinish { get; private set; }
        public LogOnForm()
        {
            InitializeComponent();
            isFinish = false;
        }
        private void OnButton_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == string.Empty || PassBox.Text == string.Empty || PassBox2.Text == string.Empty)
                MessageBox.Show("зполните все поля");
            else
            {
                Context context = new();
                if (context.Users.Where(user => user.Login == LoginBox.Text || user.Email == LoginBox.Text).Any())
                    MessageBox.Show("пользователь с таким логином уже существует.");
                else
                {
                    string[] emails = ["gmail.com", "mail.ru", "yandex.ru", "bk.ru"];
                    if (LoginBox.Text.Contains('@') && emails.Contains(LoginBox.Text.Split('@')[1]))
                    {
                        if (PassBox.Text == PassBox2.Text)
                        {
                            Random rand = new();
                            int code = rand.Next(1784736, 9897435) - 2767;
                            Email.SendMessageOnEmail(LoginBox.Text, code);
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
                                User newUser = new() { Login = LoginBox.Text, Password = PassBox.Text.GetHash(), Role = role, Email = LoginBox.Text };
                                context.Users.Add(newUser);
                                context.SaveChanges();
                                File.Copy(@$"{AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "Avatars")}basicAvatar.png",
                                    @$"{AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "Avatars") + LoginBox.Text.GetHash()}.png", true);
                                isFinish = true;
                                MessageBox.Show("вы зарегистрированы.");
                                Close();
                            }
                            else
                                Visible = true;
                        }
                        else
                            MessageBox.Show("пароль повторён неверно");
                    }
                    else
                        MessageBox.Show("для регистрации впишите почту в поле для логина.");
                }
            }
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

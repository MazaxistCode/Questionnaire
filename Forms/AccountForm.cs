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
    /// Класс формы личного кабинета
    /// </summary>
    public partial class AccountForm : Form
    {
        /// <summary>
        /// Конструктор формы личного кабинета
        /// </summary>
        /// <param name="email">Почта авторизованного пользователя</param>
        public AccountForm(string email)
        {
            UserEmail = email;
            InitializeComponent();
        }
        /// <summary>
        /// Почта пользователя
        /// </summary>
        private string UserEmail { get; set; }
        /// <summary>
        /// Загрузчик формы личного кабинета
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AccountForm_Load(object sender, EventArgs e)
        {
            AvatarPictureBox.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "Avatars").Replace("bin\\Release\\net9.0-windows", "Avatars") + UserEmail.GetHash() + ".png");
            using Context context = new();
        }

        /// <summary>
        /// Кнопка смены аватара
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AvatarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog uaerAvatar = new();
            string pathAvatar = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "Avatars").Replace("bin\\Release\\net9.0-windows", "Avatars") + UserEmail.GetHash() + ".png";
            uaerAvatar.Filter = "Png|*.png";
            uaerAvatar.Title = "Выберите фото";
            uaerAvatar.ShowDialog();
            if (uaerAvatar.FileName != "")
            {
                if (File.Exists(uaerAvatar.FileName))
                {
                    AvatarPictureBox.Image?.Dispose();
                    AvatarPictureBox.Image = null;
                    File.Copy(uaerAvatar.FileName, pathAvatar, true);
                }
            }
            AvatarPictureBox.Image = new Bitmap(pathAvatar);
        }

        /// <summary>
        /// Кнопка применения изменений
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                User user = context.Users.Where(user => user.Email == UserEmail).First();
                bool isLogin = false;
                bool isPass = false;
                if (LoginBox.Text != string.Empty)
                    isLogin = user.Login != LoginBox.Text;
                if (PassBox.Text != string.Empty && PassBox2.Text != string.Empty)
                    isPass = user.Password == PassBox2.Text.GetHash() && PassBox.Text != PassBox2.Text;
                if (isLogin || isPass)
                {
                    Random rand = new();
                    int code = rand.Next(1784736, 9897435) - 2767;
                    Email.SendMessageOnEmail(UserEmail, code);
                    EnterCodeForm form = new();
                    Visible = false;
                    form.Location = new() { X = Location.X + 112, Y = Location.Y + 75 };
                    form.button1.Visible = false;
                    System.Timers.Timer timer = new System.Timers.Timer(60000);
                    form.ShowDialog();
                    Location = new() { X = form.Location.X - 112, Y = form.Location.Y - 75 };
                    string enterCode = form.codeBox.Text;
                    if ($"{code}" == enterCode)
                    {
                        user.Login = isLogin ? context.Users.Any(user => user.Login == LoginBox.Text) ? user.Login : LoginBox.Text : user.Login;
                        user.Password = isLogin ? PassBox.Text.GetHash() : user.Password;
                        context.SaveChanges();
                    }
                    Visible = true;
                }
            }
        }
    }
}

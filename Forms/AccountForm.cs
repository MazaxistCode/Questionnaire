using Microsoft.VisualBasic.ApplicationServices;
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

namespace Questionnaire
{
    public partial class AccountForm : Form
    {
        public AccountForm(string email)
        {
            UserEmail = email;
            InitializeComponent();
        }
        private string UserEmail { get; set; }
        private void AccountForm_Load(object sender, EventArgs e)
        {
            AvatarPictureBox.Image = new Bitmap(AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "Avatars") + UserEmail.GetHash() + ".png");
            using Context context = new();
        }

        private void AvatarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog uaerAvatar = new();
            string pathAvatar = AppDomain.CurrentDomain.BaseDirectory.Replace("bin\\Debug\\net9.0-windows", "Avatars") + UserEmail.GetHash() + ".png";
            uaerAvatar.Filter = "JPeg|*.jpg|Png|*.png";
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
    }
}

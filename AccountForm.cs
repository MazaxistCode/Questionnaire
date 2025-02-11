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
            pictureBox1.Image = new Bitmap(@$"C:\Users\Admin\source\repos\Questionnaire\Avatars\{UserEmail.GetHash()}.png");
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange([
                PictureBoxSizeMode.Normal,
                PictureBoxSizeMode.StretchImage,
                PictureBoxSizeMode.CenterImage,
                PictureBoxSizeMode.Zoom]);
            using Context context = new();
            comboBox1.SelectedItem = context.Users.Where(user => user.Email == UserEmail).First().SizeMode;
        }

        private void NewImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog uaerAvatar = new();
            string pathAvatar = @$"C:\Users\Admin\source\repos\Questionnaire\Avatars\{UserEmail.GetHash()}.png";
            uaerAvatar.Filter = "JPeg|*.jpg|Png|*.png";
            uaerAvatar.Title = "Выберите фото";
            uaerAvatar.ShowDialog();
            if (uaerAvatar.FileName != "")
            {
                if (File.Exists(uaerAvatar.FileName))
                {
                    pictureBox1.Image?.Dispose();
                    pictureBox1.Image = null;
                    File.Copy(uaerAvatar.FileName, pathAvatar, true);
                }
            }
            pictureBox1.Image = new Bitmap(pathAvatar);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBoxSizeMode sizeMode = (PictureBoxSizeMode)comboBox1.SelectedItem;
            pictureBox1.SizeMode = sizeMode;
            using Context context = new();
            context.Users.Where(user => user.Email == UserEmail).First().SizeMode = sizeMode;
            context.SaveChanges();
        }
    }
}

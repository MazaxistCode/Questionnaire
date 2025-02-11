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
    public partial class UserMenuForm : Form
    {
        public UserMenuForm(string email)
        {
            UserEmail = email;
            InitializeComponent();
        }
        private string UserEmail { get; set; }
        private void UserMenu_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                foreach (var survey in context.Surveies)
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies.Where(survey => survey.Name.Contains(SearchBox.Text)))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            AccountForm form = new(UserEmail);
            Visible = false;
            form.Location = Location;
            form.ShowDialog();
            if (form.AvatarPictureBox.Image != null)
                form.AvatarPictureBox.Image.Dispose();
            form.AvatarPictureBox.Image = null;
            Location = form.Location;
            Visible = true;
        }
    }
}

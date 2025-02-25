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
            form.Location = new() { X = Location.X + 87, Y = Location.Y + 75 };
            form.ShowDialog();
            if (form.AvatarPictureBox.Image != null)
                form.AvatarPictureBox.Image.Dispose();
            form.AvatarPictureBox.Image = null;
            Location = new() { X = form.Location.X - 87, Y = form.Location.Y - 75 };
            Visible = true;
        }

        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            CreateSurveyForm createSurveyForm = new(UserEmail);
            Visible = false;
            createSurveyForm.Location = Location;
            createSurveyForm.ShowDialog();
            UserSurveiesForm userSurveiesForm = new(UserEmail);
            userSurveiesForm.Location = createSurveyForm.Location;
            userSurveiesForm.ShowDialog();
            Location = userSurveiesForm.Location;
            Visible = true;
            using (Context context = new())
            {
                SearchBox.Text = string.Empty;
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies)
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        private void UserSurveiesButton_Click(object sender, EventArgs e)
        {
            UserSurveiesForm userSurveiesForm = new(UserEmail);
            Visible = false;
            userSurveiesForm.Location = Location;
            userSurveiesForm.ShowDialog();
            Location = userSurveiesForm.Location;
            Visible = true;
            using (Context context = new())
            {
                SearchBox.Text = string.Empty;
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies)
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        private void OpenSurveyButton_Click(object sender, EventArgs e)
        {

        }
    }
}

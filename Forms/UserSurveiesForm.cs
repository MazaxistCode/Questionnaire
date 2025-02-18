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
    public partial class UserSurveiesForm : Form
    {
        public UserSurveiesForm(string email)
        {
            UserEmail = email;
            InitializeComponent();
        }
        private string UserEmail { get; set; }
        private void UserSurveysForm_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                foreach (var survey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
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
                foreach (var survey in context.Surveies.Where(survey => survey.Name.Contains(SearchBox.Text) && survey.User.Email == UserEmail))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            CreateSurveyForm form = new(UserEmail);
            Visible = false;
            form.Location = Location;
            form.ShowDialog();
            Location = form.Location;
            Visible = true;
            using (Context context = new())
            {
                SearchBox.Text = string.Empty;
                SurveiesListBox.Items.Clear();
                foreach (var survey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

        private void EditSurveyButton_Click(object sender, EventArgs e)
        {
            if (SurveiesListBox.Text != string.Empty)
            {
                CreateSurveyForm form;
                using (Context context = new())
                {
                    form = new(UserEmail, context.Surveies.Where(survey => survey.Name == SurveiesListBox.Text).First());
                }
                Visible = false;
                form.Location = Location;
                form.ShowDialog();
                Location = form.Location;
                Visible = true;
                using (Context context = new())
                {
                    SearchBox.Text = string.Empty;
                    SurveiesListBox.Items.Clear();
                    foreach (var survey in context.Surveies.Where(survey => survey.User.Email == UserEmail))
                    {
                        SurveiesListBox.Items.Add(survey.Name);
                    }
                }
            }
        }
    }
}

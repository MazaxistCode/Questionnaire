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
    public partial class UserSurveysForm : Form
    {
        public UserSurveysForm(string email)
        {
            UserEmail = email;
            InitializeComponent();
        }
        private string UserEmail { get; set; }
        private void UserSurveysForm_Load(object sender, EventArgs e)
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
                foreach (var survey in context.Surveies.Where(survey => survey.Name.Contains(SearchBox.Text) && survey.User.Email == UserEmail))
                {
                    SurveiesListBox.Items.Add(survey.Name);
                }
            }
        }

    }
}

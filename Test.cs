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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print();
        }
        public void Print()
        {
            Context context = new();
            string text = "пользователи\n\n";
            foreach (var user in context.Users)
            {
                text +=
                    user.Id + "   " +
                    user.Login + "   " +
                    user.Password + "   " +
                    user.Email + "   " +
                    user.RoleId
                    + '\n';
            }
            label1.Text = text;
            text = "роль\n\n";
            foreach (var user in context.Roles)
            {
                text +=
                    user.Id + "   " +
                    user.Name + "   "
                    + '\n';
            }
            label2.Text = text;
            text = "опрос\n\n";
            foreach (var user in context.Surveies)
            {
                text +=
                    user.Id + "   " +
                    user.Name + "   " +
                    user.UserId
                    + "\n";
            }
            label3.Text = text;
            text = "вопросы на опрос\n\n";
            foreach (var user in context.Questions)
            {
                text +=
                    user.Id + "   " +
                    user.Name + "   " +
                    user.SurveyId
                    + "\n";
            }
            label4.Text = text;
            text = "ответы на вопросы\n\n";
            foreach (var user in context.Answers)
            {
                text +=
                    user.Id + "   " +
                    user.Name + "   " +
                    user.IsTrue + "   " +
                    user.QuestionId
                    + "\n";
            }
            label5.Text = text;
            text = "ответы на опрос\n\n";
            foreach (var user in context.AnswerSurveies)
            {
                text +=
                    user.Id + "   " +
                    user.SurveyId
                    + "\n";
            }
            label6.Text = text;
            text = "ответ на вопрос\n\n";
            foreach (var user in context.AnswerQuestions)
            {
                text +=
                    user.Id + "   " +
                    user.AnswerSurveyId + "   " +
                    user.AnswerId
                    + "\n";
            }
            label7.Text = text;
        }
    }
}

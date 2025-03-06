using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Questionnaire.DB;

namespace Questionnaire.Forms
{
    public partial class UserResultForm : Form
    {
        public UserResultForm(string surveyName, string userEmail)
        {
            using(Context context = new())
            {
                User = context.Users.First(user => user.Email == userEmail);
                Survey = context.Surveies.First(survey => survey.Name == surveyName);
                AnswerSurvey = context.AnswerSurveies.First(answerSurvey => answerSurvey.UserId == User.Id && answerSurvey.SurveyId == Survey.Id);
                answerQuestions = context.AnswerQuestions.Where(answerQuestion => answerQuestion.AnswerSurveyId == AnswerSurvey.Id).ToArray();
                foreach (var answerQuestion in answerQuestions)
                    answers.Add(context.Answers.First(answer => answer.Id == answerQuestion.AnswerId));
            }
            InitializeComponent();
        }
        User User { get; set; }
        Survey Survey { get; set; }
        AnswerSurvey AnswerSurvey { get; set; }
        AnswerQuestion[] answerQuestions { get; set; }
        List<Answer> answers { get; set; } = [];

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserResultForm_Load(object sender, EventArgs e)
        {
            SurveyNameLabel.Text = Survey.Name;
            SurveyBallLabel.Text = $"{Survey.Ball}";
            ResultBar.Maximum = Survey.Ball;
            int ball = 0;
            foreach (var answer in answers)
                ball += answer.Ball;
            ResultBar.Value = ball;
            UserBallLabel.Text = $"{ball}";
        }
    }
}

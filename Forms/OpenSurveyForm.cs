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
    public partial class OpenSurveyForm : Form
    {
        public OpenSurveyForm(string surveyName, string userEmail)
        {
            using (Context context = new())
            {
                User = context.Users.First(user => user.Email == userEmail);
                Survey = context.Surveies.First(survey => survey.Name == surveyName);
                questions = context.Questions.Where(question => question.SurveyId == Survey.Id).ToArray();
                answers = context.Answers.Where(answer => answer.SurveyId == Survey.Id).ToArray();
                AnswerSurvey = new() { Survey = Survey, User = User };
                answerQuestions = new AnswerQuestion[questions.Length];
                for (int i = 0; i < questions.Length; i++)
                    answerQuestions[i] = new() { AnswerSurvey = AnswerSurvey, Question = questions[i] };
            }
            InitializeComponent();
        }
        User User { get; set; }
        Survey Survey { get; set; }
        Question[] questions { get; set; }
        Question? QuestionOn { get; set; }
        Answer[] answers { get; set; }
        AnswerSurvey AnswerSurvey { get; set; }
        AnswerQuestion[] answerQuestions { get; set; }

        private void OpenSurveyForm_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                QuestionsListBox.Items.Clear();
                foreach (Question question in questions)
                    QuestionsListBox.Items.Add(question.Name);
            }

        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            if (QuestionOn != null && AnswersListBox.Text != string.Empty)
            {
                Answer answer = answers.First(answer => answer.Name == AnswersListBox.Text && answer.QuestionId == QuestionOn.Id);
                answerQuestions[Array.IndexOf(answerQuestions, answerQuestions.First(answerQuestion => answerQuestion.Question.Id == QuestionOn.Id))].Answer = answer;
                QuestionCountLabel.Text = $"{answerQuestions.Count(answer => answer.Answer is not null)} | {answerQuestions.Length}";
                int index = QuestionsListBox.SelectedIndex;
                if (index < QuestionsListBox.Items.Count - 1)
                {
                    QuestionsListBox.SelectedIndex = index + 1;
                    QuestionsListBox_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void QuestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionsListBox.Text != string.Empty)
            {
                QuestionOn = questions.First(question => question.Name == QuestionsListBox.Text);
                QuestionLabel.Text = QuestionsListBox.Text;
                AnswersListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.QuestionId == QuestionOn.Id))
                    AnswersListBox.Items.Add(answer.Name);
            }
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            using(Context context = new())
            {
                if (!answerQuestions.Any(answerQuestion => answerQuestion.Answer == null))
                {
                    context.AnswerSurveies.Add(new() { Survey = context.Surveies.First(survey => survey.Id == Survey.Id), User = context.Users.First(user => user.Id == User.Id) });
                    context.SaveChanges();
                    AnswerSurvey = context.AnswerSurveies.First(answerSurvey => answerSurvey.SurveyId == Survey.Id && answerSurvey.UserId == User.Id);
                    foreach (var answerQuestion in answerQuestions)
                        context.AnswerQuestions.Add(new()
                        {
                            AnswerSurvey = context.AnswerSurveies.First(answerSurvey => answerSurvey.SurveyId == Survey.Id && answerSurvey.UserId == User.Id),
                            Question = context.Questions.First(question => question.Id == answerQuestion.Question.Id),
                            Answer = context.Answers.First(answer => answer.Id == answerQuestion.Answer.Id)
                        });
                    context.SaveChanges();
                    UserResultForm form = new(Survey.Name, User.Email);
                    Visible = false;
                    form.Location = Location;
                    form.ShowDialog();
                    Location = form.Location;
                    Visible = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Ответьте на все вопросы.");
                }
            }
        }
    }
}

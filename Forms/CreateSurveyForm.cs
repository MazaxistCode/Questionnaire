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
    public partial class CreateSurveyForm : Form
    {
        public CreateSurveyForm(string email, Survey? survey = null)
        {
            UserEmail = email;
            using (Context context = new())
            {
                this.survey = survey ?? new() { User = context.Users.Where(user => user.Email == email).First() };
                questions = survey is null ? [] : context.Questions.Where(question => question.SurveyId == survey.Id).ToList();
                answers = survey is null ? [] : context.Answers.Where(answer => answer.SurveyId == survey.Id).ToList();
                questionOn = questions.FirstOrDefault() ?? new() { Survey = this.survey };
            }
            InitializeComponent();
        }
        private string UserEmail { get; set; }
        private Survey survey;
        private List<Question> questions;
        private Question questionOn;
        private List<Answer> answers;

        private void CreateSurveyForm_Load(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
            }
        }

        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            using(Context context = new())
            {
                context.Surveies.Add(survey);
                context.Questions.AddRange([.. questions]);
                context.Answers.AddRange([.. answers]);
            }
        }

        private void QuestionSearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
            }
        }

        private void AnswerSearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                AnswerListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.Question == questionOn && answer.Name.Contains(AnswerSearchBox.Text)))
                {
                    AnswerListBox.Items.Add(answer.Name);
                }
            }
        }

        private void RemQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionNameBox.Text != string.Empty && questions.Where(question => question.Name == QuestionNameBox.Text).Any())
            {
                foreach(var answer in answers.Where(answer => answer.Question == questions.Where(question => question.Name == QuestionNameBox.Text).First()).ToList())
                    answers.Remove(answer);
                questions.Remove(questions.Where(question => question.Name == QuestionNameBox.Text).First());
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
                AnswerListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.Question == questionOn))
                {
                    AnswerListBox.Items.Add(answer.Name);
                }
                QuestionLabel.Text = "ВОПРОС";
                IsTrueAnswerBox.Checked = false;
                AnswerNameBox.Text = string.Empty;
                AnswerBallBox.Text = string.Empty;
                QuestionNameBox.Text = string.Empty;
            }
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionNameBox.Text != string.Empty && !questions.Where(question => question.Name == QuestionNameBox.Text).Any())
                questions.Add(new() { Name = QuestionNameBox.Text, Survey = survey });
            QuestionListBox.Items.Clear();
            foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
            {
                QuestionListBox.Items.Add(question.Name);
            }
            Question questionOn = questions.Where(question => question.Name == QuestionNameBox.Text).First();
            this.questionOn = questionOn;
            AnswerListBox.Items.Clear();
            foreach (var answer in answers.Where(answer => answer.Question == questionOn))
            {
                AnswerListBox.Items.Add(answer.Name);
            }
            QuestionLabel.Text = QuestionNameBox.Text;
            IsTrueAnswerBox.Checked = false;
            AnswerNameBox.Text = string.Empty;
            AnswerBallBox.Text = string.Empty;
        }

        private void RemAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswerNameBox.Text != string.Empty && answers.Where(answer => answer.Name == AnswerNameBox.Text).Any())
                answers.Remove(answers.Where(answer => answer.Name == AnswerNameBox.Text).First());
            AnswerListBox.Items.Clear();
            foreach (var answer in answers.Where(answer => answer.Question == questionOn))
            {
                AnswerListBox.Items.Add(answer.Name);
            }
        }

        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswerNameBox.Text != string.Empty && AnswerBallBox.Text != string.Empty && questions.Where(question => question.Name == QuestionLabel.Text).Any())
            {
                bool isNewAnswer = !answers.Where(answer => answer.Name == AnswerNameBox.Text).Any();
                Answer answer = answers.Where(answer => answer.Name == AnswerNameBox.Text).FirstOrDefault() ?? new();
                answer.Survey = survey;
                answer.Question = questionOn;
                answer.Name = AnswerNameBox.Text;
                answer.Ball = int.Parse(AnswerBallBox.Text);
                answer.IsTrue = IsTrueAnswerBox.Checked;
                if (isNewAnswer)
                    answers.Add(answer);
                AnswerListBox.Items.Clear();
                foreach (var answerOn in answers.Where(answer => answer.Question == questionOn && answer.Name.Contains(AnswerSearchBox.Text)))
                {
                    AnswerListBox.Items.Add(answerOn.Name);
                }
                AnswerListBox.Text = answer.Name;
            }
        }

        private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question questionOn = questions.Where(question => question.Name == QuestionListBox.Text).First();
            QuestionNameBox.Text = questionOn.Name;
            this.questionOn = questionOn;
            AnswerListBox.Items.Clear();
            foreach (var answer in answers.Where(answer => answer.Question == questionOn))
            {
                AnswerListBox.Items.Add(answer.Name);
            }
            QuestionLabel.Text = QuestionNameBox.Text;
            IsTrueAnswerBox.Checked = false;
            AnswerNameBox.Text = string.Empty;
            AnswerBallBox.Text = string.Empty;
        }

        private void AnswerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Answer answerOn = answers.Where(answer => answer.Name == AnswerListBox.Text).First();
            QuestionLabel.Text = answerOn.Question.Name;
            AnswerNameBox.Text = answerOn.Name;
            AnswerBallBox.Text = $"{answerOn.Ball}";
            IsTrueAnswerBox.Checked = answerOn.IsTrue;
        }
    }
}

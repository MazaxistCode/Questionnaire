using Questionnaire.DB;
using System.Data;

namespace Questionnaire.Forms
{
    /// <summary>
    /// Класс формы создания опроса
    /// </summary>
    public partial class CreateSurveyForm : Form
    {
        /// <summary>
        /// Конструктор формы создания опроса
        /// </summary>
        /// <param name="email">Почта авторизированного пользователя</param>
        /// <param name="survey">Выбранный опрос</param>
        public CreateSurveyForm(string email, Survey? survey = null)
        {
            UserEmail = email;
            using (Context context = new())
            {
                this.survey = survey ?? new();
                questions = survey is null ? [] : context.Questions.Where(question => question.SurveyId == survey.Id).ToList();
                answers = survey is null ? [] : context.Answers.Where(answer => answer.SurveyId == survey.Id).ToList();
                questionOn = questions.FirstOrDefault() ?? new();
                IsEdit = survey is not null;
            }
            InitializeComponent();
        }
        /// <summary>
        /// Редактирование опроса да/нет
        /// </summary>
        bool IsEdit { get; set; }
        /// <summary>
        /// Почта пользователя
        /// </summary>
        string UserEmail { get; set; }
        /// <summary>
        /// Опрос
        /// </summary>
        private Survey survey;
        /// <summary>
        /// Лист вопросов
        /// </summary>
        private List<Question> questions;
        /// <summary>
        /// Выбранный вопрос
        /// </summary>
        private Question questionOn;
        /// <summary>
        /// Лист ответов
        /// </summary>
        private List<Answer> answers;

        /// <summary>
        /// Загрузчик формы создания опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void CreateSurveyForm_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                SurveyNameBox.Text = survey.Name;
                SurveyNameBox.ReadOnly = true;

            }
            using (Context context = new())
            {
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка создания опроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void CreateSurveyButton_Click(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                using (Context context = new())
                {
                    if (questions.Any() && answers.Any() && questions.Where(question =>
                    answers.Where(answer => answer.Question == question).Any()).Count() == questions.Count &&
                    context.Surveies.Where(survey => survey.Name == SurveyNameBox.Text).Any())
                    {

                        int maxBall = 0;
                        foreach (var question in questions)
                        {
                            int maxBallQuestion = 0;
                            foreach (var answer in answers.Where(answer => answer.Question.Name == question.Name).ToArray())
                            {
                                if (answer.Ball > maxBallQuestion)
                                    maxBallQuestion = answer.Ball;
                            }
                            maxBall += maxBallQuestion;
                        }
                        survey.Ball = maxBall;
                        AnswerSurvey[] answerSurveys = context.AnswerSurveies.Where(answerSurbey => answerSurbey.SurveyId == survey.Id).ToArray();
                        List<AnswerQuestion> answerQuestions = [];
                        foreach (var answerSurvey in answerSurveys)
                            answerQuestions.AddRange(context.AnswerQuestions.Where(answerQuestion => answerQuestion.AnswerSurveyId == answerSurvey.Id).ToList());
                        context.AnswerQuestions.RemoveRange(answerQuestions);
                        context.AnswerSurveies.RemoveRange(answerSurveys);
                        context.Surveies.Update(survey);
                        context.SaveChanges();
                        List<Question> allOldDBQuestions = context.Questions.Where(question => question.SurveyId == survey.Id).ToList();
                        List<Question> oldDBQuestions = context.Questions.Where(question => question.SurveyId == survey.Id).ToList();
                        List<Answer> oldDBAnswers = context.Answers.Where(answer => answer.SurveyId == survey.Id).ToList();
                        List<Answer> deletedAnswers = [];
                        foreach (var oldQuestion in allOldDBQuestions)
                        {
                            Question? editQuestion = questions.Where(question => question.Id == oldQuestion.Id).FirstOrDefault();
                            if (editQuestion is not null)
                            {
                                oldQuestion.Name = editQuestion.Name;
                                context.Update(oldQuestion);
                                questions.Remove(editQuestion);
                            }
                            else
                            {
                                deletedAnswers.AddRange(oldDBAnswers.Where(answer => answer.QuestionId == oldQuestion.Id).ToList());
                                context.Questions.Remove(oldQuestion);
                                oldDBQuestions.Remove(oldQuestion);
                            }
                        }
                        foreach (var deletedAnswer in deletedAnswers)
                            answers.Remove(deletedAnswer);
                        context.Answers.RemoveRange(deletedAnswers);
                        context.Questions.AddRange(questions);
                        context.SaveChanges();
                        foreach (var oldQuestion in oldDBQuestions)
                        {
                            List<Answer> oldQuestionAnswers = oldDBAnswers.Where(oldAnswer => oldAnswer?.Question?.Id == oldQuestion.Id).ToList();
                            List<Answer> questionAnswers = answers.Where(answer => answer.QuestionId == oldQuestion.Id || answer.Question.Name == oldQuestion.Name).ToList();
                            foreach (var oldAnswer in oldQuestionAnswers)
                            {
                                Answer? editAnswer = questionAnswers.Where(answer => answer.Id == oldAnswer.Id).FirstOrDefault();
                                if (editAnswer is not null)
                                {
                                    oldAnswer.Name = editAnswer.Name;
                                    oldAnswer.Ball = editAnswer.Ball;
                                    context.Answers.Update(oldAnswer);
                                    answers.Remove(editAnswer);
                                }
                                else
                                {
                                    context.Answers.Remove(oldAnswer);
                                    answers.Remove(oldAnswer);
                                }
                            }

                        }
                        foreach (var answer in answers)
                            context.Answers.Add(new()
                            {
                                Ball = answer.Ball,
                                Name = answer.Name,
                                QuestionId = answer.Question.Id,
                                SurveyId = answer.Question.SurveyId
                            });
                        context.SaveChanges();
                        Close();
                    }
                }
            }
            else
            {
                using (Context context = new())
                {
                    if (questions.Any() && answers.Any() && questions.Where(question =>
                    answers.Where(answer => answer.Question == question).Any()).Count() == questions.Count &&
                    SurveyNameBox.Text != string.Empty &&
                    !context.Surveies.Where(survey => survey.Name == SurveyNameBox.Text).Any())
                    {

                        int maxBall = 0;
                        foreach (var answer in answers)
                            maxBall += answer.Ball;
                        survey.User = context.Users.Where(user => user.Email == UserEmail).First();
                        survey.Ball = maxBall;
                        survey.Name = SurveyNameBox.Text;
                        context.Surveies.Add(survey);
                        context.Questions.AddRange(questions);
                        context.Answers.AddRange(answers);
                        context.SaveChanges();
                        Close();
                    }
                }
            }
        }

        /// <summary>
        /// Кнопка поиска вопросов
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void QuestionSearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
                AnswerListBox.Items.Clear();
                QuestionLabel.Text = "ВОПРОС";
                QuestionNameBox.Text = string.Empty;
                QuestionUpdateBox.Text = string.Empty;
                AnswerNameBox.Text = string.Empty;
                AnswerBallBox.Text = "0";
                AnswerUpdateBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Кнопка поиска ответов
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AnswerSearchButton_Click(object sender, EventArgs e)
        {
            using (Context context = new())
            {
                AnswerListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.Question == questionOn && answer.Name.Contains(AnswerSearchBox.Text)))
                {
                    AnswerListBox.Items.Add(answer.Name);
                }
                AnswerNameBox.Text = string.Empty;
                AnswerBallBox.Text = "0";
                AnswerUpdateBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Кнопка удаления вопроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void RemQuestionButton_Click(object sender, EventArgs e)
        {
            if (QuestionNameBox.Text != string.Empty && questions.Where(question => question.Name == QuestionNameBox.Text).Any())
            {
                foreach (var answer in answers.Where(answer => answer.Question == questions.First(question => question.Name == QuestionNameBox.Text)).ToList())
                    answers.Remove(answer);
                questions.Remove(questionOn);
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
                questionOn = new();
                AnswerSearchBox.Text = string.Empty;
                AnswerListBox.Items.Clear();
                QuestionLabel.Text = "ВОПРОС";
                AnswerNameBox.Text = string.Empty;
                AnswerBallBox.Text = "0";
                AnswerUpdateBox.Text = string.Empty;
                QuestionNameBox.Text = string.Empty;
                QuestionUpdateBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Кнопка добавления вопроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
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
            AnswerNameBox.Text = string.Empty;
            AnswerBallBox.Text = "0";
            QuestionUpdateBox.Text = string.Empty;
            QuestionNameBox.Text = string.Empty;
        }

        /// <summary>
        /// Кнопка удаления ответа
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void RemAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswerNameBox.Text != string.Empty && answers.Where(answer => answer.Name == AnswerNameBox.Text && answer.Question.Name == questionOn.Name).Any())
                answers.Remove(answers.Where(answer => answer.Name == AnswerNameBox.Text && answer.Question.Name == questionOn.Name).First());
            AnswerListBox.Items.Clear();
            foreach (var answer in answers.Where(answer => answer.Question == questionOn))
            {
                AnswerListBox.Items.Add(answer.Name);
            }
            AnswerNameBox.Text = string.Empty;
            AnswerBallBox.Text = "0";
            AnswerUpdateBox.Text = string.Empty;
        }

        /// <summary>
        /// Кнопка добавления ответа
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AddAnswerButton_Click(object sender, EventArgs e)
        {
            if (AnswerNameBox.Text != string.Empty && questions.Where(question => question.Name == QuestionLabel.Text).Any() && !AnswerListBox.Items.Contains(AnswerNameBox.Text))
            {
                bool isNewAnswer = !answers.Where(answer => answer.Question == questionOn).Where(answer => answer.Name == AnswerNameBox.Text).Any();
                Answer answer = answers.Where(answer => answer.Question == questionOn).Where(answer => answer.Name == AnswerNameBox.Text).FirstOrDefault() ?? new();
                answer.Survey = survey;
                answer.Question = questionOn;
                answer.Name = AnswerNameBox.Text;
                answer.Ball = int.TryParse(AnswerBallBox.Text, out int ball) ? ball : 0;
                if (isNewAnswer)
                    answers.Add(answer);
                AnswerListBox.Items.Clear();
                foreach (var answerOn in answers.Where(answer => answer.Question == questionOn && answer.Name.Contains(AnswerSearchBox.Text)))
                {
                    AnswerListBox.Items.Add(answerOn.Name);
                }
                AnswerBallBox.Value = 0;
                AnswerNameBox.Text = string.Empty;
                AnswerUpdateBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Выбор вопроса в листе вопросов
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void QuestionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QuestionListBox.Text != string.Empty)
            {
                Question questionOn = questions.Where(question => question.Name == QuestionListBox.Text).First();
                QuestionNameBox.Text = questionOn.Name;
                this.questionOn = questionOn;
                QuestionUpdateBox.Text = questionOn.Name;
                AnswerListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.Question == questionOn))
                {
                    AnswerListBox.Items.Add(answer.Name);
                }
                QuestionLabel.Text = QuestionNameBox.Text;
                AnswerSearchBox.Text = string.Empty;
                AnswerNameBox.Text = string.Empty;
                AnswerBallBox.Text = "0";
                AnswerUpdateBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Выбор ответа в листе ответов
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AnswerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnswerListBox.Text != string.Empty)
            {
                Answer answerOn = answers.Where(answer => answer.Name == AnswerListBox.Text && answer.Question == questionOn).First();
                AnswerUpdateBox.Text = answerOn.Name;
                QuestionLabel.Text = answerOn.Question.Name;
                AnswerNameBox.Text = answerOn.Name;
                AnswerBallBox.Text = $"{answerOn.Ball}";
            }
        }

        /// <summary>
        /// Кнопка изменения вопроса
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void QuestionUpdateButton_Click(object sender, EventArgs e)
        {
            if (QuestionNameBox.Text != string.Empty && QuestionUpdateBox.Text != string.Empty && QuestionNameBox.Text != QuestionUpdateBox.Text && !questions.Where(question => question.Name == QuestionUpdateBox.Text).Any())
            {
                Question questionOn = questions.Where(question => question == this.questionOn).First();
                questionOn.Name = QuestionUpdateBox.Text;
                QuestionNameBox.Text = QuestionUpdateBox.Text;
                QuestionListBox.Items.Clear();
                foreach (var question in questions.Where(question => question.Name.Contains(QuestionSearchBox.Text)))
                {
                    QuestionListBox.Items.Add(question.Name);
                }
                QuestionLabel.Text = questionOn.Name;
                AnswerSearchBox.Text = string.Empty;
                AnswerListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.Question == this.questionOn))
                {
                    AnswerListBox.Items.Add(answer.Name);
                }
            }
        }

        /// <summary>
        /// Кнопка изменения ответа
        /// </summary>
        /// <param name="sender">Объект вызывающий событие</param>
        /// <param name="e">Объект обытия</param>
        private void AnswerUpdateButton_Click(object sender, EventArgs e)
        {
            if (AnswerNameBox.Text != string.Empty && AnswerUpdateBox.Text != string.Empty && AnswerNameBox.Text != AnswerUpdateBox.Text && !answers.Where(answer => answer.Question == questionOn).Any(answer => answer.Name == AnswerUpdateBox.Text))
            {
                Answer answerOn = answers.Where(answer => answer.Question == questionOn && answer.Name == AnswerNameBox.Text).First();
                answerOn.Name = AnswerUpdateBox.Text;
                answerOn.Ball = int.TryParse(AnswerBallBox.Text, out int ball) ? ball : 0;
                AnswerSearchBox.Text = string.Empty;
                AnswerListBox.Items.Clear();
                foreach (var answer in answers.Where(answer => answer.Question == questionOn))
                {
                    AnswerListBox.Items.Add(answer.Name);
                }
                AnswerNameBox.Text = AnswerUpdateBox.Text;
            }
        }
    }
}

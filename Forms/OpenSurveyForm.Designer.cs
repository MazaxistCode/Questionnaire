namespace Questionnaire.Forms
{
    partial class OpenSurveyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            AnswerButton = new Button();
            YButton = new Button();
            AnswersListBox = new ListBox();
            QuestionsListBox = new ListBox();
            ZButton = new Button();
            QuestionLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(QuestionLabel);
            panel1.Controls.Add(AnswerButton);
            panel1.Controls.Add(YButton);
            panel1.Controls.Add(AnswersListBox);
            panel1.Controls.Add(QuestionsListBox);
            panel1.Controls.Add(ZButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 437);
            panel1.TabIndex = 2;
            // 
            // AnswerButton
            // 
            AnswerButton.BackColor = Color.DeepSkyBlue;
            AnswerButton.FlatAppearance.BorderSize = 0;
            AnswerButton.FlatStyle = FlatStyle.Flat;
            AnswerButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AnswerButton.ForeColor = Color.White;
            AnswerButton.Location = new Point(526, 357);
            AnswerButton.Name = "AnswerButton";
            AnswerButton.Size = new Size(104, 51);
            AnswerButton.TabIndex = 8;
            AnswerButton.Text = "Ответить";
            AnswerButton.UseVisualStyleBackColor = false;
            // 
            // YButton
            // 
            YButton.BackColor = Color.DeepSkyBlue;
            YButton.FlatAppearance.BorderSize = 0;
            YButton.FlatStyle = FlatStyle.Flat;
            YButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            YButton.ForeColor = Color.White;
            YButton.Location = new Point(636, 357);
            YButton.Name = "YButton";
            YButton.Size = new Size(102, 51);
            YButton.TabIndex = 7;
            YButton.Text = ">>";
            YButton.UseVisualStyleBackColor = false;
            // 
            // AnswersListBox
            // 
            AnswersListBox.BackColor = Color.DeepSkyBlue;
            AnswersListBox.BorderStyle = BorderStyle.None;
            AnswersListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AnswersListBox.ForeColor = Color.White;
            AnswersListBox.Location = new Point(418, 96);
            AnswersListBox.Name = "AnswersListBox";
            AnswersListBox.Size = new Size(320, 240);
            AnswersListBox.TabIndex = 6;
            // 
            // QuestionsListBox
            // 
            QuestionsListBox.BackColor = Color.DeepSkyBlue;
            QuestionsListBox.BorderStyle = BorderStyle.None;
            QuestionsListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuestionsListBox.ForeColor = Color.White;
            QuestionsListBox.Location = new Point(23, 24);
            QuestionsListBox.Name = "QuestionsListBox";
            QuestionsListBox.Size = new Size(374, 384);
            QuestionsListBox.TabIndex = 5;
            // 
            // ZButton
            // 
            ZButton.BackColor = Color.DeepSkyBlue;
            ZButton.FlatAppearance.BorderSize = 0;
            ZButton.FlatStyle = FlatStyle.Flat;
            ZButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            ZButton.ForeColor = Color.White;
            ZButton.Location = new Point(418, 357);
            ZButton.Name = "ZButton";
            ZButton.Size = new Size(102, 51);
            ZButton.TabIndex = 4;
            ZButton.Text = "<<";
            ZButton.UseVisualStyleBackColor = false;
            // 
            // QuestionLabel
            // 
            QuestionLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            QuestionLabel.ForeColor = Color.White;
            QuestionLabel.Location = new Point(418, 24);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(320, 57);
            QuestionLabel.TabIndex = 27;
            QuestionLabel.Text = "ВОПРОС";
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OpenSurveyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OpenSurveyForm";
            StartPosition = FormStartPosition.Manual;
            Text = "OpenSurveyForm";
            Load += OpenSurveyForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ZButton;
        private ListBox AnswersListBox;
        private ListBox QuestionsListBox;
        private Button AnswerButton;
        private Button YButton;
        private Label QuestionLabel;
    }
}
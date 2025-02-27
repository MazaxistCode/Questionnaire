namespace Questionnaire.Forms
{
    partial class CreateSurveyForm
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
            CreateSurveyButton = new Button();
            SurveyNameLabel = new Label();
            SurveyNameBox = new TextBox();
            groupBox1 = new GroupBox();
            AnswerBallBox = new NumericUpDown();
            AnswerUpdateButton = new Button();
            AnswerUpdateLabel = new Label();
            AnswerUpdateBox = new TextBox();
            QuestionLabel = new Label();
            QuestionOnLabel = new Label();
            AnswerBallLabel = new Label();
            IsTrueAnswerBox = new CheckBox();
            AnswerNameLabel = new Label();
            AnswerNameBox = new TextBox();
            AnswerListBox = new ListBox();
            AnswerSearchButton = new Button();
            AnswerSearchBox = new TextBox();
            AddAnswerButton = new Button();
            RemAnswerButton = new Button();
            groupBox2 = new GroupBox();
            QuestionUpdateLabel = new Label();
            QuestionUpdateBox = new TextBox();
            QuestionUpdateButton = new Button();
            QuestionNameLabel = new Label();
            QuestionNameBox = new TextBox();
            QuestionListBox = new ListBox();
            QuestionSearchButton = new Button();
            QuestionSearchBox = new TextBox();
            AddQuestionButton = new Button();
            RemQuestionButton = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnswerBallBox).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(CreateSurveyButton);
            panel1.Controls.Add(SurveyNameLabel);
            panel1.Controls.Add(SurveyNameBox);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 437);
            panel1.TabIndex = 3;
            // 
            // CreateSurveyButton
            // 
            CreateSurveyButton.BackColor = Color.DeepSkyBlue;
            CreateSurveyButton.FlatAppearance.BorderSize = 0;
            CreateSurveyButton.FlatStyle = FlatStyle.Flat;
            CreateSurveyButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CreateSurveyButton.ForeColor = Color.White;
            CreateSurveyButton.Location = new Point(604, 18);
            CreateSurveyButton.Name = "CreateSurveyButton";
            CreateSurveyButton.Size = new Size(139, 23);
            CreateSurveyButton.TabIndex = 33;
            CreateSurveyButton.Text = "СОЗДАТЬ ОПРОС";
            CreateSurveyButton.UseVisualStyleBackColor = false;
            CreateSurveyButton.Click += CreateSurveyButton_Click;
            // 
            // SurveyNameLabel
            // 
            SurveyNameLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            SurveyNameLabel.ForeColor = Color.White;
            SurveyNameLabel.Location = new Point(14, 20);
            SurveyNameLabel.Name = "SurveyNameLabel";
            SurveyNameLabel.Size = new Size(93, 21);
            SurveyNameLabel.TabIndex = 28;
            SurveyNameLabel.Text = "ИМЯ ОПРОСА";
            SurveyNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SurveyNameBox
            // 
            SurveyNameBox.BackColor = Color.FromArgb(192, 255, 255);
            SurveyNameBox.BorderStyle = BorderStyle.FixedSingle;
            SurveyNameBox.Location = new Point(113, 18);
            SurveyNameBox.Name = "SurveyNameBox";
            SurveyNameBox.Size = new Size(485, 23);
            SurveyNameBox.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AnswerBallBox);
            groupBox1.Controls.Add(AnswerUpdateButton);
            groupBox1.Controls.Add(AnswerUpdateLabel);
            groupBox1.Controls.Add(AnswerUpdateBox);
            groupBox1.Controls.Add(QuestionLabel);
            groupBox1.Controls.Add(QuestionOnLabel);
            groupBox1.Controls.Add(AnswerBallLabel);
            groupBox1.Controls.Add(IsTrueAnswerBox);
            groupBox1.Controls.Add(AnswerNameLabel);
            groupBox1.Controls.Add(AnswerNameBox);
            groupBox1.Controls.Add(AnswerListBox);
            groupBox1.Controls.Add(AnswerSearchButton);
            groupBox1.Controls.Add(AnswerSearchBox);
            groupBox1.Controls.Add(AddAnswerButton);
            groupBox1.Controls.Add(RemAnswerButton);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(385, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 364);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "ОТВЕТЫ";
            // 
            // AnswerBallBox
            // 
            AnswerBallBox.BackColor = Color.FromArgb(192, 255, 255);
            AnswerBallBox.BorderStyle = BorderStyle.FixedSingle;
            AnswerBallBox.ForeColor = SystemColors.WindowText;
            AnswerBallBox.Location = new Point(193, 209);
            AnswerBallBox.Name = "AnswerBallBox";
            AnswerBallBox.Size = new Size(159, 21);
            AnswerBallBox.TabIndex = 31;
            // 
            // AnswerUpdateButton
            // 
            AnswerUpdateButton.BackColor = Color.DeepSkyBlue;
            AnswerUpdateButton.FlatAppearance.BorderSize = 0;
            AnswerUpdateButton.FlatStyle = FlatStyle.Flat;
            AnswerUpdateButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AnswerUpdateButton.ForeColor = Color.White;
            AnswerUpdateButton.Location = new Point(193, 335);
            AnswerUpdateButton.Name = "AnswerUpdateButton";
            AnswerUpdateButton.Size = new Size(159, 23);
            AnswerUpdateButton.TabIndex = 35;
            AnswerUpdateButton.Text = "ИЗМЕНИТЬ";
            AnswerUpdateButton.UseVisualStyleBackColor = false;
            AnswerUpdateButton.Click += AnswerUpdateButton_Click;
            // 
            // AnswerUpdateLabel
            // 
            AnswerUpdateLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            AnswerUpdateLabel.ForeColor = Color.White;
            AnswerUpdateLabel.Location = new Point(193, 272);
            AnswerUpdateLabel.Name = "AnswerUpdateLabel";
            AnswerUpdateLabel.Size = new Size(159, 33);
            AnswerUpdateLabel.TabIndex = 33;
            AnswerUpdateLabel.Text = "ИМЯ ОТВЕТА ДЛЯ ИЗМЕНЕНИЯ";
            AnswerUpdateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerUpdateBox
            // 
            AnswerUpdateBox.BackColor = Color.FromArgb(192, 255, 255);
            AnswerUpdateBox.BorderStyle = BorderStyle.FixedSingle;
            AnswerUpdateBox.Location = new Point(193, 308);
            AnswerUpdateBox.Name = "AnswerUpdateBox";
            AnswerUpdateBox.Size = new Size(159, 21);
            AnswerUpdateBox.TabIndex = 34;
            // 
            // QuestionLabel
            // 
            QuestionLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            QuestionLabel.ForeColor = Color.White;
            QuestionLabel.Location = new Point(193, 61);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(159, 21);
            QuestionLabel.TabIndex = 32;
            QuestionLabel.Text = "ВОПРОС";
            QuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuestionOnLabel
            // 
            QuestionOnLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            QuestionOnLabel.ForeColor = Color.White;
            QuestionOnLabel.Location = new Point(193, 23);
            QuestionOnLabel.Name = "QuestionOnLabel";
            QuestionOnLabel.Size = new Size(159, 34);
            QuestionOnLabel.TabIndex = 31;
            QuestionOnLabel.Text = "ОТНОСЯТСЯ К ВОПРОСУ:";
            QuestionOnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerBallLabel
            // 
            AnswerBallLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            AnswerBallLabel.ForeColor = Color.White;
            AnswerBallLabel.Location = new Point(193, 169);
            AnswerBallLabel.Name = "AnswerBallLabel";
            AnswerBallLabel.Size = new Size(159, 37);
            AnswerBallLabel.TabIndex = 29;
            AnswerBallLabel.Text = "ЧИСЛО БАЛЛОВ ЗА ВЫБОР";
            AnswerBallLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IsTrueAnswerBox
            // 
            IsTrueAnswerBox.FlatAppearance.BorderSize = 0;
            IsTrueAnswerBox.FlatStyle = FlatStyle.Flat;
            IsTrueAnswerBox.Location = new Point(193, 137);
            IsTrueAnswerBox.Name = "IsTrueAnswerBox";
            IsTrueAnswerBox.Size = new Size(159, 19);
            IsTrueAnswerBox.TabIndex = 28;
            IsTrueAnswerBox.Text = "ПРАВИЛЬНЫЙ ОТВЕТ?";
            IsTrueAnswerBox.UseVisualStyleBackColor = true;
            // 
            // AnswerNameLabel
            // 
            AnswerNameLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            AnswerNameLabel.ForeColor = Color.White;
            AnswerNameLabel.Location = new Point(193, 86);
            AnswerNameLabel.Name = "AnswerNameLabel";
            AnswerNameLabel.Size = new Size(159, 21);
            AnswerNameLabel.TabIndex = 26;
            AnswerNameLabel.Text = "ИМЯ ОТВЕТА";
            AnswerNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnswerNameBox
            // 
            AnswerNameBox.BackColor = Color.FromArgb(192, 255, 255);
            AnswerNameBox.BorderStyle = BorderStyle.FixedSingle;
            AnswerNameBox.Location = new Point(193, 110);
            AnswerNameBox.Name = "AnswerNameBox";
            AnswerNameBox.Size = new Size(159, 21);
            AnswerNameBox.TabIndex = 27;
            // 
            // AnswerListBox
            // 
            AnswerListBox.BackColor = Color.DeepSkyBlue;
            AnswerListBox.BorderStyle = BorderStyle.None;
            AnswerListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AnswerListBox.ForeColor = Color.White;
            AnswerListBox.Location = new Point(6, 52);
            AnswerListBox.Name = "AnswerListBox";
            AnswerListBox.Size = new Size(181, 264);
            AnswerListBox.TabIndex = 0;
            AnswerListBox.SelectedIndexChanged += AnswerListBox_SelectedIndexChanged;
            // 
            // AnswerSearchButton
            // 
            AnswerSearchButton.BackColor = Color.DeepSkyBlue;
            AnswerSearchButton.FlatAppearance.BorderSize = 0;
            AnswerSearchButton.FlatStyle = FlatStyle.Flat;
            AnswerSearchButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AnswerSearchButton.ForeColor = Color.White;
            AnswerSearchButton.Location = new Point(112, 23);
            AnswerSearchButton.Name = "AnswerSearchButton";
            AnswerSearchButton.Size = new Size(75, 23);
            AnswerSearchButton.TabIndex = 5;
            AnswerSearchButton.Text = "Поиск";
            AnswerSearchButton.UseVisualStyleBackColor = false;
            AnswerSearchButton.Click += AnswerSearchButton_Click;
            // 
            // AnswerSearchBox
            // 
            AnswerSearchBox.BackColor = Color.FromArgb(192, 255, 255);
            AnswerSearchBox.BorderStyle = BorderStyle.FixedSingle;
            AnswerSearchBox.Location = new Point(6, 25);
            AnswerSearchBox.Name = "AnswerSearchBox";
            AnswerSearchBox.Size = new Size(100, 21);
            AnswerSearchBox.TabIndex = 6;
            // 
            // AddAnswerButton
            // 
            AddAnswerButton.BackColor = Color.DeepSkyBlue;
            AddAnswerButton.FlatAppearance.BorderSize = 0;
            AddAnswerButton.FlatStyle = FlatStyle.Flat;
            AddAnswerButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddAnswerButton.ForeColor = Color.White;
            AddAnswerButton.Location = new Point(193, 236);
            AddAnswerButton.Name = "AddAnswerButton";
            AddAnswerButton.Size = new Size(159, 23);
            AddAnswerButton.TabIndex = 7;
            AddAnswerButton.Text = "ДОБАВИТЬ";
            AddAnswerButton.UseVisualStyleBackColor = false;
            AddAnswerButton.Click += AddAnswerButton_Click;
            // 
            // RemAnswerButton
            // 
            RemAnswerButton.BackColor = Color.DeepSkyBlue;
            RemAnswerButton.FlatAppearance.BorderSize = 0;
            RemAnswerButton.FlatStyle = FlatStyle.Flat;
            RemAnswerButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RemAnswerButton.ForeColor = Color.White;
            RemAnswerButton.Location = new Point(6, 321);
            RemAnswerButton.Name = "RemAnswerButton";
            RemAnswerButton.Size = new Size(181, 37);
            RemAnswerButton.TabIndex = 8;
            RemAnswerButton.Text = "УДАЛИТЬ";
            RemAnswerButton.UseVisualStyleBackColor = false;
            RemAnswerButton.Click += RemAnswerButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(QuestionUpdateLabel);
            groupBox2.Controls.Add(QuestionUpdateBox);
            groupBox2.Controls.Add(QuestionUpdateButton);
            groupBox2.Controls.Add(QuestionNameLabel);
            groupBox2.Controls.Add(QuestionNameBox);
            groupBox2.Controls.Add(QuestionListBox);
            groupBox2.Controls.Add(QuestionSearchButton);
            groupBox2.Controls.Add(QuestionSearchBox);
            groupBox2.Controls.Add(AddQuestionButton);
            groupBox2.Controls.Add(RemQuestionButton);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(14, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(365, 364);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "ВОПРОСЫ";
            // 
            // QuestionUpdateLabel
            // 
            QuestionUpdateLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            QuestionUpdateLabel.ForeColor = Color.White;
            QuestionUpdateLabel.Location = new Point(193, 110);
            QuestionUpdateLabel.Name = "QuestionUpdateLabel";
            QuestionUpdateLabel.Size = new Size(166, 36);
            QuestionUpdateLabel.TabIndex = 29;
            QuestionUpdateLabel.Text = "ИМЯ ВОПРОСА ДЛЯ ИЗМЕНЕНИЯ";
            QuestionUpdateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuestionUpdateBox
            // 
            QuestionUpdateBox.BackColor = Color.FromArgb(192, 255, 255);
            QuestionUpdateBox.BorderStyle = BorderStyle.FixedSingle;
            QuestionUpdateBox.Location = new Point(193, 149);
            QuestionUpdateBox.Name = "QuestionUpdateBox";
            QuestionUpdateBox.Size = new Size(166, 21);
            QuestionUpdateBox.TabIndex = 30;
            // 
            // QuestionUpdateButton
            // 
            QuestionUpdateButton.BackColor = Color.DeepSkyBlue;
            QuestionUpdateButton.FlatAppearance.BorderSize = 0;
            QuestionUpdateButton.FlatStyle = FlatStyle.Flat;
            QuestionUpdateButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuestionUpdateButton.ForeColor = Color.White;
            QuestionUpdateButton.Location = new Point(193, 176);
            QuestionUpdateButton.Name = "QuestionUpdateButton";
            QuestionUpdateButton.Size = new Size(166, 23);
            QuestionUpdateButton.TabIndex = 28;
            QuestionUpdateButton.Text = "ИЗМЕНИТЬ";
            QuestionUpdateButton.UseVisualStyleBackColor = false;
            QuestionUpdateButton.Click += QuestionUpdateButton_Click;
            // 
            // QuestionNameLabel
            // 
            QuestionNameLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            QuestionNameLabel.ForeColor = Color.White;
            QuestionNameLabel.Location = new Point(193, 22);
            QuestionNameLabel.Name = "QuestionNameLabel";
            QuestionNameLabel.Size = new Size(166, 21);
            QuestionNameLabel.TabIndex = 26;
            QuestionNameLabel.Text = "ИМЯ ВОПРОСА";
            QuestionNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuestionNameBox
            // 
            QuestionNameBox.BackColor = Color.FromArgb(192, 255, 255);
            QuestionNameBox.BorderStyle = BorderStyle.FixedSingle;
            QuestionNameBox.Location = new Point(193, 46);
            QuestionNameBox.Name = "QuestionNameBox";
            QuestionNameBox.Size = new Size(166, 21);
            QuestionNameBox.TabIndex = 27;
            // 
            // QuestionListBox
            // 
            QuestionListBox.BackColor = Color.DeepSkyBlue;
            QuestionListBox.BorderStyle = BorderStyle.None;
            QuestionListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuestionListBox.ForeColor = Color.White;
            QuestionListBox.Location = new Point(6, 52);
            QuestionListBox.Name = "QuestionListBox";
            QuestionListBox.Size = new Size(181, 264);
            QuestionListBox.TabIndex = 0;
            QuestionListBox.SelectedIndexChanged += QuestionListBox_SelectedIndexChanged;
            // 
            // QuestionSearchButton
            // 
            QuestionSearchButton.BackColor = Color.DeepSkyBlue;
            QuestionSearchButton.FlatAppearance.BorderSize = 0;
            QuestionSearchButton.FlatStyle = FlatStyle.Flat;
            QuestionSearchButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            QuestionSearchButton.ForeColor = Color.White;
            QuestionSearchButton.Location = new Point(112, 23);
            QuestionSearchButton.Name = "QuestionSearchButton";
            QuestionSearchButton.Size = new Size(75, 23);
            QuestionSearchButton.TabIndex = 5;
            QuestionSearchButton.Text = "Поиск";
            QuestionSearchButton.UseVisualStyleBackColor = false;
            QuestionSearchButton.Click += QuestionSearchButton_Click;
            // 
            // QuestionSearchBox
            // 
            QuestionSearchBox.BackColor = Color.FromArgb(192, 255, 255);
            QuestionSearchBox.BorderStyle = BorderStyle.FixedSingle;
            QuestionSearchBox.Location = new Point(6, 23);
            QuestionSearchBox.Name = "QuestionSearchBox";
            QuestionSearchBox.Size = new Size(100, 21);
            QuestionSearchBox.TabIndex = 6;
            // 
            // AddQuestionButton
            // 
            AddQuestionButton.BackColor = Color.DeepSkyBlue;
            AddQuestionButton.FlatAppearance.BorderSize = 0;
            AddQuestionButton.FlatStyle = FlatStyle.Flat;
            AddQuestionButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddQuestionButton.ForeColor = Color.White;
            AddQuestionButton.Location = new Point(193, 73);
            AddQuestionButton.Name = "AddQuestionButton";
            AddQuestionButton.Size = new Size(166, 23);
            AddQuestionButton.TabIndex = 7;
            AddQuestionButton.Text = "ДОБАВИТЬ";
            AddQuestionButton.UseVisualStyleBackColor = false;
            AddQuestionButton.Click += AddQuestionButton_Click;
            // 
            // RemQuestionButton
            // 
            RemQuestionButton.BackColor = Color.DeepSkyBlue;
            RemQuestionButton.FlatAppearance.BorderSize = 0;
            RemQuestionButton.FlatStyle = FlatStyle.Flat;
            RemQuestionButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RemQuestionButton.ForeColor = Color.White;
            RemQuestionButton.Location = new Point(6, 321);
            RemQuestionButton.Name = "RemQuestionButton";
            RemQuestionButton.Size = new Size(181, 37);
            RemQuestionButton.TabIndex = 8;
            RemQuestionButton.Text = "УДАЛИТЬ";
            RemQuestionButton.UseVisualStyleBackColor = false;
            RemQuestionButton.Click += RemQuestionButton_Click;
            // 
            // CreateSurveyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "CreateSurveyForm";
            StartPosition = FormStartPosition.Manual;
            Text = "CreateSurveyForm";
            Load += CreateSurveyForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AnswerBallBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox QuestionSearchBox;
        private Button QuestionSearchButton;
        private ListBox QuestionListBox;
        private ListBox AnswerListBox;
        private Button RemQuestionButton;
        private Button AddQuestionButton;
        private GroupBox groupBox2;
        private Label QuestionNameLabel;
        private TextBox QuestionNameBox;
        private GroupBox groupBox1;
        private CheckBox IsTrueAnswerBox;
        private Label AnswerNameLabel;
        private TextBox AnswerNameBox;
        private Button AnswerSearchButton;
        private TextBox AnswerSearchBox;
        private Button AddAnswerButton;
        private Button RemAnswerButton;
        private Label AnswerBallLabel;
        private Label SurveyNameLabel;
        private TextBox SurveyNameBox;
        private Label QuestionLabel;
        private Label QuestionOnLabel;
        private Button CreateSurveyButton;
        private Button AnswerUpdateButton;
        private Label AnswerUpdateLabel;
        private TextBox AnswerUpdateBox;
        private Label QuestionUpdateLabel;
        private TextBox QuestionUpdateBox;
        private Button QuestionUpdateButton;
        private NumericUpDown AnswerBallBox;
    }
}
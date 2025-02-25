namespace Questionnaire.Forms
{
    partial class UserSurveiesForm
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
            SearchBox = new TextBox();
            SearchButton = new Button();
            DeleteSurveyButton = new Button();
            EditSurveyButton = new Button();
            button2 = new Button();
            CreateSurveyButton = new Button();
            SurveiesListBox = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(DeleteSurveyButton);
            panel1.Controls.Add(EditSurveyButton);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CreateSurveyButton);
            panel1.Controls.Add(SurveiesListBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 437);
            panel1.TabIndex = 2;
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.FromArgb(192, 255, 255);
            SearchBox.BorderStyle = BorderStyle.FixedSingle;
            SearchBox.Location = new Point(28, 36);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(330, 23);
            SearchBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.DeepSkyBlue;
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(364, 36);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(75, 23);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // DeleteSurveyButton
            // 
            DeleteSurveyButton.BackColor = Color.DeepSkyBlue;
            DeleteSurveyButton.FlatAppearance.BorderSize = 0;
            DeleteSurveyButton.FlatStyle = FlatStyle.Flat;
            DeleteSurveyButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            DeleteSurveyButton.ForeColor = Color.White;
            DeleteSurveyButton.Location = new Point(484, 305);
            DeleteSurveyButton.Name = "DeleteSurveyButton";
            DeleteSurveyButton.Size = new Size(232, 81);
            DeleteSurveyButton.TabIndex = 4;
            DeleteSurveyButton.Text = "Удалить опрос";
            DeleteSurveyButton.UseVisualStyleBackColor = false;
            DeleteSurveyButton.Click += DeleteSurveyButton_Click;
            // 
            // EditSurveyButton
            // 
            EditSurveyButton.BackColor = Color.DeepSkyBlue;
            EditSurveyButton.FlatAppearance.BorderSize = 0;
            EditSurveyButton.FlatStyle = FlatStyle.Flat;
            EditSurveyButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            EditSurveyButton.ForeColor = Color.White;
            EditSurveyButton.Location = new Point(484, 218);
            EditSurveyButton.Name = "EditSurveyButton";
            EditSurveyButton.Size = new Size(232, 81);
            EditSurveyButton.TabIndex = 3;
            EditSurveyButton.Text = "Редактировать опрос";
            EditSurveyButton.UseVisualStyleBackColor = false;
            EditSurveyButton.Click += EditSurveyButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(484, 44);
            button2.Name = "button2";
            button2.Size = new Size(232, 81);
            button2.TabIndex = 2;
            button2.Text = "Просмотерть результаты";
            button2.UseVisualStyleBackColor = false;
            // 
            // CreateSurveyButton
            // 
            CreateSurveyButton.BackColor = Color.DeepSkyBlue;
            CreateSurveyButton.FlatAppearance.BorderSize = 0;
            CreateSurveyButton.FlatStyle = FlatStyle.Flat;
            CreateSurveyButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            CreateSurveyButton.ForeColor = Color.White;
            CreateSurveyButton.Location = new Point(484, 131);
            CreateSurveyButton.Name = "CreateSurveyButton";
            CreateSurveyButton.Size = new Size(232, 81);
            CreateSurveyButton.TabIndex = 1;
            CreateSurveyButton.Text = "Создать опрос";
            CreateSurveyButton.UseVisualStyleBackColor = false;
            CreateSurveyButton.Click += CreateSurveyButton_Click;
            // 
            // SurveiesListBox
            // 
            SurveiesListBox.BackColor = Color.DeepSkyBlue;
            SurveiesListBox.BorderStyle = BorderStyle.None;
            SurveiesListBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurveiesListBox.ForeColor = Color.White;
            SurveiesListBox.Location = new Point(28, 65);
            SurveiesListBox.Name = "SurveiesListBox";
            SurveiesListBox.Size = new Size(411, 336);
            SurveiesListBox.TabIndex = 0;
            // 
            // UserSurveiesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UserSurveiesForm";
            StartPosition = FormStartPosition.Manual;
            Text = "UserSurveysForm";
            Load += UserSurveysForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox SearchBox;
        private Button SearchButton;
        private Button DeleteSurveyButton;
        private Button EditSurveyButton;
        private Button button2;
        private Button CreateSurveyButton;
        private ListBox SurveiesListBox;
    }
}
﻿namespace Questionnaire.Forms
{
    partial class UserMenuForm
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
            SurveiesListBox = new ListBox();
            panel1 = new Panel();
            SearchBox = new TextBox();
            SearchButton = new Button();
            AccountButton = new Button();
            UserSurveiesButton = new Button();
            OpenSurveyButton = new Button();
            CreateSurveyButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SurveiesListBox
            // 
            SurveiesListBox.BackColor = Color.DeepSkyBlue;
            SurveiesListBox.BorderStyle = BorderStyle.None;
            SurveiesListBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurveiesListBox.ForeColor = Color.White;
            SurveiesListBox.Location = new Point(28, 65);
            SurveiesListBox.Name = "SurveiesListBox";
            SurveiesListBox.Size = new Size(411, 330);
            SurveiesListBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(AccountButton);
            panel1.Controls.Add(UserSurveiesButton);
            panel1.Controls.Add(OpenSurveyButton);
            panel1.Controls.Add(CreateSurveyButton);
            panel1.Controls.Add(SurveiesListBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 437);
            panel1.TabIndex = 1;
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
            // AccountButton
            // 
            AccountButton.BackColor = Color.DeepSkyBlue;
            AccountButton.FlatAppearance.BorderSize = 0;
            AccountButton.FlatStyle = FlatStyle.Flat;
            AccountButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            AccountButton.ForeColor = Color.White;
            AccountButton.Location = new Point(484, 305);
            AccountButton.Name = "AccountButton";
            AccountButton.Size = new Size(232, 81);
            AccountButton.TabIndex = 4;
            AccountButton.Text = "Личный кабинет";
            AccountButton.UseVisualStyleBackColor = false;
            AccountButton.Click += AccountButton_Click;
            // 
            // UserSurveiesButton
            // 
            UserSurveiesButton.BackColor = Color.DeepSkyBlue;
            UserSurveiesButton.FlatAppearance.BorderSize = 0;
            UserSurveiesButton.FlatStyle = FlatStyle.Flat;
            UserSurveiesButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            UserSurveiesButton.ForeColor = Color.White;
            UserSurveiesButton.Location = new Point(484, 218);
            UserSurveiesButton.Name = "UserSurveiesButton";
            UserSurveiesButton.Size = new Size(232, 81);
            UserSurveiesButton.TabIndex = 3;
            UserSurveiesButton.Text = "Мои опросы";
            UserSurveiesButton.UseVisualStyleBackColor = false;
            UserSurveiesButton.Click += UserSurveiesButton_Click;
            // 
            // OpenSurveyButton
            // 
            OpenSurveyButton.BackColor = Color.DeepSkyBlue;
            OpenSurveyButton.FlatAppearance.BorderSize = 0;
            OpenSurveyButton.FlatStyle = FlatStyle.Flat;
            OpenSurveyButton.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            OpenSurveyButton.ForeColor = Color.White;
            OpenSurveyButton.Location = new Point(484, 44);
            OpenSurveyButton.Name = "OpenSurveyButton";
            OpenSurveyButton.Size = new Size(232, 81);
            OpenSurveyButton.TabIndex = 2;
            OpenSurveyButton.Text = "Открыть опрос";
            OpenSurveyButton.UseVisualStyleBackColor = false;
            OpenSurveyButton.Click += OpenSurveyButton_Click;
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
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UserMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionnaire";
            Load += UserMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox SurveiesListBox;
        private Panel panel1;
        private Button UserSurveiesButton;
        private Button OpenSurveyButton;
        private Button CreateSurveyButton;
        private Button AccountButton;
        private TextBox SearchBox;
        private Button SearchButton;
    }
}
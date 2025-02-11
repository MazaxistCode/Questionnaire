namespace Questionnaire
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(AccountButton);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
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
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(484, 218);
            button3.Name = "button3";
            button3.Size = new Size(232, 81);
            button3.TabIndex = 3;
            button3.Text = "Мои опросы";
            button3.UseVisualStyleBackColor = false;
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
            button2.Text = "Открыть опрос";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(484, 131);
            button1.Name = "button1";
            button1.Size = new Size(232, 81);
            button1.TabIndex = 1;
            button1.Text = "Создать опрос";
            button1.UseVisualStyleBackColor = false;
            // 
            // UserMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "UserMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMenu";
            Load += UserMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox SurveiesListBox;
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button AccountButton;
        private TextBox SearchBox;
        private Button SearchButton;
    }
}
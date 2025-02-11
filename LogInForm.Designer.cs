namespace Questionnaire
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginBox = new TextBox();
            PassBox = new TextBox();
            InButton = new Button();
            LoginLabel = new Label();
            PassLabel = new Label();
            OnButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginBox
            // 
            LoginBox.Anchor = AnchorStyles.None;
            LoginBox.BackColor = Color.FromArgb(192, 255, 255);
            LoginBox.BorderStyle = BorderStyle.FixedSingle;
            LoginBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            LoginBox.Location = new Point(164, 33);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(157, 21);
            LoginBox.TabIndex = 18;
            // 
            // PassBox
            // 
            PassBox.Anchor = AnchorStyles.None;
            PassBox.BackColor = Color.FromArgb(192, 255, 255);
            PassBox.BorderStyle = BorderStyle.FixedSingle;
            PassBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            PassBox.Location = new Point(164, 81);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(157, 21);
            PassBox.TabIndex = 19;
            // 
            // InButton
            // 
            InButton.Anchor = AnchorStyles.None;
            InButton.BackColor = Color.DeepSkyBlue;
            InButton.FlatAppearance.BorderColor = Color.White;
            InButton.FlatAppearance.BorderSize = 0;
            InButton.FlatStyle = FlatStyle.Flat;
            InButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InButton.ForeColor = Color.White;
            InButton.Location = new Point(118, 129);
            InButton.Name = "InButton";
            InButton.Size = new Size(125, 29);
            InButton.TabIndex = 20;
            InButton.Text = "Авторизация";
            InButton.UseVisualStyleBackColor = false;
            InButton.Click += InButton_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(30, 32);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(110, 21);
            LoginLabel.TabIndex = 21;
            LoginLabel.Text = "ЛОГИН / ПОЧТА";
            LoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PassLabel
            // 
            PassLabel.Anchor = AnchorStyles.None;
            PassLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassLabel.ForeColor = Color.White;
            PassLabel.Location = new Point(30, 80);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(110, 21);
            PassLabel.TabIndex = 22;
            PassLabel.Text = "ПАРОЛЬ";
            PassLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OnButton
            // 
            OnButton.Anchor = AnchorStyles.None;
            OnButton.BackColor = Color.DeepSkyBlue;
            OnButton.FlatAppearance.BorderColor = Color.White;
            OnButton.FlatAppearance.BorderSize = 0;
            OnButton.FlatStyle = FlatStyle.Flat;
            OnButton.Font = new Font("Times New Roman", 9.25F, FontStyle.Bold);
            OnButton.ForeColor = Color.White;
            OnButton.Location = new Point(135, 164);
            OnButton.Name = "OnButton";
            OnButton.Size = new Size(91, 25);
            OnButton.TabIndex = 28;
            OnButton.Text = "Регистрация";
            OnButton.UseVisualStyleBackColor = false;
            OnButton.Click += OnButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(OnButton);
            panel1.Controls.Add(LoginBox);
            panel1.Controls.Add(PassLabel);
            panel1.Controls.Add(PassBox);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(InButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 212);
            panel1.TabIndex = 29;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(384, 236);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionnaire";
            Load += StartForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public TextBox LoginBox;
        private TextBox PassBox;
        private Button InButton;
        private Label LoginLabel;
        private Label PassLabel;
        private Button OnButton;
        private Panel panel1;
    }
}

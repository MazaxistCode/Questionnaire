namespace Questionnaire.Forms
{
    partial class LogOnForm
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
            PassLabel2 = new Label();
            PassBox2 = new TextBox();
            LoginLabel = new Label();
            InButton = new Button();
            LoginBox = new TextBox();
            OnButton = new Button();
            PassLabel = new Label();
            PassBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(PassLabel2);
            panel1.Controls.Add(PassBox2);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(InButton);
            panel1.Controls.Add(LoginBox);
            panel1.Controls.Add(OnButton);
            panel1.Controls.Add(PassLabel);
            panel1.Controls.Add(PassBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 212);
            panel1.TabIndex = 30;
            // 
            // PassLabel2
            // 
            PassLabel2.Anchor = AnchorStyles.None;
            PassLabel2.BackColor = Color.DodgerBlue;
            PassLabel2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassLabel2.ForeColor = Color.White;
            PassLabel2.Location = new Point(65, 85);
            PassLabel2.Name = "PassLabel2";
            PassLabel2.Size = new Size(60, 21);
            PassLabel2.TabIndex = 38;
            PassLabel2.Text = "ПАРОЛЬ";
            PassLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PassBox2
            // 
            PassBox2.Anchor = AnchorStyles.None;
            PassBox2.BackColor = Color.FromArgb(192, 255, 255);
            PassBox2.BorderStyle = BorderStyle.FixedSingle;
            PassBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            PassBox2.Location = new Point(149, 86);
            PassBox2.Name = "PassBox2";
            PassBox2.PasswordChar = '*';
            PassBox2.Size = new Size(157, 21);
            PassBox2.TabIndex = 37;
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.DodgerBlue;
            LoginLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(65, 33);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(60, 21);
            LoginLabel.TabIndex = 34;
            LoginLabel.Text = "ПОЧТА";
            LoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // InButton
            // 
            InButton.Anchor = AnchorStyles.None;
            InButton.BackColor = Color.DeepSkyBlue;
            InButton.FlatAppearance.BorderColor = Color.White;
            InButton.FlatAppearance.BorderSize = 0;
            InButton.FlatStyle = FlatStyle.Flat;
            InButton.Font = new Font("Times New Roman", 9.25F, FontStyle.Bold);
            InButton.ForeColor = Color.White;
            InButton.Location = new Point(135, 164);
            InButton.Name = "InButton";
            InButton.Size = new Size(91, 25);
            InButton.TabIndex = 36;
            InButton.Text = "Авторизация";
            InButton.UseVisualStyleBackColor = false;
            InButton.Click += InButton_Click;
            // 
            // LoginBox
            // 
            LoginBox.Anchor = AnchorStyles.None;
            LoginBox.BackColor = Color.FromArgb(192, 255, 255);
            LoginBox.BorderStyle = BorderStyle.FixedSingle;
            LoginBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            LoginBox.Location = new Point(149, 32);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(157, 21);
            LoginBox.TabIndex = 31;
            // 
            // OnButton
            // 
            OnButton.Anchor = AnchorStyles.None;
            OnButton.BackColor = Color.DeepSkyBlue;
            OnButton.FlatAppearance.BorderColor = Color.White;
            OnButton.FlatAppearance.BorderSize = 0;
            OnButton.FlatStyle = FlatStyle.Flat;
            OnButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OnButton.ForeColor = Color.White;
            OnButton.Location = new Point(118, 129);
            OnButton.Name = "OnButton";
            OnButton.Size = new Size(125, 29);
            OnButton.TabIndex = 33;
            OnButton.Text = "Регистрация";
            OnButton.UseVisualStyleBackColor = false;
            OnButton.Click += OnButton_Click;
            // 
            // PassLabel
            // 
            PassLabel.Anchor = AnchorStyles.None;
            PassLabel.BackColor = Color.DodgerBlue;
            PassLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassLabel.ForeColor = Color.White;
            PassLabel.Location = new Point(65, 58);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(60, 21);
            PassLabel.TabIndex = 35;
            PassLabel.Text = "ПАРОЛЬ";
            PassLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PassBox
            // 
            PassBox.Anchor = AnchorStyles.None;
            PassBox.BackColor = Color.FromArgb(192, 255, 255);
            PassBox.BorderStyle = BorderStyle.FixedSingle;
            PassBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            PassBox.Location = new Point(149, 59);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(157, 21);
            PassBox.TabIndex = 32;
            // 
            // LogOnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(384, 236);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "LogOnForm";
            StartPosition = FormStartPosition.Manual;
            Text = "LogOnForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button InButton;
        public TextBox LoginBox;
        private Label PassLabel;
        private TextBox PassBox;
        private Label LoginLabel;
        private Button OnButton;
        private Label PassLabel2;
        private TextBox PassBox2;
    }
}
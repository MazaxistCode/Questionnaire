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
            loginBox = new TextBox();
            passBox = new TextBox();
            InButton = new Button();
            loginLabel = new Label();
            passLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Location = new Point(141, 71);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(258, 23);
            loginBox.TabIndex = 18;
            // 
            // passBox
            // 
            passBox.Location = new Point(141, 100);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(258, 23);
            passBox.TabIndex = 19;
            // 
            // InButton
            // 
            InButton.Location = new Point(141, 129);
            InButton.Name = "InButton";
            InButton.Size = new Size(258, 23);
            InButton.TabIndex = 20;
            InButton.Text = "Регистрация / авторизация";
            InButton.UseVisualStyleBackColor = true;
            InButton.Click += InButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(58, 74);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(77, 15);
            loginLabel.TabIndex = 21;
            loginLabel.Text = "логин/почта";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(88, 103);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(47, 15);
            passLabel.TabIndex = 22;
            passLabel.Text = "пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 155);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 26;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(label1);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Controls.Add(InButton);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            MaximizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Questionnaire";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public TextBox loginBox;
        private TextBox passBox;
        private Button InButton;
        private Label loginLabel;
        private Label passLabel;
        private Label label1;
    }
}

namespace Questionnaire
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
            passLabel = new Label();
            loginLabel = new Label();
            OnButton = new Button();
            passBox = new TextBox();
            loginBox = new TextBox();
            SuspendLayout();
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(102, 222);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(47, 15);
            passLabel.TabIndex = 27;
            passLabel.Text = "пароль";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(72, 193);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(77, 15);
            loginLabel.TabIndex = 26;
            loginLabel.Text = "логин/почта";
            // 
            // OnButton
            // 
            OnButton.Location = new Point(155, 248);
            OnButton.Name = "OnButton";
            OnButton.Size = new Size(258, 23);
            OnButton.TabIndex = 25;
            OnButton.Text = "Регистрация / авторизация";
            OnButton.UseVisualStyleBackColor = true;
            OnButton.Click += OnButton_Click;
            // 
            // passBox
            // 
            passBox.Location = new Point(155, 219);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(258, 23);
            passBox.TabIndex = 24;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(155, 190);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(258, 23);
            loginBox.TabIndex = 23;
            // 
            // LogOnForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Controls.Add(OnButton);
            Controls.Add(passBox);
            Controls.Add(loginBox);
            MaximizeBox = false;
            Name = "LogOnForm";
            StartPosition = FormStartPosition.Manual;
            Text = "LogOnForm";
            Load += LogOnForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passLabel;
        private Label loginLabel;
        private Button OnButton;
        private TextBox passBox;
        public TextBox loginBox;
    }
}
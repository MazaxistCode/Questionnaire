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
            button2 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginBox
            // 
            loginBox.Anchor = AnchorStyles.None;
            loginBox.BackColor = Color.White;
            loginBox.BorderStyle = BorderStyle.FixedSingle;
            loginBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            loginBox.Location = new Point(131, 10);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(223, 21);
            loginBox.TabIndex = 18;
            // 
            // passBox
            // 
            passBox.Anchor = AnchorStyles.None;
            passBox.BackColor = Color.White;
            passBox.BorderStyle = BorderStyle.FixedSingle;
            passBox.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            passBox.Location = new Point(131, 53);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(223, 21);
            passBox.TabIndex = 19;
            // 
            // InButton
            // 
            InButton.Anchor = AnchorStyles.None;
            InButton.BackColor = Color.FromArgb(192, 192, 255);
            InButton.FlatAppearance.BorderSize = 0;
            InButton.FlatStyle = FlatStyle.Flat;
            InButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            InButton.Location = new Point(0, 95);
            InButton.Name = "InButton";
            InButton.Size = new Size(354, 40);
            InButton.TabIndex = 20;
            InButton.Text = "Авторизация";
            InButton.UseVisualStyleBackColor = false;
            InButton.Click += InButton_Click;
            // 
            // loginLabel
            // 
            loginLabel.Anchor = AnchorStyles.None;
            loginLabel.BackColor = Color.FromArgb(192, 192, 255);
            loginLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            loginLabel.Location = new Point(0, 10);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(125, 21);
            loginLabel.TabIndex = 21;
            loginLabel.Text = "ЛОГИН / ПОЧТА";
            loginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // passLabel
            // 
            passLabel.Anchor = AnchorStyles.None;
            passLabel.BackColor = Color.FromArgb(192, 192, 255);
            passLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passLabel.Location = new Point(0, 53);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(125, 21);
            passLabel.TabIndex = 22;
            passLabel.Text = "ПАРОЛЬ";
            passLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(0, 155);
            button2.Name = "button2";
            button2.Size = new Size(354, 24);
            button2.TabIndex = 28;
            button2.Text = "Зарегистрироваться";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(loginBox);
            panel1.Controls.Add(passLabel);
            panel1.Controls.Add(passBox);
            panel1.Controls.Add(loginLabel);
            panel1.Controls.Add(InButton);
            panel1.Location = new Point(15, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 202);
            panel1.TabIndex = 29;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(0, 182);
            label4.Name = "label4";
            label4.Size = new Size(354, 15);
            label4.TabIndex = 32;
            label4.Text = "Для создания учётной записи!";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(0, 137);
            label3.Name = "label3";
            label3.Size = new Size(354, 15);
            label3.TabIndex = 31;
            label3.Text = "Для входа в учётную запись!";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 35);
            label2.Name = "label2";
            label2.Size = new Size(354, 15);
            label2.TabIndex = 30;
            label2.Text = "Без логина мы не сможем понять, что Вы это Вы!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 77);
            label1.Name = "label1";
            label1.Size = new Size(354, 15);
            label1.TabIndex = 29;
            label1.Text = "Пароль требуется для того, чтобы обезопасить ваши данные!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
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
        public TextBox loginBox;
        private TextBox passBox;
        private Button InButton;
        private Label loginLabel;
        private Label passLabel;
        private Button button2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
    }
}

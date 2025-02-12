namespace Questionnaire
{
    partial class AccountForm
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
            SaveButton = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            AvatarPictureBox = new PictureBox();
            AvatarButton = new Button();
            groupBox2 = new GroupBox();
            PassLabel = new Label();
            PassBox = new TextBox();
            PassLabel2 = new Label();
            PassBox2 = new TextBox();
            groupBox1 = new GroupBox();
            LoginLabel = new Label();
            LoginBox = new TextBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 287);
            panel1.TabIndex = 2;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DeepSkyBlue;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(276, 234);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(284, 35);
            SaveButton.TabIndex = 31;
            SaveButton.Text = "Применить изменения";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(AvatarPictureBox);
            groupBox3.Controls.Add(AvatarButton);
            groupBox3.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(20, 17);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(220, 252);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "АВАТАР";
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 6.5F, FontStyle.Bold);
            label1.Location = new Point(6, 212);
            label1.Name = "label1";
            label1.Size = new Size(208, 37);
            label1.TabIndex = 25;
            label1.Text = "изменение фото вступает в силу мгновенно и не требудет подтверждения с почты";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AvatarPictureBox
            // 
            AvatarPictureBox.Location = new Point(32, 20);
            AvatarPictureBox.Name = "AvatarPictureBox";
            AvatarPictureBox.Size = new Size(160, 160);
            AvatarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AvatarPictureBox.TabIndex = 24;
            AvatarPictureBox.TabStop = false;
            // 
            // AvatarButton
            // 
            AvatarButton.BackColor = Color.DeepSkyBlue;
            AvatarButton.FlatAppearance.BorderSize = 0;
            AvatarButton.FlatStyle = FlatStyle.Flat;
            AvatarButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AvatarButton.ForeColor = Color.White;
            AvatarButton.Location = new Point(32, 186);
            AvatarButton.Name = "AvatarButton";
            AvatarButton.Size = new Size(160, 23);
            AvatarButton.TabIndex = 23;
            AvatarButton.Text = "Изменить фото";
            AvatarButton.UseVisualStyleBackColor = false;
            AvatarButton.Click += AvatarButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PassLabel);
            groupBox2.Controls.Add(PassBox);
            groupBox2.Controls.Add(PassLabel2);
            groupBox2.Controls.Add(PassBox2);
            groupBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(276, 112);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 94);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "ПАРОЛЬ";
            // 
            // PassLabel
            // 
            PassLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            PassLabel.ForeColor = Color.White;
            PassLabel.Location = new Point(17, 27);
            PassLabel.Name = "PassLabel";
            PassLabel.Size = new Size(117, 21);
            PassLabel.TabIndex = 26;
            PassLabel.Text = "НОВЫЙ ПАРОЛЬ";
            PassLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PassBox
            // 
            PassBox.BackColor = Color.FromArgb(192, 255, 255);
            PassBox.BorderStyle = BorderStyle.FixedSingle;
            PassBox.Location = new Point(140, 27);
            PassBox.Name = "PassBox";
            PassBox.PasswordChar = '*';
            PassBox.Size = new Size(100, 21);
            PassBox.TabIndex = 27;
            // 
            // PassLabel2
            // 
            PassLabel2.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            PassLabel2.ForeColor = Color.White;
            PassLabel2.Location = new Point(17, 56);
            PassLabel2.Name = "PassLabel2";
            PassLabel2.Size = new Size(117, 21);
            PassLabel2.TabIndex = 32;
            PassLabel2.Text = "СТАРЫЙ ПАРОЛЬ";
            PassLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PassBox2
            // 
            PassBox2.BackColor = Color.FromArgb(192, 255, 255);
            PassBox2.BorderStyle = BorderStyle.FixedSingle;
            PassBox2.Location = new Point(140, 56);
            PassBox2.Name = "PassBox2";
            PassBox2.PasswordChar = '*';
            PassBox2.Size = new Size(100, 21);
            PassBox2.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LoginLabel);
            groupBox1.Controls.Add(LoginBox);
            groupBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(276, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 60);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "ЛОГИН";
            // 
            // LoginLabel
            // 
            LoginLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(17, 24);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(117, 21);
            LoginLabel.TabIndex = 22;
            LoginLabel.Text = "НОВЫЙ ЛОГИН";
            LoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LoginBox
            // 
            LoginBox.BackColor = Color.FromArgb(192, 255, 255);
            LoginBox.BorderStyle = BorderStyle.FixedSingle;
            LoginBox.Location = new Point(140, 24);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(100, 21);
            LoginBox.TabIndex = 25;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(609, 311);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AccountForm";
            StartPosition = FormStartPosition.Manual;
            Text = "AccountForm";
            Load += AccountForm_Load;
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AvatarPictureBox).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LoginLabel;
        private Button AvatarButton;
        public PictureBox AvatarPictureBox;
        private TextBox PassBox;
        private Label PassLabel;
        private TextBox LoginBox;
        private GroupBox groupBox1;
        private Label PassLabel2;
        private Button SaveButton;
        private TextBox PassBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label1;
    }
}
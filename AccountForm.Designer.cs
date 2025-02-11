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
            pictureBox1 = new PictureBox();
            NewImageButton = new Button();
            LoginLabel = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(NewImageButton);
            panel1.Controls.Add(LoginLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 437);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // NewImageButton
            // 
            NewImageButton.Location = new Point(18, 199);
            NewImageButton.Name = "NewImageButton";
            NewImageButton.Size = new Size(175, 23);
            NewImageButton.TabIndex = 23;
            NewImageButton.Text = "Изменить фото";
            NewImageButton.UseVisualStyleBackColor = true;
            NewImageButton.Click += NewImageButton_Click;
            // 
            // LoginLabel
            // 
            LoginLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            LoginLabel.ForeColor = Color.White;
            LoginLabel.Location = new Point(484, 214);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(110, 21);
            LoginLabel.TabIndex = 22;
            LoginLabel.Text = "ЛОГИН / ПОЧТА";
            LoginLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            Name = "AccountForm";
            StartPosition = FormStartPosition.Manual;
            Text = "AccountForm";
            Load += AccountForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LoginLabel;
        private Button NewImageButton;
        public PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}
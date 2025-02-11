namespace Questionnaire
{
    partial class EnterCodeForm
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
            codeLabel = new Label();
            codeBox = new TextBox();
            codeButton = new Button();
            manualLabel = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            codeLabel.ForeColor = Color.White;
            codeLabel.Location = new Point(94, 81);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(36, 23);
            codeLabel.TabIndex = 28;
            codeLabel.Text = "КОД";
            codeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // codeBox
            // 
            codeBox.BackColor = Color.FromArgb(192, 255, 255);
            codeBox.BorderStyle = BorderStyle.FixedSingle;
            codeBox.Location = new Point(147, 81);
            codeBox.Name = "codeBox";
            codeBox.Size = new Size(117, 23);
            codeBox.TabIndex = 27;
            // 
            // codeButton
            // 
            codeButton.BackColor = Color.DeepSkyBlue;
            codeButton.FlatAppearance.BorderSize = 0;
            codeButton.FlatStyle = FlatStyle.Flat;
            codeButton.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            codeButton.ForeColor = Color.White;
            codeButton.Location = new Point(94, 124);
            codeButton.Name = "codeButton";
            codeButton.Size = new Size(170, 34);
            codeButton.TabIndex = 26;
            codeButton.Text = "Ввести код с почты";
            codeButton.UseVisualStyleBackColor = false;
            codeButton.Click += codeButton_Click;
            // 
            // manualLabel
            // 
            manualLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            manualLabel.FlatStyle = FlatStyle.Flat;
            manualLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            manualLabel.ForeColor = Color.White;
            manualLabel.Location = new Point(0, 17);
            manualLabel.Name = "manualLabel";
            manualLabel.Size = new Size(360, 49);
            manualLabel.TabIndex = 29;
            manualLabel.Text = "Вам было отправлен код на указанную почту,\r\nвведите его в предназначенное для кода поле,\r\nпосле чело нажмите на кнопку.";
            manualLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(codeButton);
            panel1.Controls.Add(codeBox);
            panel1.Controls.Add(manualLabel);
            panel1.Controls.Add(codeLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 212);
            panel1.TabIndex = 31;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 9.25F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(105, 164);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 30;
            button1.Text = "Ввёл не ту почту";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EnterCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(384, 236);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "EnterCodeForm";
            StartPosition = FormStartPosition.Manual;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label codeLabel;
        public TextBox codeBox;
        internal Button codeButton;
        private Label manualLabel;
        private Panel panel1;
        internal Button button1;
    }
}
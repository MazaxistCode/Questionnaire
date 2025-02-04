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
            label1 = new Label();
            SuspendLayout();
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new Point(80, 189);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new Size(26, 15);
            codeLabel.TabIndex = 28;
            codeLabel.Text = "код";
            // 
            // codeBox
            // 
            codeBox.Location = new Point(112, 186);
            codeBox.Name = "codeBox";
            codeBox.Size = new Size(258, 23);
            codeBox.TabIndex = 27;
            // 
            // codeButton
            // 
            codeButton.Location = new Point(112, 215);
            codeButton.Name = "codeButton";
            codeButton.Size = new Size(258, 23);
            codeButton.TabIndex = 26;
            codeButton.Text = "ввести код с почты";
            codeButton.UseVisualStyleBackColor = true;
            codeButton.Click += codeButton_Click;
            // 
            // manualLabel
            // 
            manualLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            manualLabel.FlatStyle = FlatStyle.Flat;
            manualLabel.Location = new Point(0, 20);
            manualLabel.Name = "manualLabel";
            manualLabel.Size = new Size(484, 45);
            manualLabel.TabIndex = 29;
            manualLabel.Text = "Вам было отправлен код на указанную почту,\r\nвведите его в предназначенное для кода поле,\r\nпосле чело нажмите на кнопку.";
            manualLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 241);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 30;
            label1.Text = "Ввёл не ту почту";
            label1.Click += label1_Click;
            // 
            // EnterCodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(label1);
            Controls.Add(manualLabel);
            Controls.Add(codeLabel);
            Controls.Add(codeBox);
            Controls.Add(codeButton);
            MaximizeBox = false;
            Name = "EnterCodeForm";
            StartPosition = FormStartPosition.Manual;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label codeLabel;
        public TextBox codeBox;
        internal Button codeButton;
        private Label manualLabel;
        private Label label1;
    }
}
namespace Questionnaire
{
    partial class Test
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 16);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "пользователи";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(526, 16);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "роль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 16);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "опрос";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(737, 16);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 4;
            label4.Text = "вопросы на опрос";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(852, 16);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 5;
            label5.Text = "ответы на вопросы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(971, 16);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 6;
            label6.Text = "ответы на опрос";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1075, 16);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 7;
            label7.Text = "ответ на вопрос";
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 357);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Test";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Test";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
namespace Questionnaire
{
    partial class StartForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 15);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 15);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 15);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(674, 15);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(788, 15);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 16;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(879, 15);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 17;
            label7.Text = "label7";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(474, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(474, 300);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(474, 329);
            button1.Name = "button1";
            button1.Size = new Size(258, 23);
            button1.TabIndex = 20;
            button1.Text = "Регистрация / авторизация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(428, 274);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 21;
            label8.Text = "логин";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(421, 303);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 22;
            label9.Text = "пароль";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 583);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "Questionnaire";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label8;
        private Label label9;
    }
}

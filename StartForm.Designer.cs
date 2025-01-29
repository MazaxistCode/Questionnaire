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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            button3 = new Button();
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
            label8.Location = new Point(391, 274);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 21;
            label8.Text = "логин/почта";
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
            // button2
            // 
            button2.Location = new Point(474, 387);
            button2.Name = "button2";
            button2.Size = new Size(258, 23);
            button2.TabIndex = 23;
            button2.Text = "ввести код с почты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(474, 358);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 23);
            textBox3.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 361);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 25;
            label2.Text = "код";
            // 
            // button3
            // 
            button3.Location = new Point(904, 548);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 26;
            button3.Text = "обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 583);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "Questionnaire";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label8;
        private Label label9;
        private Button button2;
        public TextBox textBox3;
        private Label label2;
        private Button button3;
    }
}

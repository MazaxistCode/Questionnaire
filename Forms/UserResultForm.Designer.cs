namespace Questionnaire.Forms
{
    partial class UserResultForm
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
            UserBallLabel = new Label();
            SurveyBallLabel = new Label();
            ResultBar = new ProgressBar();
            CloseButton = new Button();
            SurveyNameLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(UserBallLabel);
            panel1.Controls.Add(SurveyBallLabel);
            panel1.Controls.Add(ResultBar);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(SurveyNameLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 437);
            panel1.TabIndex = 4;
            // 
            // UserBallLabel
            // 
            UserBallLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UserBallLabel.ForeColor = Color.White;
            UserBallLabel.Location = new Point(130, 204);
            UserBallLabel.Name = "UserBallLabel";
            UserBallLabel.Size = new Size(68, 25);
            UserBallLabel.TabIndex = 36;
            UserBallLabel.Text = "User";
            UserBallLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SurveyBallLabel
            // 
            SurveyBallLabel.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurveyBallLabel.ForeColor = Color.White;
            SurveyBallLabel.Location = new Point(568, 204);
            SurveyBallLabel.Name = "SurveyBallLabel";
            SurveyBallLabel.Size = new Size(68, 25);
            SurveyBallLabel.TabIndex = 35;
            SurveyBallLabel.Text = "Max";
            SurveyBallLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ResultBar
            // 
            ResultBar.ForeColor = Color.DodgerBlue;
            ResultBar.Location = new Point(204, 204);
            ResultBar.Name = "ResultBar";
            ResultBar.Size = new Size(358, 25);
            ResultBar.TabIndex = 34;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.DeepSkyBlue;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(312, 235);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(139, 23);
            CloseButton.TabIndex = 33;
            CloseButton.Text = "ВЫЙТИ В МЕНЮ.";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // SurveyNameLabel
            // 
            SurveyNameLabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SurveyNameLabel.ForeColor = Color.White;
            SurveyNameLabel.Location = new Point(178, 161);
            SurveyNameLabel.Name = "SurveyNameLabel";
            SurveyNameLabel.Size = new Size(412, 40);
            SurveyNameLabel.TabIndex = 28;
            SurveyNameLabel.Text = "ИМЯ ОПРОСА";
            SurveyNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UserResultForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Questionnaire";
            Load += UserResultForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label SurveyBallLabel;
        private ProgressBar ResultBar;
        private Button CloseButton;
        private Label SurveyNameLabel;
        private Label UserBallLabel;
    }
}
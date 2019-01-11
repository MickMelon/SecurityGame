namespace SecurityGame.Views
{
    partial class GameView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_QuestionCountDesc = new System.Windows.Forms.Label();
            this.Button_Answer2 = new System.Windows.Forms.Button();
            this.Button_Answer1 = new System.Windows.Forms.Button();
            this.Label_ReputationText = new System.Windows.Forms.Label();
            this.Label_QuestionCount = new System.Windows.Forms.Label();
            this.Label_Question = new System.Windows.Forms.Label();
            this.Label_VirusText = new System.Windows.Forms.Label();
            this.Label_Reputation = new System.Windows.Forms.Label();
            this.Label_Virus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SecurityGame.Properties.Resources.community_image_1408560533;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Label_Virus);
            this.panel1.Controls.Add(this.Label_Reputation);
            this.panel1.Controls.Add(this.Label_QuestionCountDesc);
            this.panel1.Controls.Add(this.Button_Answer2);
            this.panel1.Controls.Add(this.Button_Answer1);
            this.panel1.Controls.Add(this.Label_ReputationText);
            this.panel1.Controls.Add(this.Label_QuestionCount);
            this.panel1.Controls.Add(this.Label_Question);
            this.panel1.Controls.Add(this.Label_VirusText);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 6;
            // 
            // Label_QuestionCountDesc
            // 
            this.Label_QuestionCountDesc.AutoSize = true;
            this.Label_QuestionCountDesc.BackColor = System.Drawing.Color.Transparent;
            this.Label_QuestionCountDesc.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_QuestionCountDesc.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_QuestionCountDesc.Location = new System.Drawing.Point(339, 27);
            this.Label_QuestionCountDesc.Name = "Label_QuestionCountDesc";
            this.Label_QuestionCountDesc.Size = new System.Drawing.Size(135, 32);
            this.Label_QuestionCountDesc.TabIndex = 10;
            this.Label_QuestionCountDesc.Text = "Question";
            // 
            // Button_Answer2
            // 
            this.Button_Answer2.BackColor = System.Drawing.Color.Transparent;
            this.Button_Answer2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Answer2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Answer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Answer2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Answer2.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_Answer2.Location = new System.Drawing.Point(40, 368);
            this.Button_Answer2.Name = "Button_Answer2";
            this.Button_Answer2.Size = new System.Drawing.Size(700, 70);
            this.Button_Answer2.TabIndex = 5;
            this.Button_Answer2.Text = "The second answer will be shown here.";
            this.Button_Answer2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Button_Answer2.UseVisualStyleBackColor = false;
            this.Button_Answer2.Click += new System.EventHandler(this.Button_Answer2_Click);
            // 
            // Button_Answer1
            // 
            this.Button_Answer1.BackColor = System.Drawing.Color.Transparent;
            this.Button_Answer1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Answer1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Answer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Answer1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Answer1.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_Answer1.Location = new System.Drawing.Point(40, 295);
            this.Button_Answer1.Name = "Button_Answer1";
            this.Button_Answer1.Size = new System.Drawing.Size(700, 67);
            this.Button_Answer1.TabIndex = 4;
            this.Button_Answer1.Text = "This is where the first answer will be displayed.";
            this.Button_Answer1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Button_Answer1.UseVisualStyleBackColor = false;
            this.Button_Answer1.Click += new System.EventHandler(this.Button_Answer1_Click);
            // 
            // Label_ReputationText
            // 
            this.Label_ReputationText.AutoSize = true;
            this.Label_ReputationText.BackColor = System.Drawing.Color.Transparent;
            this.Label_ReputationText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ReputationText.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_ReputationText.Location = new System.Drawing.Point(617, 27);
            this.Label_ReputationText.Name = "Label_ReputationText";
            this.Label_ReputationText.Size = new System.Drawing.Size(165, 32);
            this.Label_ReputationText.TabIndex = 1;
            this.Label_ReputationText.Text = "Reputation";
            // 
            // Label_QuestionCount
            // 
            this.Label_QuestionCount.AutoSize = true;
            this.Label_QuestionCount.BackColor = System.Drawing.Color.Transparent;
            this.Label_QuestionCount.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_QuestionCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_QuestionCount.Location = new System.Drawing.Point(390, 71);
            this.Label_QuestionCount.Name = "Label_QuestionCount";
            this.Label_QuestionCount.Size = new System.Drawing.Size(30, 32);
            this.Label_QuestionCount.TabIndex = 2;
            this.Label_QuestionCount.Text = "0";
            // 
            // Label_Question
            // 
            this.Label_Question.BackColor = System.Drawing.Color.Transparent;
            this.Label_Question.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Question.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Question.Location = new System.Drawing.Point(36, 145);
            this.Label_Question.Name = "Label_Question";
            this.Label_Question.Size = new System.Drawing.Size(704, 97);
            this.Label_Question.TabIndex = 3;
            this.Label_Question.Text = "This is where the question will be displayed.";
            // 
            // Label_VirusText
            // 
            this.Label_VirusText.AutoSize = true;
            this.Label_VirusText.BackColor = System.Drawing.Color.Transparent;
            this.Label_VirusText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_VirusText.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_VirusText.Location = new System.Drawing.Point(34, 27);
            this.Label_VirusText.Name = "Label_VirusText";
            this.Label_VirusText.Size = new System.Drawing.Size(90, 32);
            this.Label_VirusText.TabIndex = 0;
            this.Label_VirusText.Text = "Virus";
            // 
            // Label_Reputation
            // 
            this.Label_Reputation.AutoSize = true;
            this.Label_Reputation.BackColor = System.Drawing.Color.Transparent;
            this.Label_Reputation.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Reputation.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Reputation.Location = new System.Drawing.Point(686, 71);
            this.Label_Reputation.Name = "Label_Reputation";
            this.Label_Reputation.Size = new System.Drawing.Size(30, 32);
            this.Label_Reputation.TabIndex = 11;
            this.Label_Reputation.Text = "0";
            // 
            // Label_Virus
            // 
            this.Label_Virus.AutoSize = true;
            this.Label_Virus.BackColor = System.Drawing.Color.Transparent;
            this.Label_Virus.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Virus.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Virus.Location = new System.Drawing.Point(61, 71);
            this.Label_Virus.Name = "Label_Virus";
            this.Label_Virus.Size = new System.Drawing.Size(30, 32);
            this.Label_Virus.TabIndex = 12;
            this.Label_Virus.Text = "0";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GameView";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_VirusText;
        private System.Windows.Forms.Label Label_ReputationText;
        private System.Windows.Forms.Label Label_QuestionCount;
        private System.Windows.Forms.Label Label_Question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Button_Answer2;
        private System.Windows.Forms.Button Button_Answer1;
        private System.Windows.Forms.Label Label_QuestionCountDesc;
        private System.Windows.Forms.Label Label_Reputation;
        private System.Windows.Forms.Label Label_Virus;
    }
}

namespace SecurityGame.Views
{
    partial class QuestionManagerView
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
            this.ListBox_Questions = new System.Windows.Forms.ListBox();
            this.Label_Content = new System.Windows.Forms.Label();
            this.Label_CorrectAnswer = new System.Windows.Forms.Label();
            this.Label_WrongAnswer = new System.Windows.Forms.Label();
            this.Label_CorrectVirusChange = new System.Windows.Forms.Label();
            this.Label_CorrectReputationChange = new System.Windows.Forms.Label();
            this.Label_WrongVirusChange = new System.Windows.Forms.Label();
            this.Label_WrongReputationChange = new System.Windows.Forms.Label();
            this.TextBox_CorrectAnswer = new System.Windows.Forms.TextBox();
            this.TextBox_WrongAnswer = new System.Windows.Forms.TextBox();
            this.TextBox_Content = new System.Windows.Forms.TextBox();
            this.UpDown_CorrectVirus = new System.Windows.Forms.NumericUpDown();
            this.UpDown_CorrectRep = new System.Windows.Forms.NumericUpDown();
            this.UpDown_WrongVirus = new System.Windows.Forms.NumericUpDown();
            this.UpDown_WrongRep = new System.Windows.Forms.NumericUpDown();
            this.Button_EditSave = new System.Windows.Forms.Button();
            this.Button_Back = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CorrectVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CorrectRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_WrongVirus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_WrongRep)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox_Questions
            // 
            this.ListBox_Questions.FormattingEnabled = true;
            this.ListBox_Questions.Location = new System.Drawing.Point(48, 48);
            this.ListBox_Questions.Name = "ListBox_Questions";
            this.ListBox_Questions.Size = new System.Drawing.Size(208, 381);
            this.ListBox_Questions.TabIndex = 0;
            this.ListBox_Questions.SelectedIndexChanged += new System.EventHandler(this.ListBox_Questions_SelectedIndexChanged);
            // 
            // Label_Content
            // 
            this.Label_Content.AutoSize = true;
            this.Label_Content.Location = new System.Drawing.Point(272, 64);
            this.Label_Content.Name = "Label_Content";
            this.Label_Content.Size = new System.Drawing.Size(44, 13);
            this.Label_Content.TabIndex = 1;
            this.Label_Content.Text = "Content";
            // 
            // Label_CorrectAnswer
            // 
            this.Label_CorrectAnswer.AutoSize = true;
            this.Label_CorrectAnswer.Location = new System.Drawing.Point(272, 144);
            this.Label_CorrectAnswer.Name = "Label_CorrectAnswer";
            this.Label_CorrectAnswer.Size = new System.Drawing.Size(79, 13);
            this.Label_CorrectAnswer.TabIndex = 2;
            this.Label_CorrectAnswer.Text = "Correct Answer";
            // 
            // Label_WrongAnswer
            // 
            this.Label_WrongAnswer.AutoSize = true;
            this.Label_WrongAnswer.Location = new System.Drawing.Point(272, 176);
            this.Label_WrongAnswer.Name = "Label_WrongAnswer";
            this.Label_WrongAnswer.Size = new System.Drawing.Size(77, 13);
            this.Label_WrongAnswer.TabIndex = 3;
            this.Label_WrongAnswer.Text = "Wrong Answer";
            // 
            // Label_CorrectVirusChange
            // 
            this.Label_CorrectVirusChange.AutoSize = true;
            this.Label_CorrectVirusChange.Location = new System.Drawing.Point(272, 208);
            this.Label_CorrectVirusChange.Name = "Label_CorrectVirusChange";
            this.Label_CorrectVirusChange.Size = new System.Drawing.Size(107, 13);
            this.Label_CorrectVirusChange.TabIndex = 4;
            this.Label_CorrectVirusChange.Text = "Correct Virus Change";
            // 
            // Label_CorrectReputationChange
            // 
            this.Label_CorrectReputationChange.AutoSize = true;
            this.Label_CorrectReputationChange.Location = new System.Drawing.Point(272, 240);
            this.Label_CorrectReputationChange.Name = "Label_CorrectReputationChange";
            this.Label_CorrectReputationChange.Size = new System.Drawing.Size(136, 13);
            this.Label_CorrectReputationChange.TabIndex = 5;
            this.Label_CorrectReputationChange.Text = "Correct Reputation Change";
            // 
            // Label_WrongVirusChange
            // 
            this.Label_WrongVirusChange.AutoSize = true;
            this.Label_WrongVirusChange.Location = new System.Drawing.Point(272, 272);
            this.Label_WrongVirusChange.Name = "Label_WrongVirusChange";
            this.Label_WrongVirusChange.Size = new System.Drawing.Size(105, 13);
            this.Label_WrongVirusChange.TabIndex = 6;
            this.Label_WrongVirusChange.Text = "Wrong Virus Change";
            // 
            // Label_WrongReputationChange
            // 
            this.Label_WrongReputationChange.AutoSize = true;
            this.Label_WrongReputationChange.Location = new System.Drawing.Point(272, 304);
            this.Label_WrongReputationChange.Name = "Label_WrongReputationChange";
            this.Label_WrongReputationChange.Size = new System.Drawing.Size(134, 13);
            this.Label_WrongReputationChange.TabIndex = 7;
            this.Label_WrongReputationChange.Text = "Wrong Reputation Change";
            // 
            // TextBox_CorrectAnswer
            // 
            this.TextBox_CorrectAnswer.Location = new System.Drawing.Point(416, 144);
            this.TextBox_CorrectAnswer.Name = "TextBox_CorrectAnswer";
            this.TextBox_CorrectAnswer.Size = new System.Drawing.Size(336, 20);
            this.TextBox_CorrectAnswer.TabIndex = 8;
            // 
            // TextBox_WrongAnswer
            // 
            this.TextBox_WrongAnswer.Location = new System.Drawing.Point(416, 176);
            this.TextBox_WrongAnswer.Name = "TextBox_WrongAnswer";
            this.TextBox_WrongAnswer.Size = new System.Drawing.Size(336, 20);
            this.TextBox_WrongAnswer.TabIndex = 9;
            // 
            // TextBox_Content
            // 
            this.TextBox_Content.Location = new System.Drawing.Point(416, 64);
            this.TextBox_Content.Multiline = true;
            this.TextBox_Content.Name = "TextBox_Content";
            this.TextBox_Content.Size = new System.Drawing.Size(336, 64);
            this.TextBox_Content.TabIndex = 10;
            // 
            // UpDown_CorrectVirus
            // 
            this.UpDown_CorrectVirus.Location = new System.Drawing.Point(416, 208);
            this.UpDown_CorrectVirus.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UpDown_CorrectVirus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.UpDown_CorrectVirus.Name = "UpDown_CorrectVirus";
            this.UpDown_CorrectVirus.Size = new System.Drawing.Size(120, 20);
            this.UpDown_CorrectVirus.TabIndex = 11;
            // 
            // UpDown_CorrectRep
            // 
            this.UpDown_CorrectRep.Location = new System.Drawing.Point(416, 240);
            this.UpDown_CorrectRep.Name = "UpDown_CorrectRep";
            this.UpDown_CorrectRep.Size = new System.Drawing.Size(120, 20);
            this.UpDown_CorrectRep.TabIndex = 12;
            // 
            // UpDown_WrongVirus
            // 
            this.UpDown_WrongVirus.Location = new System.Drawing.Point(416, 272);
            this.UpDown_WrongVirus.Name = "UpDown_WrongVirus";
            this.UpDown_WrongVirus.Size = new System.Drawing.Size(120, 20);
            this.UpDown_WrongVirus.TabIndex = 13;
            // 
            // UpDown_WrongRep
            // 
            this.UpDown_WrongRep.Location = new System.Drawing.Point(416, 304);
            this.UpDown_WrongRep.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UpDown_WrongRep.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.UpDown_WrongRep.Name = "UpDown_WrongRep";
            this.UpDown_WrongRep.Size = new System.Drawing.Size(120, 20);
            this.UpDown_WrongRep.TabIndex = 14;
            // 
            // Button_EditSave
            // 
            this.Button_EditSave.Location = new System.Drawing.Point(656, 336);
            this.Button_EditSave.Name = "Button_EditSave";
            this.Button_EditSave.Size = new System.Drawing.Size(96, 48);
            this.Button_EditSave.TabIndex = 15;
            this.Button_EditSave.Text = "Edit";
            this.Button_EditSave.UseVisualStyleBackColor = true;
            this.Button_EditSave.Click += new System.EventHandler(this.Button_EditSave_Click);
            // 
            // Button_Back
            // 
            this.Button_Back.Location = new System.Drawing.Point(656, 400);
            this.Button_Back.Name = "Button_Back";
            this.Button_Back.Size = new System.Drawing.Size(96, 48);
            this.Button_Back.TabIndex = 16;
            this.Button_Back.Text = "Back";
            this.Button_Back.UseVisualStyleBackColor = true;
            this.Button_Back.Click += new System.EventHandler(this.Button_Back_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(544, 336);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(96, 48);
            this.Button_Cancel.TabIndex = 17;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(384, 384);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(96, 48);
            this.Button_Add.TabIndex = 18;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Delete
            // 
            this.Button_Delete.Location = new System.Drawing.Point(272, 384);
            this.Button_Delete.Name = "Button_Delete";
            this.Button_Delete.Size = new System.Drawing.Size(96, 48);
            this.Button_Delete.TabIndex = 19;
            this.Button_Delete.Text = "Delete";
            this.Button_Delete.UseVisualStyleBackColor = true;
            this.Button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // RoughQuestionManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Delete);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_Back);
            this.Controls.Add(this.Button_EditSave);
            this.Controls.Add(this.UpDown_WrongRep);
            this.Controls.Add(this.UpDown_WrongVirus);
            this.Controls.Add(this.UpDown_CorrectRep);
            this.Controls.Add(this.UpDown_CorrectVirus);
            this.Controls.Add(this.TextBox_Content);
            this.Controls.Add(this.TextBox_WrongAnswer);
            this.Controls.Add(this.TextBox_CorrectAnswer);
            this.Controls.Add(this.Label_WrongReputationChange);
            this.Controls.Add(this.Label_WrongVirusChange);
            this.Controls.Add(this.Label_CorrectReputationChange);
            this.Controls.Add(this.Label_CorrectVirusChange);
            this.Controls.Add(this.Label_WrongAnswer);
            this.Controls.Add(this.Label_CorrectAnswer);
            this.Controls.Add(this.Label_Content);
            this.Controls.Add(this.ListBox_Questions);
            this.Name = "QuestionManagerView";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CorrectVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_CorrectRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_WrongVirus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDown_WrongRep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox_Questions;
        private System.Windows.Forms.Label Label_Content;
        private System.Windows.Forms.Label Label_CorrectAnswer;
        private System.Windows.Forms.Label Label_WrongAnswer;
        private System.Windows.Forms.Label Label_CorrectVirusChange;
        private System.Windows.Forms.Label Label_CorrectReputationChange;
        private System.Windows.Forms.Label Label_WrongVirusChange;
        private System.Windows.Forms.Label Label_WrongReputationChange;
        private System.Windows.Forms.TextBox TextBox_CorrectAnswer;
        private System.Windows.Forms.TextBox TextBox_WrongAnswer;
        private System.Windows.Forms.TextBox TextBox_Content;
        private System.Windows.Forms.NumericUpDown UpDown_CorrectVirus;
        private System.Windows.Forms.NumericUpDown UpDown_CorrectRep;
        private System.Windows.Forms.NumericUpDown UpDown_WrongVirus;
        private System.Windows.Forms.NumericUpDown UpDown_WrongRep;
        private System.Windows.Forms.Button Button_EditSave;
        private System.Windows.Forms.Button Button_Back;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Delete;
    }
}

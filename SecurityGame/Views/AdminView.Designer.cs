namespace SecurityGame.Views
{
    partial class AdminView
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
            this.Button_QuestionManager = new System.Windows.Forms.Button();
            this.Button_BackToMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_QuestionManager
            // 
            this.Button_QuestionManager.Location = new System.Drawing.Point(288, 96);
            this.Button_QuestionManager.Name = "Button_QuestionManager";
            this.Button_QuestionManager.Size = new System.Drawing.Size(155, 39);
            this.Button_QuestionManager.TabIndex = 0;
            this.Button_QuestionManager.Text = "Question Manager";
            this.Button_QuestionManager.UseVisualStyleBackColor = true;
            this.Button_QuestionManager.Click += new System.EventHandler(this.Button_QuestionManager_Click);
            // 
            // Button_BackToMenu
            // 
            this.Button_BackToMenu.Location = new System.Drawing.Point(288, 144);
            this.Button_BackToMenu.Name = "Button_BackToMenu";
            this.Button_BackToMenu.Size = new System.Drawing.Size(155, 32);
            this.Button_BackToMenu.TabIndex = 1;
            this.Button_BackToMenu.Text = "Back to Menu";
            this.Button_BackToMenu.UseVisualStyleBackColor = true;
            this.Button_BackToMenu.Click += new System.EventHandler(this.Button_BackToMenu_Click);
            // 
            // RoughAdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_BackToMenu);
            this.Controls.Add(this.Button_QuestionManager);
            this.Name = "AdminView";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_QuestionManager;
        private System.Windows.Forms.Button Button_BackToMenu;
    }
}

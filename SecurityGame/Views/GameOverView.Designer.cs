namespace SecurityGame.Views
{
    partial class GameOverView
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
            this.Label_GameOver = new System.Windows.Forms.Label();
            this.Button_BackToMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_GameOver
            // 
            this.Label_GameOver.AutoSize = true;
            this.Label_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.Label_GameOver.Font = new System.Drawing.Font("Consolas", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_GameOver.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_GameOver.Location = new System.Drawing.Point(251, 172);
            this.Label_GameOver.Name = "Label_GameOver";
            this.Label_GameOver.Size = new System.Drawing.Size(288, 62);
            this.Label_GameOver.TabIndex = 0;
            this.Label_GameOver.Text = "GAME OVER";
            // 
            // Button_BackToMenu
            // 
            this.Button_BackToMenu.BackColor = System.Drawing.Color.Transparent;
            this.Button_BackToMenu.FlatAppearance.BorderSize = 0;
            this.Button_BackToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.Button_BackToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_BackToMenu.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_BackToMenu.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_BackToMenu.Location = new System.Drawing.Point(262, 237);
            this.Button_BackToMenu.Name = "Button_BackToMenu";
            this.Button_BackToMenu.Size = new System.Drawing.Size(277, 64);
            this.Button_BackToMenu.TabIndex = 1;
            this.Button_BackToMenu.Text = "[ Back to Menu ]";
            this.Button_BackToMenu.UseVisualStyleBackColor = false;
            this.Button_BackToMenu.Click += new System.EventHandler(this.Button_BackToMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SecurityGame.Properties.Resources.community_image_1408560533;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Button_BackToMenu);
            this.panel1.Controls.Add(this.Label_GameOver);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 2;
            // 
            // GameOverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GameOverView";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_GameOver;
        private System.Windows.Forms.Button Button_BackToMenu;
        private System.Windows.Forms.Panel panel1;
    }
}

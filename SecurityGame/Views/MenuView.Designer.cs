namespace SecurityGame.Views
{
    partial class MenuView
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
            this.Button_Admin = new System.Windows.Forms.Button();
            this.Button_StartGame = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_HowToPlay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SecurityGame.Properties.Resources.community_image_1408560533;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Button_Admin);
            this.panel1.Controls.Add(this.Button_StartGame);
            this.panel1.Controls.Add(this.Button_Exit);
            this.panel1.Controls.Add(this.Button_HowToPlay);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 4;
            // 
            // Button_Admin
            // 
            this.Button_Admin.BackColor = System.Drawing.Color.Transparent;
            this.Button_Admin.FlatAppearance.BorderSize = 0;
            this.Button_Admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Admin.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Admin.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_Admin.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Button_Admin.Location = new System.Drawing.Point(295, 279);
            this.Button_Admin.Name = "Button_Admin";
            this.Button_Admin.Size = new System.Drawing.Size(201, 38);
            this.Button_Admin.TabIndex = 3;
            this.Button_Admin.Text = "[ Admin Panel ]";
            this.Button_Admin.UseVisualStyleBackColor = false;
            this.Button_Admin.Click += new System.EventHandler(this.Button_Admin_Click);
            // 
            // Button_StartGame
            // 
            this.Button_StartGame.BackColor = System.Drawing.Color.Transparent;
            this.Button_StartGame.FlatAppearance.BorderSize = 0;
            this.Button_StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_StartGame.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_StartGame.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_StartGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_StartGame.Location = new System.Drawing.Point(295, 147);
            this.Button_StartGame.Name = "Button_StartGame";
            this.Button_StartGame.Size = new System.Drawing.Size(201, 38);
            this.Button_StartGame.TabIndex = 0;
            this.Button_StartGame.Text = "[ Start Game ]";
            this.Button_StartGame.UseVisualStyleBackColor = false;
            this.Button_StartGame.Click += new System.EventHandler(this.Button_StartGame_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Exit.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_Exit.Location = new System.Drawing.Point(295, 235);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(201, 38);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "[ Exit Game ]";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_HowToPlay
            // 
            this.Button_HowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.Button_HowToPlay.FlatAppearance.BorderSize = 0;
            this.Button_HowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_HowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_HowToPlay.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_HowToPlay.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_HowToPlay.Location = new System.Drawing.Point(295, 191);
            this.Button_HowToPlay.Name = "Button_HowToPlay";
            this.Button_HowToPlay.Size = new System.Drawing.Size(201, 38);
            this.Button_HowToPlay.TabIndex = 1;
            this.Button_HowToPlay.Text = "[ How to Play ]";
            this.Button_HowToPlay.UseVisualStyleBackColor = false;
            this.Button_HowToPlay.Click += new System.EventHandler(this.Button_HowToPlay_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MenuView";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_StartGame;
        private System.Windows.Forms.Button Button_HowToPlay;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Admin;
        private System.Windows.Forms.Panel panel1;
    }
}

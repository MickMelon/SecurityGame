namespace SecurityGame.Views
{
    partial class AuthView
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
            this.Label_Error = new System.Windows.Forms.Label();
            this.Button_Login = new System.Windows.Forms.Button();
            this.Label_Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_Username = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.BackgroundImage = global::SecurityGame.Properties.Resources.community_image_1408560533;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Label_Error);
            this.panel1.Controls.Add(this.Button_Login);
            this.panel1.Controls.Add(this.Label_Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Label_Username);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 8;
            // 
            // Label_Error
            // 
            this.Label_Error.BackColor = System.Drawing.Color.Transparent;
            this.Label_Error.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Error.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Error.Location = new System.Drawing.Point(210, 351);
            this.Label_Error.Name = "Label_Error";
            this.Label_Error.Size = new System.Drawing.Size(370, 90);
            this.Label_Error.TabIndex = 6;
            this.Label_Error.Text = "ERROR: You have failed to login too many times. Please try again later.";
            this.Label_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Transparent;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Login.ForeColor = System.Drawing.Color.LimeGreen;
            this.Button_Login.Location = new System.Drawing.Point(214, 286);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(366, 38);
            this.Button_Login.TabIndex = 2;
            this.Button_Login.Text = "[ Login ]";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.BackColor = System.Drawing.Color.Transparent;
            this.Label_Password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Password.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Password.Location = new System.Drawing.Point(210, 238);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(90, 19);
            this.Label_Password.TabIndex = 1;
            this.Label_Password.Text = "Password:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(250, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 104);
            this.label1.TabIndex = 7;
            this.label1.Text = "= TOP SECRET =\r\nLogin to confirm your identity!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.BackColor = System.Drawing.Color.Transparent;
            this.Label_Username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Username.ForeColor = System.Drawing.Color.LimeGreen;
            this.Label_Username.Location = new System.Drawing.Point(210, 195);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(90, 19);
            this.Label_Username.TabIndex = 0;
            this.Label_Username.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.TextBox_Username);
            this.panel2.Location = new System.Drawing.Point(306, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 30);
            this.panel2.TabIndex = 10;
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.DarkGreen;
            this.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.ForeColor = System.Drawing.Color.White;
            this.TextBox_Username.Location = new System.Drawing.Point(3, 3);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.Size = new System.Drawing.Size(146, 19);
            this.TextBox_Username.TabIndex = 8;
            this.TextBox_Username.Text = "username";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.TextBox_Password);
            this.panel3.Location = new System.Drawing.Point(306, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 30);
            this.panel3.TabIndex = 11;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.DarkGreen;
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.White;
            this.TextBox_Password.Location = new System.Drawing.Point(2, 4);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(146, 19);
            this.TextBox_Password.TabIndex = 9;
            this.TextBox_Password.Text = "password";
            // 
            // AuthView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AuthView";
            this.Size = new System.Drawing.Size(800, 500);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.TextBox TextBox_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Login;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Label Label_Error;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

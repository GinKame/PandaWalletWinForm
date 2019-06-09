namespace PWLogin
{
    partial class PWRegister
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
            this.txtBox_uName = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.txtBox_Password2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_uName
            // 
            this.txtBox_uName.Location = new System.Drawing.Point(137, 28);
            this.txtBox_uName.Name = "txtBox_uName";
            this.txtBox_uName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_uName.TabIndex = 0;
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(137, 81);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(100, 20);
            this.txtBox_email.TabIndex = 1;
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Location = new System.Drawing.Point(137, 135);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Password.TabIndex = 2;
            // 
            // txtBox_Password2
            // 
            this.txtBox_Password2.Location = new System.Drawing.Point(137, 190);
            this.txtBox_Password2.Name = "txtBox_Password2";
            this.txtBox_Password2.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Password2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Regisztráció";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(31, 28);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(81, 13);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Felhasználónév";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(77, 81);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "E-mail";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(77, 135);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(36, 13);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Jelszó";
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Location = new System.Drawing.Point(57, 190);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(56, 13);
            this.lbl_password2.TabIndex = 8;
            this.lbl_password2.Text = "Jelszó újra";
            // 
            // PWRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 307);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_Password2);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.txtBox_uName);
            this.Name = "PWRegister";
            this.Text = "PWRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_uName;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.TextBox txtBox_Password2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_password2;
    }
}
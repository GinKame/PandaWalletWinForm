namespace PWLogin
{
    partial class PWProgram
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
            this.txtBox_Money = new System.Windows.Forms.TextBox();
            this.chckBox_IsIncome = new System.Windows.Forms.CheckBox();
            this.AddMoneyBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Money
            // 
            this.txtBox_Money.Location = new System.Drawing.Point(78, 94);
            this.txtBox_Money.Name = "txtBox_Money";
            this.txtBox_Money.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Money.TabIndex = 0;
            // 
            // chckBox_IsIncome
            // 
            this.chckBox_IsIncome.AutoSize = true;
            this.chckBox_IsIncome.Location = new System.Drawing.Point(234, 96);
            this.chckBox_IsIncome.Name = "chckBox_IsIncome";
            this.chckBox_IsIncome.Size = new System.Drawing.Size(62, 17);
            this.chckBox_IsIncome.TabIndex = 1;
            this.chckBox_IsIncome.Text = "Bevétel";
            this.chckBox_IsIncome.UseVisualStyleBackColor = true;
            // 
            // AddMoneyBtn
            // 
            this.AddMoneyBtn.Location = new System.Drawing.Point(380, 90);
            this.AddMoneyBtn.Name = "AddMoneyBtn";
            this.AddMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.AddMoneyBtn.TabIndex = 2;
            this.AddMoneyBtn.Text = "Bevitel";
            this.AddMoneyBtn.UseVisualStyleBackColor = true;
            this.AddMoneyBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Összeg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Vissza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PWProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddMoneyBtn);
            this.Controls.Add(this.chckBox_IsIncome);
            this.Controls.Add(this.txtBox_Money);
            this.Name = "PWProgram";
            this.Text = "PWProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Money;
        private System.Windows.Forms.CheckBox chckBox_IsIncome;
        private System.Windows.Forms.Button AddMoneyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
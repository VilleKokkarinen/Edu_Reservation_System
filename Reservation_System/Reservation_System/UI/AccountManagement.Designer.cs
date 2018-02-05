namespace Reservation_System.UI
{
    partial class AccountManagement
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
            this.lbl_chancepword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_newpword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_confpword = new System.Windows.Forms.Label();
            this.btn_acceptchanges_pword = new System.Windows.Forms.Button();
            this.btn_acceptchanges_email = new System.Windows.Forms.Button();
            this.lbl_newemail = new System.Windows.Forms.Label();
            this.txt_newemail = new System.Windows.Forms.TextBox();
            this.lbl_chance_email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_chancepword
            // 
            this.lbl_chancepword.AutoSize = true;
            this.lbl_chancepword.Location = new System.Drawing.Point(17, 9);
            this.lbl_chancepword.Name = "lbl_chancepword";
            this.lbl_chancepword.Size = new System.Drawing.Size(92, 13);
            this.lbl_chancepword.TabIndex = 0;
            this.lbl_chancepword.Text = "Change password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbl_newpword
            // 
            this.lbl_newpword.AutoSize = true;
            this.lbl_newpword.Location = new System.Drawing.Point(16, 44);
            this.lbl_newpword.Name = "lbl_newpword";
            this.lbl_newpword.Size = new System.Drawing.Size(77, 13);
            this.lbl_newpword.TabIndex = 2;
            this.lbl_newpword.Text = "New password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // lbl_confpword
            // 
            this.lbl_confpword.AutoSize = true;
            this.lbl_confpword.Location = new System.Drawing.Point(16, 94);
            this.lbl_confpword.Name = "lbl_confpword";
            this.lbl_confpword.Size = new System.Drawing.Size(90, 13);
            this.lbl_confpword.TabIndex = 4;
            this.lbl_confpword.Text = "Confirm password";
            // 
            // btn_acceptchanges_pword
            // 
            this.btn_acceptchanges_pword.Location = new System.Drawing.Point(16, 145);
            this.btn_acceptchanges_pword.Name = "btn_acceptchanges_pword";
            this.btn_acceptchanges_pword.Size = new System.Drawing.Size(134, 23);
            this.btn_acceptchanges_pword.TabIndex = 5;
            this.btn_acceptchanges_pword.Text = "Hyväksy muutokset";
            this.btn_acceptchanges_pword.UseVisualStyleBackColor = true;
            this.btn_acceptchanges_pword.Click += new System.EventHandler(this.btn_acceptchanges_pword_Click);
            // 
            // btn_acceptchanges_email
            // 
            this.btn_acceptchanges_email.Location = new System.Drawing.Point(233, 94);
            this.btn_acceptchanges_email.Name = "btn_acceptchanges_email";
            this.btn_acceptchanges_email.Size = new System.Drawing.Size(134, 23);
            this.btn_acceptchanges_email.TabIndex = 11;
            this.btn_acceptchanges_email.Text = "Hyväksy muutokset";
            this.btn_acceptchanges_email.UseVisualStyleBackColor = true;
            // 
            // lbl_newemail
            // 
            this.lbl_newemail.AutoSize = true;
            this.lbl_newemail.Location = new System.Drawing.Point(230, 44);
            this.lbl_newemail.Name = "lbl_newemail";
            this.lbl_newemail.Size = new System.Drawing.Size(56, 13);
            this.lbl_newemail.TabIndex = 8;
            this.lbl_newemail.Text = "New email";
            // 
            // txt_newemail
            // 
            this.txt_newemail.Location = new System.Drawing.Point(233, 63);
            this.txt_newemail.Name = "txt_newemail";
            this.txt_newemail.Size = new System.Drawing.Size(100, 20);
            this.txt_newemail.TabIndex = 7;
            // 
            // lbl_chance_email
            // 
            this.lbl_chance_email.AutoSize = true;
            this.lbl_chance_email.Location = new System.Drawing.Point(230, 9);
            this.lbl_chance_email.Name = "lbl_chance_email";
            this.lbl_chance_email.Size = new System.Drawing.Size(71, 13);
            this.lbl_chance_email.TabIndex = 6;
            this.lbl_chance_email.Text = "Change email";
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 344);
            this.Controls.Add(this.btn_acceptchanges_email);
            this.Controls.Add(this.lbl_newemail);
            this.Controls.Add(this.txt_newemail);
            this.Controls.Add(this.lbl_chance_email);
            this.Controls.Add(this.btn_acceptchanges_pword);
            this.Controls.Add(this.lbl_confpword);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_newpword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_chancepword);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chancepword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_newpword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_confpword;
        private System.Windows.Forms.Button btn_acceptchanges_pword;
        private System.Windows.Forms.Button btn_acceptchanges_email;
        private System.Windows.Forms.Label lbl_newemail;
        private System.Windows.Forms.TextBox txt_newemail;
        private System.Windows.Forms.Label lbl_chance_email;
    }
}
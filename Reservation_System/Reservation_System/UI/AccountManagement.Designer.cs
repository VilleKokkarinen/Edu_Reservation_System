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
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.lbl_newpassword = new System.Windows.Forms.Label();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.lbl_confirmpassword = new System.Windows.Forms.Label();
            this.btn_applychanges = new System.Windows.Forms.Button();
            this.btn_applychanges2 = new System.Windows.Forms.Button();
            this.lbl_newemail = new System.Windows.Forms.Label();
            this.txt_newemail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Location = new System.Drawing.Point(6, 52);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.Size = new System.Drawing.Size(115, 20);
            this.txt_newpassword.TabIndex = 1;
            // 
            // lbl_newpassword
            // 
            this.lbl_newpassword.AutoSize = true;
            this.lbl_newpassword.Location = new System.Drawing.Point(6, 33);
            this.lbl_newpassword.Name = "lbl_newpassword";
            this.lbl_newpassword.Size = new System.Drawing.Size(77, 13);
            this.lbl_newpassword.TabIndex = 2;
            this.lbl_newpassword.Text = "New password";
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.Location = new System.Drawing.Point(6, 99);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(115, 20);
            this.txt_confirmpassword.TabIndex = 3;
            // 
            // lbl_confirmpassword
            // 
            this.lbl_confirmpassword.AutoSize = true;
            this.lbl_confirmpassword.Location = new System.Drawing.Point(6, 83);
            this.lbl_confirmpassword.Name = "lbl_confirmpassword";
            this.lbl_confirmpassword.Size = new System.Drawing.Size(90, 13);
            this.lbl_confirmpassword.TabIndex = 4;
            this.lbl_confirmpassword.Text = "Confirm password";
            // 
            // btn_applychanges
            // 
            this.btn_applychanges.Location = new System.Drawing.Point(6, 134);
            this.btn_applychanges.Name = "btn_applychanges";
            this.btn_applychanges.Size = new System.Drawing.Size(115, 23);
            this.btn_applychanges.TabIndex = 5;
            this.btn_applychanges.Text = "Hyväksy muutokset";
            this.btn_applychanges.UseVisualStyleBackColor = true;
            this.btn_applychanges.Click += new System.EventHandler(this.btn_applychanges_Click);
            // 
            // btn_applychanges2
            // 
            this.btn_applychanges2.Location = new System.Drawing.Point(9, 134);
            this.btn_applychanges2.Name = "btn_applychanges2";
            this.btn_applychanges2.Size = new System.Drawing.Size(134, 23);
            this.btn_applychanges2.TabIndex = 11;
            this.btn_applychanges2.Text = "Hyväksy muutokset";
            this.btn_applychanges2.UseVisualStyleBackColor = true;
            this.btn_applychanges2.Click += new System.EventHandler(this.btn_applychanges2_Click);
            // 
            // lbl_newemail
            // 
            this.lbl_newemail.AutoSize = true;
            this.lbl_newemail.Location = new System.Drawing.Point(6, 33);
            this.lbl_newemail.Name = "lbl_newemail";
            this.lbl_newemail.Size = new System.Drawing.Size(56, 13);
            this.lbl_newemail.TabIndex = 8;
            this.lbl_newemail.Text = "New email";
            // 
            // txt_newemail
            // 
            this.txt_newemail.Location = new System.Drawing.Point(9, 52);
            this.txt_newemail.Name = "txt_newemail";
            this.txt_newemail.Size = new System.Drawing.Size(134, 20);
            this.txt_newemail.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_confirmpassword);
            this.groupBox1.Controls.Add(this.txt_newpassword);
            this.groupBox1.Controls.Add(this.lbl_newpassword);
            this.groupBox1.Controls.Add(this.lbl_confirmpassword);
            this.groupBox1.Controls.Add(this.btn_applychanges);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 166);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change password";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_applychanges2);
            this.groupBox2.Controls.Add(this.txt_newemail);
            this.groupBox2.Controls.Add(this.lbl_newemail);
            this.groupBox2.Location = new System.Drawing.Point(172, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 166);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change email address";
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 196);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.Load += new System.EventHandler(this.AccountManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.Label lbl_newpassword;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.Label lbl_confirmpassword;
        private System.Windows.Forms.Button btn_applychanges;
        private System.Windows.Forms.Button btn_applychanges2;
        private System.Windows.Forms.Label lbl_newemail;
        private System.Windows.Forms.TextBox txt_newemail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
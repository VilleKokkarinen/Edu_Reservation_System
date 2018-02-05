namespace Reservation_System.UI
{
    partial class LoginScreen
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
            this.components = new System.ComponentModel.Container();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.chkbox_remember_user = new System.Windows.Forms.CheckBox();
            this.lbl_invalid_login_credentials = new System.Windows.Forms.Label();
            this.lblforgotpassword = new System.Windows.Forms.LinkLabel();
            this.btn_registeruser = new System.Windows.Forms.Button();          
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(8, 28);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(265, 20);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_password.Location = new System.Drawing.Point(8, 53);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(194, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enabled);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(208, 52);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(65, 22);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // chkbox_remember_user
            // 
            this.chkbox_remember_user.AutoSize = true;
            this.chkbox_remember_user.Location = new System.Drawing.Point(8, 79);
            this.chkbox_remember_user.Name = "chkbox_remember_user";
            this.chkbox_remember_user.Size = new System.Drawing.Size(100, 17);
            this.chkbox_remember_user.TabIndex = 4;
            this.chkbox_remember_user.Text = "Remember user";
            this.chkbox_remember_user.UseVisualStyleBackColor = true;
            this.chkbox_remember_user.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_invalid_login_credentials
            // 
            this.lbl_invalid_login_credentials.AutoSize = true;
            this.lbl_invalid_login_credentials.ForeColor = System.Drawing.Color.Red;
            this.lbl_invalid_login_credentials.Location = new System.Drawing.Point(8, 11);
            this.lbl_invalid_login_credentials.Name = "lbl_invalid_login_credentials";
            this.lbl_invalid_login_credentials.Size = new System.Drawing.Size(123, 13);
            this.lbl_invalid_login_credentials.TabIndex = 99;
            this.lbl_invalid_login_credentials.Text = "Login credentials invalid!";
            this.lbl_invalid_login_credentials.Visible = false;
            // 
            // lblforgotpassword
            // 
            this.lblforgotpassword.AutoSize = true;
            this.lblforgotpassword.LinkColor = System.Drawing.Color.Navy;
            this.lblforgotpassword.Location = new System.Drawing.Point(164, 10);
            this.lblforgotpassword.Name = "lblforgotpassword";
            this.lblforgotpassword.Size = new System.Drawing.Size(94, 13);
            this.lblforgotpassword.TabIndex = 102;
            this.lblforgotpassword.TabStop = true;
            this.lblforgotpassword.Text = "Forgot password ?";
            this.lblforgotpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblforgotpassword_LinkClicked);
            // 
            // btn_registeruser
            // 
            this.btn_registeruser.Location = new System.Drawing.Point(114, 81);
            this.btn_registeruser.Name = "btn_registeruser";
            this.btn_registeruser.Size = new System.Drawing.Size(159, 22);
            this.btn_registeruser.TabIndex = 103;
            this.btn_registeruser.Text = "Register new user";
            this.btn_registeruser.UseVisualStyleBackColor = true;
            this.btn_registeruser.Click += new System.EventHandler(this.button1_Click);
           
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 127);
            this.Controls.Add(this.btn_registeruser);
            this.Controls.Add(this.lblforgotpassword);
            this.Controls.Add(this.lbl_invalid_login_credentials);
            this.Controls.Add(this.chkbox_remember_user);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox chkbox_remember_user;
        private System.Windows.Forms.Label lbl_invalid_login_credentials;
        private System.Windows.Forms.LinkLabel lblforgotpassword;
        private System.Windows.Forms.Button btn_registeruser;       
    }
}
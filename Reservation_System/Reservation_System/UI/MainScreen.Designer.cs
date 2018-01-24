namespace Reservation_System
{
    partial class MainScreen
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_userinfo = new System.Windows.Forms.Label();
            this.cbox_remember_user = new System.Windows.Forms.CheckBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(15, 27);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(241, 20);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "GUEST";
            this.txt_username.Click += new System.EventHandler(this.txt_username_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(15, 53);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(241, 20);
            this.txt_password.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(262, 27);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(68, 46);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_userinfo
            // 
            this.lbl_userinfo.AutoSize = true;
            this.lbl_userinfo.Location = new System.Drawing.Point(12, 9);
            this.lbl_userinfo.Name = "lbl_userinfo";
            this.lbl_userinfo.Size = new System.Drawing.Size(113, 13);
            this.lbl_userinfo.TabIndex = 3;
            this.lbl_userinfo.Text = "Username && Password";
            // 
            // cbox_remember_user
            // 
            this.cbox_remember_user.AutoSize = true;
            this.cbox_remember_user.Location = new System.Drawing.Point(15, 79);
            this.cbox_remember_user.Name = "cbox_remember_user";
            this.cbox_remember_user.Size = new System.Drawing.Size(100, 17);
            this.cbox_remember_user.TabIndex = 4;
            this.cbox_remember_user.Text = "Remember user";
            this.cbox_remember_user.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(213, 203);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(68, 46);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Don\' t have a user?";
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(12, 158);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(141, 28);
            this.btnRegisterUser.TabIndex = 7;
            this.btnRegisterUser.Text = "Create User";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.cbox_remember_user);
            this.Controls.Add(this.lbl_userinfo);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_userinfo;
        private System.Windows.Forms.CheckBox cbox_remember_user;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegisterUser;
    }
}
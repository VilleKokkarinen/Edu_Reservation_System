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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_userinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 27);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(256, 20);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "username";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_password.Location = new System.Drawing.Point(12, 52);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(190, 20);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enabled);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(203, 51);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(65, 22);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_2);
            // 
            // lbl_userinfo
            // 
            this.lbl_userinfo.AutoSize = true;
            this.lbl_userinfo.Location = new System.Drawing.Point(13, 8);
            this.lbl_userinfo.Name = "lbl_userinfo";
            this.lbl_userinfo.Size = new System.Drawing.Size(113, 13);
            this.lbl_userinfo.TabIndex = 3;
            this.lbl_userinfo.Text = "Username && Password";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 261);
            this.Controls.Add(this.lbl_userinfo);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_userinfo;
    }
}
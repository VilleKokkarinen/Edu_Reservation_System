namespace Reservation_System.UI
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
            this.btn_reserve = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_accountmngr = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_return = new System.Windows.Forms.Button();
            this.btn_Loan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_reserve
            // 
            this.btn_reserve.Location = new System.Drawing.Point(12, 161);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(115, 52);
            this.btn_reserve.TabIndex = 0;
            this.btn_reserve.Text = "Reservation";
            this.btn_reserve.UseVisualStyleBackColor = true;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(347, 170);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(90, 43);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(6, 12);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(68, 13);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Logged in as";
            // 
            // btn_accountmngr
            // 
            this.btn_accountmngr.Location = new System.Drawing.Point(347, 61);
            this.btn_accountmngr.Name = "btn_accountmngr";
            this.btn_accountmngr.Size = new System.Drawing.Size(90, 43);
            this.btn_accountmngr.TabIndex = 3;
            this.btn_accountmngr.Text = "Account Management";
            this.btn_accountmngr.UseVisualStyleBackColor = true;
            this.btn_accountmngr.Click += new System.EventHandler(this.btn_accountmngr_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(6, 32);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(63, 13);
            this.lbl_username.TabIndex = 4;
            this.lbl_username.Text = "Username";
            // 
            // btn_return
            // 
            this.btn_return.Location = new System.Drawing.Point(12, 86);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(115, 52);
            this.btn_return.TabIndex = 5;
            this.btn_return.Text = "Return loan(s)";
            this.btn_return.UseVisualStyleBackColor = true;
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.Location = new System.Drawing.Point(12, 12);
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.Size = new System.Drawing.Size(115, 52);
            this.btn_Loan.TabIndex = 6;
            this.btn_Loan.Text = "Loan item(s)";
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_welcome);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(289, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 52);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Item Management";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 225);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Loan);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_accountmngr);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_reserve);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reserve;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_accountmngr;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button btn_Loan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
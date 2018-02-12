namespace Reservation_System
{
    partial class SettingsScreen
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
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbFinnish = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 12);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(171, 23);
            this.button11.TabIndex = 34;
            this.button11.Text = "Lisää uusi tavara tietokantaan";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(12, 41);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(171, 23);
            this.button12.TabIndex = 35;
            this.button12.Text = "Poista tavara tietokannasta";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEnglish);
            this.groupBox1.Controls.Add(this.rbFinnish);
            this.groupBox1.Location = new System.Drawing.Point(12, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 71);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Checked = true;
            this.rbEnglish.Location = new System.Drawing.Point(6, 42);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbEnglish.TabIndex = 1;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbFinnish_CheckedChanged);
            // 
            // rbFinnish
            // 
            this.rbFinnish.AutoSize = true;
            this.rbFinnish.Location = new System.Drawing.Point(6, 19);
            this.rbFinnish.Name = "rbFinnish";
            this.rbFinnish.Size = new System.Drawing.Size(58, 17);
            this.rbFinnish.TabIndex = 0;
            this.rbFinnish.Text = "Finnish";
            this.rbFinnish.UseVisualStyleBackColor = true;
            this.rbFinnish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreen";
            this.Load += new System.EventHandler(this.SettingsScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbFinnish;
    }
}
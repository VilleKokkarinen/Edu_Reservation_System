namespace Reservation_System.UI
{
    partial class PreReservationScreen
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
            this.button18 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(244, 243);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(106, 43);
            this.button18.TabIndex = 62;
            this.button18.Text = "Näytä valitun tavaran tiedot";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(253, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "Hae tavaroita";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(256, 72);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(117, 20);
            this.textBox7.TabIndex = 60;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(12, 291);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(143, 23);
            this.button17.TabIndex = 59;
            this.button17.Text = "Varaa";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.CheckOnClick = true;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(12, 26);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(226, 259);
            this.checkedListBox4.TabIndex = 58;
            // 
            // PreReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 351);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.checkedListBox4);
            this.Name = "PreReservationScreen";
            this.Text = "PreReservationScreen";
            this.Load += new System.EventHandler(this.PreReservationScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
    }
}
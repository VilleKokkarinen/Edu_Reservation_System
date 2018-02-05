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
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_DeleteItem = new System.Windows.Forms.Button();
            this.grpBox_Language = new System.Windows.Forms.GroupBox();
            this.rBtn_LangEng = new System.Windows.Forms.RadioButton();
            this.rBtn_LangFin = new System.Windows.Forms.RadioButton();
            this.grpBox_Language.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(12, 12);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(171, 23);
            this.btn_AddItem.TabIndex = 34;
            this.btn_AddItem.Text = "Lisää uusi tavara tietokantaan";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_DeleteItem
            // 
            this.btn_DeleteItem.Location = new System.Drawing.Point(12, 41);
            this.btn_DeleteItem.Name = "btn_DeleteItem";
            this.btn_DeleteItem.Size = new System.Drawing.Size(171, 23);
            this.btn_DeleteItem.TabIndex = 35;
            this.btn_DeleteItem.Text = "Poista tavara tietokannasta";
            this.btn_DeleteItem.UseVisualStyleBackColor = true;
            // 
            // grpBox_Language
            // 
            this.grpBox_Language.Controls.Add(this.rBtn_LangEng);
            this.grpBox_Language.Controls.Add(this.rBtn_LangFin);
            this.grpBox_Language.Location = new System.Drawing.Point(12, 178);
            this.grpBox_Language.Name = "grpBox_Language";
            this.grpBox_Language.Size = new System.Drawing.Size(90, 71);
            this.grpBox_Language.TabIndex = 36;
            this.grpBox_Language.TabStop = false;
            this.grpBox_Language.Text = "Language";
            // 
            // rBtn_LangEng
            // 
            this.rBtn_LangEng.AutoSize = true;
            this.rBtn_LangEng.Checked = true;
            this.rBtn_LangEng.Location = new System.Drawing.Point(6, 42);
            this.rBtn_LangEng.Name = "rBtn_LangEng";
            this.rBtn_LangEng.Size = new System.Drawing.Size(59, 17);
            this.rBtn_LangEng.TabIndex = 1;
            this.rBtn_LangEng.TabStop = true;
            this.rBtn_LangEng.Text = "English";
            this.rBtn_LangEng.UseVisualStyleBackColor = true;
            // 
            // rBtn_LangFin
            // 
            this.rBtn_LangFin.AutoSize = true;
            this.rBtn_LangFin.Location = new System.Drawing.Point(6, 19);
            this.rBtn_LangFin.Name = "rBtn_LangFin";
            this.rBtn_LangFin.Size = new System.Drawing.Size(58, 17);
            this.rBtn_LangFin.TabIndex = 0;
            this.rBtn_LangFin.Text = "Finnish";
            this.rBtn_LangFin.UseVisualStyleBackColor = true;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grpBox_Language);
            this.Controls.Add(this.btn_DeleteItem);
            this.Controls.Add(this.btn_AddItem);
            this.Name = "SettingsScreen";
            this.Text = "SettingsScreen";
            this.grpBox_Language.ResumeLayout(false);
            this.grpBox_Language.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.GroupBox grpBox_Language;
        private System.Windows.Forms.RadioButton rBtn_LangEng;
        private System.Windows.Forms.RadioButton rBtn_LangFin;
    }
}
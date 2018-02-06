namespace Reservation_System.UI
{
    partial class NewItemScreen
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
            this.btn_addtodatabase = new System.Windows.Forms.Button();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_addtodatabase
            // 
            this.btn_addtodatabase.Location = new System.Drawing.Point(154, 25);
            this.btn_addtodatabase.Name = "btn_addtodatabase";
            this.btn_addtodatabase.Size = new System.Drawing.Size(116, 23);
            this.btn_addtodatabase.TabIndex = 49;
            this.btn_addtodatabase.Text = "Lisää tietokantaan";
            this.btn_addtodatabase.UseVisualStyleBackColor = true;
            this.btn_addtodatabase.Click += new System.EventHandler(this.button13_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(12, 63);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(38, 13);
            this.lbl_type.TabIndex = 47;
            this.lbl_type.Text = "Tyyppi";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(27, 13);
            this.lbl_name.TabIndex = 45;
            this.lbl_name.Text = "Nimi";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 25);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 44;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 50;
            // 
            // NewItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 206);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_addtodatabase);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Name = "NewItemScreen";
            this.Text = "NewItemScreen";
            this.Load += new System.EventHandler(this.NewItemScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addtodatabase;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
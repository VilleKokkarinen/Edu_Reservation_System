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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_addtodatabase = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_addnewitem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(33, 185);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 50;
            this.lbl_ID.Text = "ID";
            // 
            // btn_addtodatabase
            // 
            this.btn_addtodatabase.Location = new System.Drawing.Point(32, 262);
            this.btn_addtodatabase.Name = "btn_addtodatabase";
            this.btn_addtodatabase.Size = new System.Drawing.Size(116, 23);
            this.btn_addtodatabase.TabIndex = 49;
            this.btn_addtodatabase.Text = "Lisää tietokantaan";
            this.btn_addtodatabase.UseVisualStyleBackColor = true;
            this.btn_addtodatabase.Click += new System.EventHandler(this.button13_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(36, 204);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 48;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(36, 125);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(38, 13);
            this.lbl_type.TabIndex = 47;
            this.lbl_type.Text = "Tyyppi";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(36, 144);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 20);
            this.txt_type.TabIndex = 46;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(36, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(27, 13);
            this.lbl_name.TabIndex = 45;
            this.lbl_name.Text = "Nimi";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(36, 80);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 44;
            // 
            // lbl_addnewitem
            // 
            this.lbl_addnewitem.AutoSize = true;
            this.lbl_addnewitem.Location = new System.Drawing.Point(33, 12);
            this.lbl_addnewitem.Name = "lbl_addnewitem";
            this.lbl_addnewitem.Size = new System.Drawing.Size(130, 13);
            this.lbl_addnewitem.TabIndex = 43;
            this.lbl_addnewitem.Text = "Uuden tavaran lisääminen";
            // 
            // NewItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 356);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_addtodatabase);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_addnewitem);
            this.Name = "NewItemScreen";
            this.Text = "NewItemScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Button btn_addtodatabase;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_addnewitem;
    }
}
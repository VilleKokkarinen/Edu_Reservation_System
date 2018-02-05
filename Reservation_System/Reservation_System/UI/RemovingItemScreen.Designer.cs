namespace Reservation_System.UI
{
    partial class RemovingItemScreen
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
            this.btn_SearchItem = new System.Windows.Forms.Button();
            this.txt_SearchItem = new System.Windows.Forms.TextBox();
            this.lbl_SearchItem = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.checkboxlist_DeleteItem = new System.Windows.Forms.CheckedListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SearchItem
            // 
            this.btn_SearchItem.Location = new System.Drawing.Point(209, 90);
            this.btn_SearchItem.Name = "btn_SearchItem";
            this.btn_SearchItem.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchItem.TabIndex = 55;
            this.btn_SearchItem.Text = "Hae";
            this.btn_SearchItem.UseVisualStyleBackColor = true;
            // 
            // txt_SearchItem
            // 
            this.txt_SearchItem.Location = new System.Drawing.Point(209, 64);
            this.txt_SearchItem.Name = "txt_SearchItem";
            this.txt_SearchItem.Size = new System.Drawing.Size(117, 20);
            this.txt_SearchItem.TabIndex = 54;
            // 
            // lbl_SearchItem
            // 
            this.lbl_SearchItem.AutoSize = true;
            this.lbl_SearchItem.Location = new System.Drawing.Point(206, 48);
            this.lbl_SearchItem.Name = "lbl_SearchItem";
            this.lbl_SearchItem.Size = new System.Drawing.Size(71, 13);
            this.lbl_SearchItem.TabIndex = 53;
            this.lbl_SearchItem.Text = "Hae tavaroita";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(23, 268);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(132, 39);
            this.btn_Delete.TabIndex = 52;
            this.btn_Delete.Text = "Poista valittu tuote";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // checkboxlist_DeleteItem
            // 
            this.checkboxlist_DeleteItem.FormattingEnabled = true;
            this.checkboxlist_DeleteItem.Items.AddRange(new object[] {
            "[Tavara] [tyyppi X]",
            "[Laite] [tyyppi Y]",
            "[Hilavitkutin] [Tyyppi X]",
            "[Asia] [Tyyppi 43]"});
            this.checkboxlist_DeleteItem.Location = new System.Drawing.Point(23, 32);
            this.checkboxlist_DeleteItem.Name = "checkboxlist_DeleteItem";
            this.checkboxlist_DeleteItem.Size = new System.Drawing.Size(165, 214);
            this.checkboxlist_DeleteItem.TabIndex = 51;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Tavaran postaminen";
            // 
            // RemovingItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 322);
            this.Controls.Add(this.btn_SearchItem);
            this.Controls.Add(this.txt_SearchItem);
            this.Controls.Add(this.lbl_SearchItem);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.checkboxlist_DeleteItem);
            this.Controls.Add(this.label19);
            this.Name = "RemovingItemScreen";
            this.Text = "RemovingItemScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SearchItem;
        private System.Windows.Forms.TextBox txt_SearchItem;
        private System.Windows.Forms.Label lbl_SearchItem;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.CheckedListBox checkboxlist_DeleteItem;
        private System.Windows.Forms.Label label19;
    }
}
namespace Reservation_System.UI
{
    partial class ReturningScreen
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
            this.btn_ShowItemInfo = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_SearchItems = new System.Windows.Forms.Label();
            this.txt_SearchItems = new System.Windows.Forms.TextBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_ItemsLoaned = new System.Windows.Forms.Label();
            this.lbl_ReturnMenu = new System.Windows.Forms.Label();
            this.checkboxlist_ItemsLoaned = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_ShowItemInfo
            // 
            this.btn_ShowItemInfo.Location = new System.Drawing.Point(258, 241);
            this.btn_ShowItemInfo.Name = "btn_ShowItemInfo";
            this.btn_ShowItemInfo.Size = new System.Drawing.Size(106, 43);
            this.btn_ShowItemInfo.TabIndex = 41;
            this.btn_ShowItemInfo.Text = "Näytä valitun tavaran tiedot";
            this.btn_ShowItemInfo.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(270, 109);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 40;
            this.btn_Search.Text = "Hae";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchItems
            // 
            this.lbl_SearchItems.AutoSize = true;
            this.lbl_SearchItems.Location = new System.Drawing.Point(267, 64);
            this.lbl_SearchItems.Name = "lbl_SearchItems";
            this.lbl_SearchItems.Size = new System.Drawing.Size(71, 13);
            this.lbl_SearchItems.TabIndex = 39;
            this.lbl_SearchItems.Text = "Hae tavaroita";
            // 
            // txt_SearchItems
            // 
            this.txt_SearchItems.Location = new System.Drawing.Point(270, 83);
            this.txt_SearchItems.Name = "txt_SearchItems";
            this.txt_SearchItems.Size = new System.Drawing.Size(117, 20);
            this.txt_SearchItems.TabIndex = 38;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(22, 296);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(139, 23);
            this.btn_Return.TabIndex = 37;
            this.btn_Return.Text = "Palauta";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lbl_ItemsLoaned
            // 
            this.lbl_ItemsLoaned.AutoSize = true;
            this.lbl_ItemsLoaned.Location = new System.Drawing.Point(19, 39);
            this.lbl_ItemsLoaned.Name = "lbl_ItemsLoaned";
            this.lbl_ItemsLoaned.Size = new System.Drawing.Size(120, 13);
            this.lbl_ItemsLoaned.TabIndex = 36;
            this.lbl_ItemsLoaned.Text = "Lainassa olevat tuotteet";
            // 
            // lbl_ReturnMenu
            // 
            this.lbl_ReturnMenu.AutoSize = true;
            this.lbl_ReturnMenu.Location = new System.Drawing.Point(19, 8);
            this.lbl_ReturnMenu.Name = "lbl_ReturnMenu";
            this.lbl_ReturnMenu.Size = new System.Drawing.Size(82, 13);
            this.lbl_ReturnMenu.TabIndex = 35;
            this.lbl_ReturnMenu.Text = "Palautusvalikko";
            // 
            // checkboxlist_ItemsLoaned
            // 
            this.checkboxlist_ItemsLoaned.FormattingEnabled = true;
            this.checkboxlist_ItemsLoaned.Items.AddRange(new object[] {
            "[Hilavitkutin] [Tyyppi X] [Saatavilla 7.5.18]",
            "[Asia] [Tyyppi 43] [Saatavilla 9.5.18]"});
            this.checkboxlist_ItemsLoaned.Location = new System.Drawing.Point(22, 55);
            this.checkboxlist_ItemsLoaned.Name = "checkboxlist_ItemsLoaned";
            this.checkboxlist_ItemsLoaned.Size = new System.Drawing.Size(230, 229);
            this.checkboxlist_ItemsLoaned.TabIndex = 34;
            // 
            // ReturningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 365);
            this.Controls.Add(this.btn_ShowItemInfo);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_SearchItems);
            this.Controls.Add(this.txt_SearchItems);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lbl_ItemsLoaned);
            this.Controls.Add(this.lbl_ReturnMenu);
            this.Controls.Add(this.checkboxlist_ItemsLoaned);
            this.Name = "ReturningScreen";
            this.Text = "ReturningScreen";
            this.Load += new System.EventHandler(this.ReturningScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowItemInfo;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_SearchItems;
        private System.Windows.Forms.TextBox txt_SearchItems;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_ItemsLoaned;
        private System.Windows.Forms.Label lbl_ReturnMenu;
        private System.Windows.Forms.CheckedListBox checkboxlist_ItemsLoaned;
    }
}
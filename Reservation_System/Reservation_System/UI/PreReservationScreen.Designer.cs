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
            this.btn_ShowItemInfo = new System.Windows.Forms.Button();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txt_SearchItem = new System.Windows.Forms.TextBox();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.checkboxlist_ReserveItems = new System.Windows.Forms.CheckedListBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_PreReservationMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ShowItemInfo
            // 
            this.btn_ShowItemInfo.Location = new System.Drawing.Point(244, 265);
            this.btn_ShowItemInfo.Name = "btn_ShowItemInfo";
            this.btn_ShowItemInfo.Size = new System.Drawing.Size(106, 43);
            this.btn_ShowItemInfo.TabIndex = 62;
            this.btn_ShowItemInfo.Text = "Näytä valitun tavaran tiedot";
            this.btn_ShowItemInfo.UseVisualStyleBackColor = true;
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(253, 79);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(71, 13);
            this.lbl_Search.TabIndex = 61;
            this.lbl_Search.Text = "Hae tavaroita";
            // 
            // txt_SearchItem
            // 
            this.txt_SearchItem.Location = new System.Drawing.Point(256, 95);
            this.txt_SearchItem.Name = "txt_SearchItem";
            this.txt_SearchItem.Size = new System.Drawing.Size(117, 20);
            this.txt_SearchItem.TabIndex = 60;
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Location = new System.Drawing.Point(12, 314);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(143, 23);
            this.btn_Reserve.TabIndex = 59;
            this.btn_Reserve.Text = "Varaa";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            this.btn_Reserve.Click += new System.EventHandler(this.button17_Click);
            // 
            // checkboxlist_ReserveItems
            // 
            this.checkboxlist_ReserveItems.FormattingEnabled = true;
            this.checkboxlist_ReserveItems.Items.AddRange(new object[] {
            "[Hilavitkutin] [Tyyppi X] [Saatavilla 7.5.18]",
            "[Asia] [Tyyppi 43] [Saatavilla 9.5.18]"});
            this.checkboxlist_ReserveItems.Location = new System.Drawing.Point(12, 49);
            this.checkboxlist_ReserveItems.Name = "checkboxlist_ReserveItems";
            this.checkboxlist_ReserveItems.Size = new System.Drawing.Size(226, 259);
            this.checkboxlist_ReserveItems.TabIndex = 58;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(256, 121);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 63;
            this.btn_Search.Text = "Hae";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_PreReservationMenu
            // 
            this.lbl_PreReservationMenu.AutoSize = true;
            this.lbl_PreReservationMenu.Location = new System.Drawing.Point(12, 13);
            this.lbl_PreReservationMenu.Name = "lbl_PreReservationMenu";
            this.lbl_PreReservationMenu.Size = new System.Drawing.Size(92, 13);
            this.lbl_PreReservationMenu.TabIndex = 64;
            this.lbl_PreReservationMenu.Text = "Varaa ennakkoon";
            // 
            // PreReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 370);
            this.Controls.Add(this.lbl_PreReservationMenu);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_ShowItemInfo);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txt_SearchItem);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.checkboxlist_ReserveItems);
            this.Name = "PreReservationScreen";
            this.Text = "PreReservationScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowItemInfo;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_SearchItem;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.CheckedListBox checkboxlist_ReserveItems;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_PreReservationMenu;
    }
}
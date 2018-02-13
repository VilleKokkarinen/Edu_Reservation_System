namespace Reservation_System.UI
{
    partial class ReserationScreen
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
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_availableitems = new System.Windows.Forms.Label();
            this.lbl_searchitems = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btn_loan = new System.Windows.Forms.Button();
            this.checklist_Items = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_itemstate = new System.Windows.Forms.TextBox();
            this.txt_itemtype = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(24, 329);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(74, 13);
            this.lblReturnDate.TabIndex = 39;
            this.lblReturnDate.Text = "Palautuspäivä";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(27, 346);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnDate.TabIndex = 38;
            // 
            // lbl_availableitems
            // 
            this.lbl_availableitems.AutoSize = true;
            this.lbl_availableitems.Location = new System.Drawing.Point(24, 18);
            this.lbl_availableitems.Name = "lbl_availableitems";
            this.lbl_availableitems.Size = new System.Drawing.Size(124, 13);
            this.lbl_availableitems.TabIndex = 37;
            this.lbl_availableitems.Text = "Saatavilla olevat tuotteet";
            // 
            // lbl_searchitems
            // 
            this.lbl_searchitems.AutoSize = true;
            this.lbl_searchitems.Location = new System.Drawing.Point(313, 53);
            this.lbl_searchitems.Name = "lbl_searchitems";
            this.lbl_searchitems.Size = new System.Drawing.Size(71, 13);
            this.lbl_searchitems.TabIndex = 35;
            this.lbl_searchitems.Text = "Hae tavaroita";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(313, 70);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(140, 20);
            this.txtSearchBox.TabIndex = 34;
            // 
            // btn_loan
            // 
            this.btn_loan.Location = new System.Drawing.Point(27, 372);
            this.btn_loan.Name = "btn_loan";
            this.btn_loan.Size = new System.Drawing.Size(148, 23);
            this.btn_loan.TabIndex = 33;
            this.btn_loan.Text = "Lainaa";
            this.btn_loan.UseVisualStyleBackColor = true;
            this.btn_loan.Click += new System.EventHandler(this.btn_loan_Click);
            // 
            // checklist_Items
            // 
            this.checklist_Items.CheckOnClick = true;
            this.checklist_Items.DisplayMember = "Text";
            this.checklist_Items.FormattingEnabled = true;
            this.checklist_Items.HorizontalScrollbar = true;
            this.checklist_Items.Location = new System.Drawing.Point(24, 35);
            this.checklist_Items.Name = "checklist_Items";
            this.checklist_Items.Size = new System.Drawing.Size(280, 259);
            this.checklist_Items.TabIndex = 32;
            this.checklist_Items.SelectedValueChanged += new System.EventHandler(this.chckboxlist_Items_SelectedValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Text";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_itemstate);
            this.groupBox1.Controls.Add(this.txt_itemtype);
            this.groupBox1.Controls.Add(this.txt_itemid);
            this.groupBox1.Location = new System.Drawing.Point(310, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 100);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valitun Tavaran tiedot";
            // 
            // txt_itemstate
            // 
            this.txt_itemstate.Location = new System.Drawing.Point(7, 46);
            this.txt_itemstate.Name = "txt_itemstate";
            this.txt_itemstate.Size = new System.Drawing.Size(142, 20);
            this.txt_itemstate.TabIndex = 2;
            // 
            // txt_itemtype
            // 
            this.txt_itemtype.Location = new System.Drawing.Point(49, 20);
            this.txt_itemtype.Name = "txt_itemtype";
            this.txt_itemtype.Size = new System.Drawing.Size(100, 20);
            this.txt_itemtype.TabIndex = 1;
            // 
            // txt_itemid
            // 
            this.txt_itemid.Location = new System.Drawing.Point(7, 20);
            this.txt_itemid.Name = "txt_itemid";
            this.txt_itemid.Size = new System.Drawing.Size(36, 20);
            this.txt_itemid.TabIndex = 0;
            // 
            // ReserationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lbl_availableitems);
            this.Controls.Add(this.lbl_searchitems);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btn_loan);
            this.Controls.Add(this.checklist_Items);
            this.Name = "ReserationScreen";
            this.Text = "ReserationScreen";
            this.Load += new System.EventHandler(this.ReserationScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lbl_availableitems;
        private System.Windows.Forms.Label lbl_searchitems;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btn_loan;
        private System.Windows.Forms.CheckedListBox checklist_Items;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_itemstate;
        private System.Windows.Forms.TextBox txt_itemtype;
        private System.Windows.Forms.TextBox txt_itemid;
    }
}
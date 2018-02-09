namespace Reservation_System
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
            this.label10 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_availableitems = new System.Windows.Forms.Label();
            this.lbl_searchitems = new System.Windows.Forms.Label();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btn_loan = new System.Windows.Forms.Button();
            this.chckboxlist_Items = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Palautuspäivä";
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
            // chckboxlist_Items
            // 
            this.chckboxlist_Items.CheckOnClick = true;
            this.chckboxlist_Items.DisplayMember = "Text";
            this.chckboxlist_Items.FormattingEnabled = true;
            this.chckboxlist_Items.HorizontalScrollbar = true;
            this.chckboxlist_Items.Location = new System.Drawing.Point(24, 35);
            this.chckboxlist_Items.Name = "chckboxlist_Items";
            this.chckboxlist_Items.Size = new System.Drawing.Size(280, 259);
            this.chckboxlist_Items.TabIndex = 32;
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
            // ReserationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 410);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lbl_availableitems);
            this.Controls.Add(this.lbl_searchitems);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.btn_loan);
            this.Controls.Add(this.chckboxlist_Items);
            this.Name = "ReserationScreen";
            this.Text = "ReserationScreen";
            this.Load += new System.EventHandler(this.ReserationScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lbl_availableitems;
        private System.Windows.Forms.Label lbl_searchitems;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Button btn_loan;
        private System.Windows.Forms.CheckedListBox chckboxlist_Items;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
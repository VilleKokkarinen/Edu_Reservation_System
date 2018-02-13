namespace Reservation_System.UI
{
    partial class ItemManagement
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
            this.btn_addnewitem = new System.Windows.Forms.Button();
            this.btn_removeitem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addnewitem
            // 
            this.btn_addnewitem.Location = new System.Drawing.Point(69, 27);
            this.btn_addnewitem.Name = "btn_addnewitem";
            this.btn_addnewitem.Size = new System.Drawing.Size(88, 35);
            this.btn_addnewitem.TabIndex = 0;
            this.btn_addnewitem.Text = "Add a new item";
            this.btn_addnewitem.UseVisualStyleBackColor = true;
            this.btn_addnewitem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_removeitem
            // 
            this.btn_removeitem.Location = new System.Drawing.Point(69, 68);
            this.btn_removeitem.Name = "btn_removeitem";
            this.btn_removeitem.Size = new System.Drawing.Size(88, 35);
            this.btn_removeitem.TabIndex = 1;
            this.btn_removeitem.Text = "Remove a item";
            this.btn_removeitem.UseVisualStyleBackColor = true;
            this.btn_removeitem.Click += new System.EventHandler(this.button2_Click);
            // 
            // ItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 136);
            this.Controls.Add(this.btn_removeitem);
            this.Controls.Add(this.btn_addnewitem);
            this.Name = "ItemManagement";
            this.Text = "ItemManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addnewitem;
        private System.Windows.Forms.Button btn_removeitem;
    }
}
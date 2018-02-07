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
            this.btn_remove = new System.Windows.Forms.Button();
            this.checklist_items = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(23, 268);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(132, 39);
            this.btn_remove.TabIndex = 52;
            this.btn_remove.Text = "Poista valitut tavarat";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // checklist_items
            // 
            this.checklist_items.FormattingEnabled = true;
            this.checklist_items.Location = new System.Drawing.Point(12, 12);
            this.checklist_items.Name = "checklist_items";
            this.checklist_items.Size = new System.Drawing.Size(165, 214);
            this.checklist_items.TabIndex = 51;
            // 
            // RemovingItemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 322);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.checklist_items);
            this.Name = "RemovingItemScreen";
            this.Text = "RemovingItemScreen";
            this.Load += new System.EventHandler(this.RemovingItemScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.CheckedListBox checklist_items;
    }
}
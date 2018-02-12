namespace Reservation_System.UI
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this._MinButton = new Reservation_System.UI.ButtonZ();
            this._MaxButton = new Reservation_System.UI.MinMaxButton();
            this.WindowTextLabel = new System.Windows.Forms.Label();
            this._CloseButton = new Reservation_System.UI.ButtonZ();
            this.menuStripZ1 = new Reservation_System.UI.MenuStripZ();
            this.Tool_Strip_Loans = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_Strip_Loans_NewLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaKäyttäjänimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaSalasanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaihdaSähköpostiOsoiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RightBottomPanel_1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.RightBottomPanel_2 = new System.Windows.Forms.Panel();
            this.LeftBottomPanel_1 = new System.Windows.Forms.Panel();
            this.LeftBottomPanel_2 = new System.Windows.Forms.Panel();
            this.RightTopPanel_1 = new System.Windows.Forms.Panel();
            this.RightTopPanel_2 = new System.Windows.Forms.Panel();
            this.LeftTopPanel_1 = new System.Windows.Forms.Panel();
            this.LeftTopPanel_2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Settings = new Reservation_System.UI.ButtonX();
            this.btn_Reservation = new Reservation_System.UI.ButtonX();
            this.btn_Loans = new Reservation_System.UI.ButtonX();
            this.btn_Loan = new Reservation_System.UI.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Settings_Panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbFinnish = new System.Windows.Forms.RadioButton();
            this.Loan_Panel = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_ItemTypes = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.btn_Loanitem = new Reservation_System.UI.ShapedButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_itemstate = new System.Windows.Forms.TextBox();
            this.txt_itemtype = new System.Windows.Forms.TextBox();
            this.txt_itemid = new System.Windows.Forms.TextBox();
            this.checklist_Items = new System.Windows.Forms.CheckedListBox();
            this.panel_UserLoans = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox_itemtypes2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.shapedButton1 = new Reservation_System.UI.ShapedButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Checklist_UserLoans = new System.Windows.Forms.CheckedListBox();
            this.TopPanel.SuspendLayout();
            this.menuStripZ1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Settings_Panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Loan_Panel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel_UserLoans.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBorderPanel
            // 
            resources.ApplyResources(this.TopBorderPanel, "TopBorderPanel");
            this.TopBorderPanel.BackColor = System.Drawing.Color.Black;
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseDown);
            this.TopBorderPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseMove);
            this.TopBorderPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBorderPanel_MouseUp);
            // 
            // RightPanel
            // 
            resources.ApplyResources(this.RightPanel, "RightPanel");
            this.RightPanel.BackColor = System.Drawing.Color.Black;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // LeftPanel
            // 
            resources.ApplyResources(this.LeftPanel, "LeftPanel");
            this.LeftPanel.BackColor = System.Drawing.Color.Black;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.LeftPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.LeftPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // BottomPanel
            // 
            resources.ApplyResources(this.BottomPanel, "BottomPanel");
            this.BottomPanel.BackColor = System.Drawing.Color.Black;
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this._MinButton);
            this.TopPanel.Controls.Add(this._MaxButton);
            this.TopPanel.Controls.Add(this.WindowTextLabel);
            this.TopPanel.Controls.Add(this._CloseButton);
            this.TopPanel.Controls.Add(this.menuStripZ1);
            resources.ApplyResources(this.TopPanel, "TopPanel");
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // _MinButton
            // 
            resources.ApplyResources(this._MinButton, "_MinButton");
            this._MinButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._MinButton.DisplayText = "_";
            this._MinButton.ForeColor = System.Drawing.Color.White;
            this._MinButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._MinButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MinButton.Name = "_MinButton";
            this._MinButton.TextLocation_X = 6;
            this._MinButton.TextLocation_Y = -20;
            this.toolTip1.SetToolTip(this._MinButton, resources.GetString("_MinButton.ToolTip"));
            this._MinButton.UseVisualStyleBackColor = true;
            this._MinButton.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // _MaxButton
            // 
            resources.ApplyResources(this._MaxButton, "_MaxButton");
            this._MaxButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._MaxButton.CFormState = Reservation_System.UI.MinMaxButton.CustomFormState.Normal;
            this._MaxButton.DisplayText = "_";
            this._MaxButton.ForeColor = System.Drawing.Color.White;
            this._MaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._MaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._MaxButton.Name = "_MaxButton";
            this._MaxButton.TextLocation_X = 8;
            this._MaxButton.TextLocation_Y = 6;
            this.toolTip1.SetToolTip(this._MaxButton, resources.GetString("_MaxButton.ToolTip"));
            this._MaxButton.UseVisualStyleBackColor = true;
            this._MaxButton.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // WindowTextLabel
            // 
            resources.ApplyResources(this.WindowTextLabel, "WindowTextLabel");
            this.WindowTextLabel.ForeColor = System.Drawing.Color.White;
            this.WindowTextLabel.Name = "WindowTextLabel";
            this.WindowTextLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseDown);
            this.WindowTextLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseMove);
            this.WindowTextLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseUp);
            // 
            // _CloseButton
            // 
            resources.ApplyResources(this._CloseButton, "_CloseButton");
            this._CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this._CloseButton.DisplayText = "X";
            this._CloseButton.ForeColor = System.Drawing.Color.White;
            this._CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(160)))));
            this._CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this._CloseButton.Name = "_CloseButton";
            this._CloseButton.TextLocation_X = 6;
            this._CloseButton.TextLocation_Y = 1;
            this.toolTip1.SetToolTip(this._CloseButton, resources.GetString("_CloseButton.ToolTip"));
            this._CloseButton.UseVisualStyleBackColor = true;
            this._CloseButton.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // menuStripZ1
            // 
            resources.ApplyResources(this.menuStripZ1, "menuStripZ1");
            this.menuStripZ1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Strip_Loans,
            this.editToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripZ1.Name = "menuStripZ1";
            // 
            // Tool_Strip_Loans
            // 
            this.Tool_Strip_Loans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_Strip_Loans_NewLoan,
            this.openToolStripMenuItem});
            this.Tool_Strip_Loans.ForeColor = System.Drawing.Color.White;
            this.Tool_Strip_Loans.Name = "Tool_Strip_Loans";
            resources.ApplyResources(this.Tool_Strip_Loans, "Tool_Strip_Loans");
            // 
            // Tool_Strip_Loans_NewLoan
            // 
            this.Tool_Strip_Loans_NewLoan.ForeColor = System.Drawing.Color.White;
            this.Tool_Strip_Loans_NewLoan.Name = "Tool_Strip_Loans_NewLoan";
            resources.ApplyResources(this.Tool_Strip_Loans_NewLoan, "Tool_Strip_Loans_NewLoan");
            this.Tool_Strip_Loans_NewLoan.Click += new System.EventHandler(this.Tool_Strip_Loans_NewLoan_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.showAllItemsToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            // 
            // showAllItemsToolStripMenuItem
            // 
            this.showAllItemsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.showAllItemsToolStripMenuItem.Name = "showAllItemsToolStripMenuItem";
            resources.ApplyResources(this.showAllItemsToolStripMenuItem, "showAllItemsToolStripMenuItem");
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaihdaKäyttäjänimiToolStripMenuItem,
            this.vaihdaSalasanaToolStripMenuItem,
            this.vaihdaSähköpostiOsoiteToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            resources.ApplyResources(this.accountToolStripMenuItem, "accountToolStripMenuItem");
            // 
            // vaihdaKäyttäjänimiToolStripMenuItem
            // 
            this.vaihdaKäyttäjänimiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vaihdaKäyttäjänimiToolStripMenuItem.Name = "vaihdaKäyttäjänimiToolStripMenuItem";
            resources.ApplyResources(this.vaihdaKäyttäjänimiToolStripMenuItem, "vaihdaKäyttäjänimiToolStripMenuItem");
            // 
            // vaihdaSalasanaToolStripMenuItem
            // 
            this.vaihdaSalasanaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vaihdaSalasanaToolStripMenuItem.Name = "vaihdaSalasanaToolStripMenuItem";
            resources.ApplyResources(this.vaihdaSalasanaToolStripMenuItem, "vaihdaSalasanaToolStripMenuItem");
            // 
            // vaihdaSähköpostiOsoiteToolStripMenuItem
            // 
            this.vaihdaSähköpostiOsoiteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.vaihdaSähköpostiOsoiteToolStripMenuItem.Name = "vaihdaSähköpostiOsoiteToolStripMenuItem";
            resources.ApplyResources(this.vaihdaSähköpostiOsoiteToolStripMenuItem, "vaihdaSähköpostiOsoiteToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpContentsToolStripMenuItem,
            this.onlineHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // helpContentsToolStripMenuItem
            // 
            this.helpContentsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpContentsToolStripMenuItem.Name = "helpContentsToolStripMenuItem";
            resources.ApplyResources(this.helpContentsToolStripMenuItem, "helpContentsToolStripMenuItem");
            // 
            // onlineHelpToolStripMenuItem
            // 
            this.onlineHelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.onlineHelpToolStripMenuItem.Name = "onlineHelpToolStripMenuItem";
            resources.ApplyResources(this.onlineHelpToolStripMenuItem, "onlineHelpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            // 
            // RightBottomPanel_1
            // 
            resources.ApplyResources(this.RightBottomPanel_1, "RightBottomPanel_1");
            this.RightBottomPanel_1.BackColor = System.Drawing.Color.Black;
            this.RightBottomPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel_1.Name = "RightBottomPanel_1";
            this.RightBottomPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseDown);
            this.RightBottomPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseMove);
            this.RightBottomPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.lbl_welcome);
            this.panel2.Controls.Add(this.lbl_username);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbl_welcome
            // 
            resources.ApplyResources(this.lbl_welcome, "lbl_welcome");
            this.lbl_welcome.ForeColor = System.Drawing.Color.Silver;
            this.lbl_welcome.Name = "lbl_welcome";
            // 
            // lbl_username
            // 
            resources.ApplyResources(this.lbl_username, "lbl_username");
            this.lbl_username.ForeColor = System.Drawing.Color.Silver;
            this.lbl_username.Name = "lbl_username";
            // 
            // RightBottomPanel_2
            // 
            resources.ApplyResources(this.RightBottomPanel_2, "RightBottomPanel_2");
            this.RightBottomPanel_2.BackColor = System.Drawing.Color.Black;
            this.RightBottomPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel_2.Name = "RightBottomPanel_2";
            this.RightBottomPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseDown);
            this.RightBottomPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseMove);
            this.RightBottomPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseUp);
            // 
            // LeftBottomPanel_1
            // 
            resources.ApplyResources(this.LeftBottomPanel_1, "LeftBottomPanel_1");
            this.LeftBottomPanel_1.BackColor = System.Drawing.Color.Black;
            this.LeftBottomPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.LeftBottomPanel_1.Name = "LeftBottomPanel_1";
            this.LeftBottomPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_1_MouseDown);
            this.LeftBottomPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_1_MouseMove);
            this.LeftBottomPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_1_MouseUp);
            // 
            // LeftBottomPanel_2
            // 
            resources.ApplyResources(this.LeftBottomPanel_2, "LeftBottomPanel_2");
            this.LeftBottomPanel_2.BackColor = System.Drawing.Color.Black;
            this.LeftBottomPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.LeftBottomPanel_2.Name = "LeftBottomPanel_2";
            this.LeftBottomPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseDown);
            this.LeftBottomPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseMove);
            this.LeftBottomPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_2_MouseUp);
            // 
            // RightTopPanel_1
            // 
            resources.ApplyResources(this.RightTopPanel_1, "RightTopPanel_1");
            this.RightTopPanel_1.BackColor = System.Drawing.Color.Black;
            this.RightTopPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RightTopPanel_1.Name = "RightTopPanel_1";
            this.RightTopPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseDown);
            this.RightTopPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseMove);
            this.RightTopPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseUp);
            // 
            // RightTopPanel_2
            // 
            resources.ApplyResources(this.RightTopPanel_2, "RightTopPanel_2");
            this.RightTopPanel_2.BackColor = System.Drawing.Color.Black;
            this.RightTopPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.RightTopPanel_2.Name = "RightTopPanel_2";
            this.RightTopPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseDown);
            this.RightTopPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseMove);
            this.RightTopPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_2_MouseUp);
            // 
            // LeftTopPanel_1
            // 
            this.LeftTopPanel_1.BackColor = System.Drawing.Color.Black;
            this.LeftTopPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            resources.ApplyResources(this.LeftTopPanel_1, "LeftTopPanel_1");
            this.LeftTopPanel_1.Name = "LeftTopPanel_1";
            this.LeftTopPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_1_MouseDown);
            this.LeftTopPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_1_MouseMove);
            this.LeftTopPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_1_MouseUp);
            // 
            // LeftTopPanel_2
            // 
            this.LeftTopPanel_2.BackColor = System.Drawing.Color.Black;
            this.LeftTopPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            resources.ApplyResources(this.LeftTopPanel_2, "LeftTopPanel_2");
            this.LeftTopPanel_2.Name = "LeftTopPanel_2";
            this.LeftTopPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_2_MouseDown);
            this.LeftTopPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_2_MouseMove);
            this.LeftTopPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_2_MouseUp);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btn_Settings);
            this.panel1.Controls.Add(this.btn_Reservation);
            this.panel1.Controls.Add(this.btn_Loans);
            this.panel1.Controls.Add(this.btn_Loan);
            this.panel1.Name = "panel1";
            // 
            // btn_Settings
            // 
            this.btn_Settings.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Settings.ChangeColorMouseHC = true;
            this.btn_Settings.DisplayText = "Asetukset";
            resources.ApplyResources(this.btn_Settings, "btn_Settings");
            this.btn_Settings.ForeColor = System.Drawing.Color.White;
            this.btn_Settings.MouseClickColor1 = System.Drawing.Color.Black;
            this.btn_Settings.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.TextLocation_X = 75;
            this.btn_Settings.TextLocation_Y = 6;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Reservation.ChangeColorMouseHC = true;
            this.btn_Reservation.DisplayText = "Varaa tavaroita";
            resources.ApplyResources(this.btn_Reservation, "btn_Reservation");
            this.btn_Reservation.ForeColor = System.Drawing.Color.White;
            this.btn_Reservation.MouseClickColor1 = System.Drawing.Color.Black;
            this.btn_Reservation.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.TextLocation_X = 75;
            this.btn_Reservation.TextLocation_Y = 6;
            this.btn_Reservation.UseVisualStyleBackColor = true;
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // btn_Loans
            // 
            this.btn_Loans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Loans.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_Loans.ChangeColorMouseHC = true;
            this.btn_Loans.DisplayText = "Omat lainani";
            resources.ApplyResources(this.btn_Loans, "btn_Loans");
            this.btn_Loans.ForeColor = System.Drawing.Color.White;
            this.btn_Loans.MouseClickColor1 = System.Drawing.Color.Black;
            this.btn_Loans.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Loans.Name = "btn_Loans";
            this.btn_Loans.TextLocation_X = 75;
            this.btn_Loans.TextLocation_Y = 6;
            this.btn_Loans.UseVisualStyleBackColor = false;
            this.btn_Loans.Click += new System.EventHandler(this.btn_Loans_Click);
            // 
            // btn_Loan
            // 
            this.btn_Loan.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_Loan.ChangeColorMouseHC = true;
            this.btn_Loan.DisplayText = "Lainaa tavaroita";
            resources.ApplyResources(this.btn_Loan, "btn_Loan");
            this.btn_Loan.ForeColor = System.Drawing.Color.White;
            this.btn_Loan.MouseClickColor1 = System.Drawing.Color.Black;
            this.btn_Loan.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Loan.Name = "btn_Loan";
            this.btn_Loan.TextLocation_X = 75;
            this.btn_Loan.TextLocation_Y = 6;
            this.btn_Loan.UseVisualStyleBackColor = true;
            this.btn_Loan.Click += new System.EventHandler(this.btn_Loan_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Name = "panel3";
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.Settings_Panel, "Settings_Panel");
            this.Settings_Panel.Name = "Settings_Panel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEnglish);
            this.groupBox1.Controls.Add(this.rbFinnish);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Checked = true;
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.TabStop = true;
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbFinnish
            // 
            resources.ApplyResources(this.rbFinnish, "rbFinnish");
            this.rbFinnish.Name = "rbFinnish";
            this.rbFinnish.UseVisualStyleBackColor = true;
            // 
            // Loan_Panel
            // 
            this.Loan_Panel.Controls.Add(this.groupBox3);
            this.Loan_Panel.Controls.Add(this.btn_Loanitem);
            this.Loan_Panel.Controls.Add(this.label10);
            this.Loan_Panel.Controls.Add(this.dtpReturnDate);
            this.Loan_Panel.Controls.Add(this.groupBox2);
            this.Loan_Panel.Controls.Add(this.checklist_Items);
            resources.ApplyResources(this.Loan_Panel, "Loan_Panel");
            this.Loan_Panel.Name = "Loan_Panel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_ItemTypes);
            this.groupBox3.Controls.Add(this.txtSearchBox);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // comboBox_ItemTypes
            // 
            this.comboBox_ItemTypes.DisplayMember = "Text";
            resources.ApplyResources(this.comboBox_ItemTypes, "comboBox_ItemTypes");
            this.comboBox_ItemTypes.FormattingEnabled = true;
            this.comboBox_ItemTypes.Name = "comboBox_ItemTypes";
            // 
            // txtSearchBox
            // 
            resources.ApplyResources(this.txtSearchBox, "txtSearchBox");
            this.txtSearchBox.Name = "txtSearchBox";
            // 
            // btn_Loanitem
            // 
            this.btn_Loanitem.BackColor = System.Drawing.Color.Transparent;
            this.btn_Loanitem.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Loanitem.BorderWidth = 2;
            this.btn_Loanitem.ButtonShape = Reservation_System.UI.ShapedButton.ButtonsShapes.RoundRect;
            this.btn_Loanitem.ButtonText = "Lainaa";
            this.btn_Loanitem.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Loanitem.FlatAppearance.BorderSize = 0;
            this.btn_Loanitem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Loanitem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_Loanitem, "btn_Loanitem");
            this.btn_Loanitem.ForeColor = System.Drawing.Color.White;
            this.btn_Loanitem.GradientAngle = 90;
            this.btn_Loanitem.MouseClickColor1 = System.Drawing.Color.Black;
            this.btn_Loanitem.MouseClickColor2 = System.Drawing.Color.Black;
            this.btn_Loanitem.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Loanitem.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btn_Loanitem.Name = "btn_Loanitem";
            this.btn_Loanitem.ShowButtontext = true;
            this.btn_Loanitem.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_Loanitem.TextLocation_X = 26;
            this.btn_Loanitem.TextLocation_Y = 15;
            this.btn_Loanitem.Transparent1 = 250;
            this.btn_Loanitem.Transparent2 = 250;
            this.btn_Loanitem.UseVisualStyleBackColor = false;
            this.btn_Loanitem.Click += new System.EventHandler(this.btn_Loanitem_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Name = "label10";
            // 
            // dtpReturnDate
            // 
            resources.ApplyResources(this.dtpReturnDate, "dtpReturnDate");
            this.dtpReturnDate.Name = "dtpReturnDate";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_itemstate);
            this.groupBox2.Controls.Add(this.txt_itemtype);
            this.groupBox2.Controls.Add(this.txt_itemid);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txt_itemstate
            // 
            resources.ApplyResources(this.txt_itemstate, "txt_itemstate");
            this.txt_itemstate.Name = "txt_itemstate";
            // 
            // txt_itemtype
            // 
            resources.ApplyResources(this.txt_itemtype, "txt_itemtype");
            this.txt_itemtype.Name = "txt_itemtype";
            // 
            // txt_itemid
            // 
            resources.ApplyResources(this.txt_itemid, "txt_itemid");
            this.txt_itemid.Name = "txt_itemid";
            // 
            // checklist_Items
            // 
            this.checklist_Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checklist_Items.CheckOnClick = true;
            this.checklist_Items.DisplayMember = "Text";
            this.checklist_Items.FormattingEnabled = true;
            resources.ApplyResources(this.checklist_Items, "checklist_Items");
            this.checklist_Items.Name = "checklist_Items";
            // 
            // panel_UserLoans
            // 
            this.panel_UserLoans.Controls.Add(this.groupBox4);
            this.panel_UserLoans.Controls.Add(this.shapedButton1);
            this.panel_UserLoans.Controls.Add(this.groupBox5);
            this.panel_UserLoans.Controls.Add(this.Checklist_UserLoans);
            resources.ApplyResources(this.panel_UserLoans, "panel_UserLoans");
            this.panel_UserLoans.Name = "panel_UserLoans";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox_itemtypes2);
            this.groupBox4.Controls.Add(this.textBox1);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // comboBox_itemtypes2
            // 
            this.comboBox_itemtypes2.DisplayMember = "Text";
            resources.ApplyResources(this.comboBox_itemtypes2, "comboBox_itemtypes2");
            this.comboBox_itemtypes2.FormattingEnabled = true;
            this.comboBox_itemtypes2.Name = "comboBox_itemtypes2";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // shapedButton1
            // 
            this.shapedButton1.BackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.BorderColor = System.Drawing.Color.Transparent;
            this.shapedButton1.BorderWidth = 2;
            this.shapedButton1.ButtonShape = Reservation_System.UI.ShapedButton.ButtonsShapes.RoundRect;
            this.shapedButton1.ButtonText = "Palauta";
            this.shapedButton1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton1.FlatAppearance.BorderSize = 0;
            this.shapedButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shapedButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.shapedButton1, "shapedButton1");
            this.shapedButton1.ForeColor = System.Drawing.Color.White;
            this.shapedButton1.GradientAngle = 90;
            this.shapedButton1.MouseClickColor1 = System.Drawing.Color.Black;
            this.shapedButton1.MouseClickColor2 = System.Drawing.Color.Black;
            this.shapedButton1.MouseHoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton1.MouseHoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.shapedButton1.Name = "shapedButton1";
            this.shapedButton1.ShowButtontext = true;
            this.shapedButton1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.shapedButton1.TextLocation_X = 22;
            this.shapedButton1.TextLocation_Y = 16;
            this.shapedButton1.Transparent1 = 250;
            this.shapedButton1.Transparent2 = 250;
            this.shapedButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox4);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // Checklist_UserLoans
            // 
            this.Checklist_UserLoans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Checklist_UserLoans.CheckOnClick = true;
            this.Checklist_UserLoans.FormattingEnabled = true;
            resources.ApplyResources(this.Checklist_UserLoans, "Checklist_UserLoans");
            this.Checklist_UserLoans.Name = "Checklist_UserLoans";
            this.Checklist_UserLoans.SelectedValueChanged += new System.EventHandler(this.Checklist_UserLoans_SelectedValueChanged);
            // 
            // MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Loan_Panel);
            this.Controls.Add(this.panel_UserLoans);
            this.Controls.Add(this.Settings_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftTopPanel_2);
            this.Controls.Add(this.LeftTopPanel_1);
            this.Controls.Add(this.RightTopPanel_2);
            this.Controls.Add(this.RightTopPanel_1);
            this.Controls.Add(this.LeftBottomPanel_2);
            this.Controls.Add(this.LeftBottomPanel_1);
            this.Controls.Add(this.RightBottomPanel_2);
            this.Controls.Add(this.RightBottomPanel_1);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripZ1;
            this.Name = "MainScreen";
            this.Load += new System.EventHandler(this.BlackForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.menuStripZ1.ResumeLayout(false);
            this.menuStripZ1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.Settings_Panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Loan_Panel.ResumeLayout(false);
            this.Loan_Panel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel_UserLoans.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private ButtonZ _CloseButton;
        private System.Windows.Forms.Panel RightBottomPanel_1;
        private System.Windows.Forms.Label WindowTextLabel;
        private MinMaxButton _MaxButton;
        private System.Windows.Forms.Panel panel2;
        private ButtonZ _MinButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel RightBottomPanel_2;
        private System.Windows.Forms.Panel LeftBottomPanel_1;
        private System.Windows.Forms.Panel LeftBottomPanel_2;
        private System.Windows.Forms.Panel RightTopPanel_1;
        private System.Windows.Forms.Panel RightTopPanel_2;
        private System.Windows.Forms.Panel LeftTopPanel_1;
        private System.Windows.Forms.Panel LeftTopPanel_2;
        private System.Windows.Forms.Panel panel1;
        private ButtonX btn_Loan;
        private System.Windows.Forms.Panel panel3;
        private ButtonX btn_Loans;
        private ButtonX btn_Reservation;
        private MenuStripZ menuStripZ1;
        private System.Windows.Forms.ToolStripMenuItem Tool_Strip_Loans;
        private System.Windows.Forms.ToolStripMenuItem Tool_Strip_Loans_NewLoan;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.Panel Settings_Panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbFinnish;
        private System.Windows.Forms.Panel Loan_Panel;
        private System.Windows.Forms.CheckedListBox checklist_Items;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_itemstate;
        private System.Windows.Forms.TextBox txt_itemtype;
        private System.Windows.Forms.TextBox txt_itemid;
        private System.Windows.Forms.ComboBox comboBox_ItemTypes;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private ShapedButton btn_Loanitem;
        private System.Windows.Forms.GroupBox groupBox3;
        private ButtonX btn_Settings;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ToolStripMenuItem vaihdaKäyttäjänimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaihdaSalasanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaihdaSähköpostiOsoiteToolStripMenuItem;
        private System.Windows.Forms.Panel panel_UserLoans;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_itemtypes2;
        private System.Windows.Forms.TextBox textBox1;
        private ShapedButton shapedButton1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckedListBox Checklist_UserLoans;
    }
}
using MySql.Data.MySqlClient;
using Reservation_System.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Reservation_System.UI
{
    public partial class MainScreen : Form
    {
        private MySqlDataAdapter mydtadp = new MySqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        private MySqlDataAdapter mydtadp2 = new MySqlDataAdapter();
        private BindingSource bindingSource2 = new BindingSource();

        TypeAssistant Loan_Assistant;
        TypeAssistant UserLoans_Assistant;        
        TypeAssistant Reservation_Assistant;

        private void txt_reservation_itemsearch_TextChanged(object sender, EventArgs e)
        {
            Reservation_Assistant.TextChanged();
        }
        private void txt_UserLoans_itemsearch_TextChanged(object sender, EventArgs e)
        {
            UserLoans_Assistant.TextChanged();
        }
        private void txt_Loan_itemsearch_TextChanged(object sender, EventArgs e)
        {
            Loan_Assistant.TextChanged();
        }
        void Loan_Assistant_Idled(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                if(combobox_Loan_ItemType.SelectedItem == null)
                {
                    AvailableItemsByNameAndType(txt_LoanItem_SearchItem.Text);
                }
                
                else
                {
                    AvailableItemsByNameAndType(txt_LoanItem_SearchItem.Text, ((ComboItem)combobox_Loan_ItemType.SelectedItem).ID);
                }
            }));
        }
        void UserLoans_Assistant_Idled(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                if(combobox_UserLoans_ItemType.SelectedItem == null)
                AvailableItemsByNameAndType(txt_UserLoans_SearchItem.Text);
                else
                {
                    AvailableItemsByNameAndType(txt_UserLoans_SearchItem.Text, ((ComboItem)combobox_UserLoans_ItemType.SelectedItem).ID);
                }
            }));
        }
      
        void Reservation_Assistant_Idled(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                if(combox_reservation_itemtype.SelectedItem == null)
                    AvailableItemsByNameAndType(txt_reservation_itemsearch.Text);
                else
                {
                    AvailableItemsByNameAndType(txt_reservation_itemsearch.Text, ((ComboItem)combox_reservation_itemtype.SelectedItem).ID);                
                }
                
                
            }));
        }

        public MainScreen()
        {
            InitializeComponent();

            Loan_Assistant = new TypeAssistant();
            Loan_Assistant.Idled += Loan_Assistant_Idled;

            UserLoans_Assistant = new TypeAssistant();
            UserLoans_Assistant.Idled += UserLoans_Assistant_Idled;

            Reservation_Assistant = new TypeAssistant();
            Reservation_Assistant.Idled += Reservation_Assistant_Idled;
            
            toolstripaccount.Text = User.User._username;
            GetLoans();
            lblCurrentDate.Text = DateTime.Now.ToShortDateString();
            try

            {
                Update_ReservationsToLoans();
                if (Program.user.accounttype() >= 3)
                {                
                    UpdatePendingLoansAndReturns();
                    int pending = checklist_Waiting_PendingReturns.Items.Count + checklist_Waiting_PendingLoans.Items.Count;

                    if(pending > 1)
                    {
                        btnWaitingEvents.Text += " (" +pending + ")";
                        btnWaitingEvents.ForeColor = Color.Red;
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (Program.user.accounttype() >= 3)
            {
                btnWaitingEvents.Visible = true;
                ToolstripItems.Visible = true;
            }

        }

      

        private void BlackForm_Load(object sender, EventArgs e)
        {
            //_MaxButton.PerformClick();
        }

        #region Draggin form events

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;

        bool isRightBottomPanelDragged = false;
        bool isLeftBottomPanelDragged = false;
        bool isRightTopPanelDragged = false;
        bool isLeftTopPanelDragged = false;

        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;



        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }


        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }


        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }



        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                _MaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(_MaxButton, "Maximize");
                        _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }


        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(_MaxButton, "Restore Down");
                    _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }



        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }



        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }



        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        private void _MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(_MaxButton, "Maximize");
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(_MaxButton, "Restore Down");
                _MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = true;
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                if (this.Width < 100 || this.Height < 50)
                {
                    this.Width = 100;
                    this.Height = 50;
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    this.Height = this.Height + e.Y;
                }
            }
        }


        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }

        private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseDown(sender, e);
        }

        private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseMove(sender, e);
        }

        private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseUp(sender, e);
        }



        private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = true;
        }

        private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftBottomPanelDragged || this.Height < 50)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        this.Height = 50;
                        isLeftBottomPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Height = this.Height + e.Y;
                    }
                }
            }
        }

        private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = false;
        }

        private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseDown(sender, e);
        }

        private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseMove(sender, e);
        }

        private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseUp(sender, e);
        }




        private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = true;
        }

        private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y || e.X < this.Location.X)
            {
                if (isRightTopPanelDragged)
                {
                    if (this.Height < 50 || this.Width < 100)
                    {
                        this.Height = 50;
                        this.Width = 100;
                        isRightTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        this.Width = this.Width + e.X;
                    }
                }
            }
        }

        private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = false;
        }

        private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseDown(sender, e);
        }

        private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseMove(sender, e);
        }

        private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseUp(sender, e);
        }





        private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = true;
        }

        private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X || e.Y < this.Location.Y)
            {
                if (isLeftTopPanelDragged)
                {
                    if (this.Width < 100 || this.Height < 50)
                    {
                        this.Width = 100;
                        this.Height = 100;
                        isLeftTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }

        }

        private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = false;
        }

        private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseDown(sender, e);
        }

        private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseMove(sender, e);
        }

        private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseUp(sender, e);
        }

        #endregion

        private void itemtypes()
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {

                ComboItem def = new ComboItem();
                def.ID = 999;
                def.Text = "KAIKKI"; 
                connection.Open();                
                combobox_Loan_ItemType.Items.Clear();
                combobox_Loan_ItemType.Items.Add(def);

                combobox_UserLoans_ItemType.Items.Clear();
                combobox_UserLoans_ItemType.Items.Add(def);

                ComboBox_DeleteItemType.Items.Clear();
                ComboBox_DeleteItemType.Items.Add(def);

                ComboBoxCreateItemType.Items.Clear();
                ComboBoxCreateItemType.Items.Add(def);

                combox_reservation_itemtype.Items.Clear();
                combox_reservation_itemtype.Items.Add(def);

                using (MySqlCommand GetItemTypes = Program.sql.MySqlGetItemTypes(connection))
                {
                    MySqlDataReader reader = GetItemTypes.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string text = (string)reader["IT_NAME"];
                            int id = (int)reader["IT_ID"];
                            combobox_Loan_ItemType.Items.Add(new ComboItem { Text = text, ID = id });
                            combobox_UserLoans_ItemType.Items.Add(new ComboItem { Text = text, ID = id });
                            ComboBoxCreateItemType.Items.Add(new ComboItem { Text = text, ID = id });
                            ComboBox_DeleteItemType.Items.Add(new ComboItem { Text = text, ID = id });
                            combox_reservation_itemtype.Items.Add(new ComboItem { Text = text, ID = id });
                        }
                    }
                }
            }
        }


        #region LeftPanel_Buttons
        private void btn_Loan_Click(object sender, EventArgs e)
        {
            btn_Loan.BZBackColor = Color.Black;
            btn_Loan.ChangeColorMouseHC = false;
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
            btnWaitingEvents.BZBackColor = Color.Gray;

            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
            btnWaitingEvents.ChangeColorMouseHC = true;

            Loan_Panel.Visible = true;
            Controls.SetChildIndex(Loan_Panel, Controls.Count - 8);
            itemtypes();
            AvailableItemsByNameAndType();
        }

        private void btn_Loans_Click(object sender, EventArgs e)
        {
            btn_UsersLoans.BZBackColor = Color.Black;
            btn_UsersLoans.ChangeColorMouseHC = false;

            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
            btnWaitingEvents.BZBackColor = Color.Gray;

            btn_Loan.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
            btnWaitingEvents.ChangeColorMouseHC = true;

            UserLoans_Panel.Visible = true;
            Controls.SetChildIndex(UserLoans_Panel, Controls.Count - 8);
            itemtypes();
            GetLoans();
            GetReservations();
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            btn_Reservation.BZBackColor = Color.Black;
            btn_Reservation.ChangeColorMouseHC = false;

            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btnWaitingEvents.BZBackColor = Color.Gray;

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btnWaitingEvents.ChangeColorMouseHC = true;
            Reservation_Panel.Visible = true;
            Controls.SetChildIndex(Reservation_Panel, Controls.Count - 8);
            AvailableItemsByNameAndType();
            itemtypes();
        }


        private void Btn_Waiting_Events_Click(object sender, EventArgs e)
        {
            btnWaitingEvents.BZBackColor = Color.Black;
            btnWaitingEvents.ChangeColorMouseHC = false;
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;

            Waiting_Events_panel.Visible = true;
            Controls.SetChildIndex(Waiting_Events_panel, Controls.Count - 8);
            try
            {
                btnWaitingEvents.ForeColor = Color.White;
                btnWaitingEvents.Text = btnWaitingEvents.Text.Substring(0, 20);
                UpdatePendingLoansAndReturns();
                checkbox_AcceptAllReturns.CheckState = CheckState.Unchecked;
                checkbox_AcceptAllLoans.CheckState = CheckState.Unchecked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
        }
        private void Language_Settings_Button_Click(object sender, EventArgs e)
        {
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;

            Settings_Panel.Visible = true;
            Controls.SetChildIndex(Settings_Panel, Controls.Count - 8);
        }
        private void toolStripItemManagement_Click(object sender, EventArgs e)
        {
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;

            Item_Management.Visible = true;
            Controls.SetChildIndex(Item_Management, Controls.Count - 8);
        }

        private void ToolStripAccountManagement_Click(object sender, EventArgs e)
        {
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;

            AccountManagement_Panel.Visible = true;
            Controls.SetChildIndex(AccountManagement_Panel, Controls.Count - 8);

            if(Program.user.accounttype() >= 3)
            {
                GetUsers();
                groupBox20.Visible = true;
            } 
        }

        private void lainausHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_UsersLoans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_UsersLoans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
            
            if (Program.user.accounttype() >= 3)
            {
                LoanHistoryPanel.Visible = true;
                Controls.SetChildIndex(LoanHistoryPanel, Controls.Count - 8);
                GetAllUsers();
                GetAllItems();
            }
        }


        private void GetUsers()
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetAllUsers(connection))
                {
                    connection.Open();

                    MySqlCommandBuilder cmbl;
                    mydtadp.SelectCommand = new MySqlCommand("select U_ID, U_FIRST_NAME, U_LAST_NAME, U_EMAIL,U_USERNAME, U_ACCOUNTTYPE from USERS", connection);
                    cmbl = new MySqlCommandBuilder(mydtadp);

                    DataTable table = new DataTable();
                    mydtadp.Fill(table);

                    bindingSource1.DataSource = table;
                    datagrid_Users.DataSource = bindingSource1;
                }
                connection.Close();
            }
        }

        #endregion



        #region clickevents

        private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }

        private void shapedButton4_Click(object sender, EventArgs e)
        {

        }


        #endregion


        #region Loan panel

        private void combobox_Loan_ItemType_SelectedValueChanged(object sender, EventArgs e)
        {
            checklist_Loan_Items.Items.Clear();
            checklist_Loan_Items.DisplayMember = "NAME";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetAvailableItems(connection, txt_LoanItem_SearchItem.Text, ((ComboItem)combobox_Loan_ItemType.SelectedItem).ID))
                {
                    connection.Open();                    
                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ItemID = (int)reader["I_ID"];
                            string Itemname = (string)reader["I_NAME"];
                            int ItemType = (int)reader["I_TYPE"];
                            int ItemState = (int)reader["I_STATE"];
                            checklist_Loan_Items.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                        }
                    }
                }
                connection.Close();
            }        
        }
                
        private void AvailableItemsByNameAndType(string name = "", int type = 999)
        {
            checklist_Reservation.Items.Clear();
            checklist_Reservation.DisplayMember = "NAME";
            checklist_Loan_Items.Items.Clear();
            checklist_Loan_Items.DisplayMember = "NAME";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetAvailableItems(connection, name, type))
                {
                    connection.Open();

                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ItemID = (int)reader["I_ID"];
                            string Itemname = (string)reader["I_NAME"];
                            int ItemType = (int)reader["I_TYPE"];
                            int ItemState = (int)reader["I_STATE"];

                            checklist_Loan_Items.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                            checklist_Reservation.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void ItemsToLoan()
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand cmd = Program.sql.MySqlMakeReservation(connection))
                {
                    cmd.Parameters.AddWithValue("@user", Program.user.userid());

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error in the system");
                    }
                    connection.Close();
                }
            }

            foreach (Item item in checklist_Loan_Items.CheckedItems)
            {
                string date = dtp_Loan_ReturnDate.Value.Date.ToString("yyyy-MM-dd HH':'mm':'ss");

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {                  
                    using (MySqlCommand cmd = Program.sql.MySqlLoanItems(connection))
                    {
                        cmd.Parameters.AddWithValue("@user", Program.user.userid());
                        cmd.Parameters.AddWithValue("@itemid", item.ID);
                        cmd.Parameters.AddWithValue("@returndate", date);

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Error in the system");
                        }
                        connection.Close();
                    }
                }
            }
            MessageBox.Show("reservation(s) Created succesfully");
            AvailableItemsByNameAndType();
        }
        private void btn_Loanitem_Click(object sender, EventArgs e)
        {
            ItemsToLoan();
        }
        private void checklist_Loan_Items_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void checklist_Loan_Items_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Loan_ItemType.Text = ((User.Item)checklist_Loan_Items.SelectedItem).TYPE.ToString();
                txt_Loan_Item_State.Text = ((User.Item)checklist_Loan_Items.SelectedItem).STATE.ToString();
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemTypeName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMTYPEID", txt_Loan_ItemType.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemtype = (string)reader["IT_NAME"];
                                txt_Loan_ItemType.Text = itemtype;
                            }
                        }
                    }
                    connection.Close();
                }
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemStateName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMSTATEID", txt_Loan_Item_State.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemstate = (string)reader["IS_NAME"];
                                txt_Loan_Item_State.Text = itemstate;
                            }
                        }
                    }
                    connection.Close();
                }


                var varatut = checklist_Loan_Items.CheckedItems.Cast<User.Item>().Where(x => x.STATE == 2);
                List<DateTime> lista = new List<DateTime>();

                if (varatut.Count() == 0)
                {
                    txt_Loan_ReservedTill.Text = "";
                    dtp_Loan_ReturnDate.MaxDate = DateTime.Now.AddDays(24);
                    dtp_Loan_ReturnDate.MinDate = DateTime.Now;
                }

                foreach (Item item in varatut)
                {

                    using (MySqlConnection connection = Program.sql.MySqlConnection())
                    {
                        using (MySqlCommand ItemType = Program.sql.MySqlGetReservationDateForItem(connection))
                        {
                            ItemType.Parameters.AddWithValue("@itemid", (item.ID.ToString()));

                            connection.Open();
                            MySqlDataReader reader = ItemType.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    DateTime date = (DateTime)reader["RR_RESERVATIONDATE"];
                                    txt_Loan_ReservedTill.Text = date.ToShortDateString();
                                    lista.Add(date);
                                }
                            }
                        }
                        connection.Close();
                    }

                }

                if (lista.Count != 0)
                {
                    dtp_Loan_ReturnDate.MaxDate = lista.Min();
                    lista.Clear();
                }
                dtp_Loan_ReturnDate.MinDate = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion


        #region Reservation panel

        private void checklist_Reservation_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_reservation_Itemtype.Text = ((User.Item)checklist_Reservation.SelectedItem).TYPE.ToString();
                txt_reservation_Itemstate.Text = ((User.Item)checklist_Reservation.SelectedItem).STATE.ToString();

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemTypeName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMTYPEID", txt_reservation_Itemtype.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemtype = (string)reader["IT_NAME"];
                                txt_reservation_Itemtype.Text = itemtype;
                            }
                        }
                    }
                    connection.Close();
                }
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemStateName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMSTATEID", txt_UserLoans_ItemType.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemstate = (string)reader["IS_NAME"];
                                txt_reservation_Itemstate.Text = itemstate;
                            }
                        }
                    }
                    connection.Close();
                }

                var varatut = checklist_Reservation.CheckedItems.Cast<User.Item>().Where(x => x.STATE == 2);
                List<DateTime> lista = new List<DateTime>();

                if (varatut.Count() == 0)
                {
                    dtp_Reserve_StartDate.MaxDate = DateTime.Now.AddDays(24);
                    dtp_Reserve_StartDate.MinDate = DateTime.Now.AddDays(1);

                    dtp_Reserve_EndDate.MaxDate = DateTime.Now.AddDays(36);
                    dtp_Reserve_EndDate.MinDate = DateTime.Now.AddDays(2);

                }

                foreach (Item item in varatut)
                {
                    using (MySqlConnection connection = Program.sql.MySqlConnection())
                    {
                        using (MySqlCommand ItemType = Program.sql.MySqlGetReservationDateForItem(connection))
                        {
                            ItemType.Parameters.AddWithValue("@itemid", (item.ID.ToString()));

                            connection.Open();
                            MySqlDataReader reader = ItemType.ExecuteReader();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    DateTime date = (DateTime)reader["RR_RESERVATIONDATE"];
                                    lista.Add(date);
                                }
                            }
                        }
                        connection.Close();
                    }

                }

                if (lista.Count != 0)
                {
                    
                    dtp_Reserve_EndDate.MaxDate = lista.Min();
                    dtp_Reserve_StartDate.MaxDate = dtp_Reserve_EndDate.MaxDate;                   
                    dtp_Reserve_StartDate.MinDate = DateTime.Now;
                    lista.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void GetReservations()
        {
            try
            {
                checklist_user_reservations.Items.Clear();
                checklist_user_reservations.DisplayMember = "NAME";

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand UserLoans = Program.sql.MySqlGetUserReservations(connection))
                    {
                        UserLoans.Parameters.AddWithValue("@USER", Program.user.userid());

                        connection.Open();
                        MySqlDataReader reader = UserLoans.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int ItemID = (int)reader["I_ID"];
                                string Itemname = (string)reader["I_NAME"];
                                int ItemType = (int)reader["I_TYPE"];
                                int ItemState = (int)reader["I_STATE"];

                                // Add the item to the User's inventory
                                checklist_user_reservations.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Update_ReservationsToLoans()
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {                
                using (MySqlCommand cmd = Program.sql.MySqlGetUpdateReservationsToLoans(connection))
                {
                    connection.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }catch
                    {
                        //No items were updated, since there wasn't any to update.
                    }             
                    connection.Close();
                }
            }
        }

        private void ItemsToReserve()
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand cmd = Program.sql.MySqlMakeReservation(connection))
                {
                    cmd.Parameters.AddWithValue("@user", Program.user.userid());

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error in the system");
                    }
                    connection.Close();
                }
            }

            foreach (Item item in checklist_Reservation.CheckedItems)
            {
                string startdate = dtp_Reserve_StartDate.Value.Date.ToString("yyyy-MM-dd HH':'mm':'ss");
                string returndate = dtp_Reserve_EndDate.Value.Date.ToString("yyyy-MM-dd HH':'mm':'ss");
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand cmd = Program.sql.MySqlReserveItems(connection))
                    {
                        cmd.Parameters.AddWithValue("@user", Program.user.userid());
                        cmd.Parameters.AddWithValue("@itemid", item.ID);
                        cmd.Parameters.AddWithValue("@returndate", returndate);
                        cmd.Parameters.AddWithValue("@startdate", startdate);

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Error in the system");
                        }
                        connection.Close();
                    }
                }
                //Remove selected items from list // update list
            }
            MessageBox.Show("reservation(s) Created succesfully");
            AvailableItemsByNameAndType();
        }
        private void btn_Reserve_Click_1(object sender, EventArgs e)
        {
            ItemsToReserve();
        }

        #endregion


        #region Returning loan panel
        
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Item item in checklist_user_reservations.CheckedItems)
                {
                    using (MySqlConnection connection = Program.sql.MySqlConnection())
                    {
                        using (MySqlCommand cmd = Program.sql.MySqlCancelReservation(connection))
                        {
                            cmd.Parameters.AddWithValue("@itemid", item.ID);
                            cmd.Parameters.AddWithValue("@USER", Program.user.userid());

                            connection.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result < 0)
                            {
                                MessageBox.Show("Error in the system");
                            }
                            connection.Close();
                        }
                    }
                }
                GetReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checklist_user_reservations_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_reservation_Itemtype.Text = ((User.Item)checklist_user_reservations.SelectedItem).TYPE.ToString();
                txt_reservation_Itemstate.Text = ((User.Item)checklist_user_reservations.SelectedItem).STATE.ToString();

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemTypeName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMTYPEID", txt_reservation_Itemtype.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemtype = (string)reader["IT_NAME"];
                                txt_reservation_Itemtype.Text = itemtype;
                            }
                        }
                    }
                    connection.Close();
                }
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemStateName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMSTATEID", txt_UserLoans_ItemType.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemstate = (string)reader["IS_NAME"];
                                txt_reservation_Itemstate.Text = itemstate;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void GetLoans()
        {
            try
            {
                Checklist_UserLoans_Items.Items.Clear();
                Checklist_UserLoans_Items.DisplayMember = "NAME";

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand UserLoans = Program.sql.MySqlGetUserLoans(connection))
                    {
                        UserLoans.Parameters.AddWithValue("@USER", Program.user.userid());

                        connection.Open();
                        MySqlDataReader reader = UserLoans.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int ItemID = (int)reader["I_ID"];
                                string Itemname = (string)reader["I_NAME"];
                                int ItemType = (int)reader["I_TYPE"];
                                int ItemState = (int)reader["I_STATE"];

                                // Add the item to the User's inventory
                                Checklist_UserLoans_Items.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                            }
                        }
                    }
                    
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_UserLoans_ReturnItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (User.Item item in Checklist_UserLoans_Items.CheckedItems)
                {
                    using (MySqlConnection connection = Program.sql.MySqlConnection())
                    {
                        using (MySqlCommand cmd = Program.sql.MySqlRequestItemReturn(connection))
                        {
                            cmd.Parameters.AddWithValue("@itemid", item.ID);
                            cmd.Parameters.AddWithValue("@USER", Program.user.userid());

                            connection.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result < 0)
                            {
                                MessageBox.Show("Error in the system");
                            }
                            connection.Close();
                        }
                    }
                }
                GetLoans();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Checklist_UserLoans_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_UserLoans_ItemType.Text = ((User.Item)Checklist_UserLoans_Items.SelectedItem).TYPE.ToString();
                txt_UserLoans_ItemState.Text = ((User.Item)Checklist_UserLoans_Items.SelectedItem).STATE.ToString();

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemTypeName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMTYPEID", txt_UserLoans_ItemType.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemtype = (string)reader["IT_NAME"];
                                txt_UserLoans_ItemType.Text = itemtype;
                            }
                        }
                    }
                    connection.Close();
                }
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand Item_ReturnDate = Program.sql.MySqlGetReturnDateForItem(connection))
                    {
                        Item_ReturnDate.Parameters.AddWithValue("@USER", Program.user.userid());
                        Item_ReturnDate.Parameters.AddWithValue("@ITEMID", ((Item)Checklist_UserLoans_Items.SelectedItem).ID.ToString());

                        connection.Open();
                        MySqlDataReader reader = Item_ReturnDate.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                DateTime returndate = (DateTime)reader["RR_RETURNDATE"];
                                txt_UserLoans_ItemState.Text = returndate.ToShortDateString();
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion


        #region Pending loans and returns

        private void check_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_AcceptAllReturns.Checked == true)
            {
                for (int i = 0; i < checklist_Waiting_PendingLoans.Items.Count; i++)
                {

                    checklist_Waiting_PendingLoans.SetItemChecked(i, true);

                }
            }
            else if (checkbox_AcceptAllReturns.Checked == false)
            {
                for (int i = 0; i < checklist_Waiting_PendingLoans.Items.Count; i++)
                {
                    checklist_Waiting_PendingLoans.SetItemChecked(i, false);
                }
            }
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_AcceptAllLoans.Checked == true)
            {
                for (int i = 0; i < checklist_Waiting_PendingReturns.Items.Count; i++)
                {

                    checklist_Waiting_PendingReturns.SetItemChecked(i, true);

                }
            }
            else if (checkbox_AcceptAllLoans.Checked == false)
            {
                for (int i = 0; i < checklist_Waiting_PendingReturns.Items.Count; i++)
                {
                    checklist_Waiting_PendingReturns.SetItemChecked(i, false);
                }
            }
        }
        private void checklist_Waiting_PendingLoans_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Waiting_LoanItemType.Text = ((Item)checklist_Waiting_PendingLoans.SelectedItem).TYPE.ToString();
                txt_Waiting_LoanItemID.Text = ((Item)checklist_Waiting_PendingLoans.SelectedItem).ID.ToString();

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemLoanerAndReturnDate(connection))
                    {
                        ItemType.Parameters.AddWithValue("@itemid", ((Item)checklist_Waiting_PendingLoans.SelectedItem).ID.ToString());

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string user = (string)reader["U_USERNAME"];
                                DateTime date = (DateTime)reader["RR_RETURNDATE"];
                                txt_Waiting_LoanUserName.Text = user;
                                dtp_Waiting_LoanReturnDate.Value = date;
                            }
                        }
                    }
                    connection.Close();
                }

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemTypeName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMTYPEID", txt_Waiting_LoanItemType.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemtype = (string)reader["IT_NAME"];
                                txt_Waiting_LoanItemType.Text = itemtype;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checklist_Waiting_PendingReturns_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Waiting_ReturnItemType.Text = ((Item)checklist_Waiting_PendingReturns.SelectedItem).TYPE.ToString();
                txt_Waiting_ReturnItemID.Text = ((Item)checklist_Waiting_PendingReturns.SelectedItem).ID.ToString();

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemLoanerAndReturnDate(connection))
                    {
                        ItemType.Parameters.AddWithValue("@itemid", ((User.Item)checklist_Waiting_PendingReturns.SelectedItem).ID.ToString());

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string user = (string)reader["U_USERNAME"];
                                DateTime date = (DateTime)reader["RR_RETURNDATE"];
                                txt_Waiting_ReturnUserName.Text = user;
                                dtp_Waiting_ReturnReturnDate.Value = date;
                            }
                        }
                    }
                    connection.Close();
                }

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = Program.sql.MySqlGetItemTypeName(connection))
                    {
                        ItemType.Parameters.AddWithValue("@ITEMTYPEID", txt_Waiting_ReturnItemType.Text);

                        connection.Open();
                        MySqlDataReader reader = ItemType.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                string itemtype = (string)reader["IT_NAME"];
                                txt_Waiting_ReturnItemType.Text = itemtype;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void UpdatePendingLoansAndReturns()
        {
            checklist_Waiting_PendingLoans.Items.Clear();
            checklist_Waiting_PendingLoans.DisplayMember = "NAME";
            checklist_Waiting_PendingReturns.Items.Clear();
            checklist_Waiting_PendingReturns.DisplayMember = "NAME";

            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetPendingLoans(connection))
                {
                    connection.Open();

                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ItemID = (int)reader["I_ID"];
                            string Itemname = (string)reader["I_NAME"];
                            int ItemType = (int)reader["I_TYPE"];
                            int ItemState = (int)reader["I_STATE"];

                            checklist_Waiting_PendingLoans.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                        }
                        
                    }
                }
                connection.Close();
                using (MySqlCommand availableItems = Program.sql.MySqlGetPendingReturns(connection))
                {
                    connection.Open();

                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ItemID = (int)reader["I_ID"];
                            string Itemname = (string)reader["I_NAME"];
                            int ItemType = (int)reader["I_TYPE"];
                            int ItemState = (int)reader["I_STATE"];

                            checklist_Waiting_PendingReturns.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                        }
                    }
                    connection.Close();
                }
            }
           
                
        }

        private void Accept_Pending_Returns()
        {
            foreach (Item item in checklist_Waiting_PendingReturns.CheckedItems)
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand cmd = Program.sql.MySqlAcceptPendingReturns(connection))
                    {
                        cmd.Parameters.AddWithValue("@itemid", item.ID);

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Error in the system");
                        }
                        connection.Close();
                    }
                }
                //Remove selected items from list // update list
            }
            MessageBox.Show("reservation(s) Accepted succesfully");
            UpdatePendingLoansAndReturns();
        }

        private void btnAcceptReturn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.user.accounttype() >= 3)
                {
                    Accept_Pending_Returns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAcceptLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.user.accounttype() >= 3)
                {
                    Accept_Pending_Loans();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDenyLoan_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.user.accounttype() >= 3)
                {
                    Deny_Pending_Loans();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Deny_Pending_Loans()
        {
            foreach (User.Item item in checklist_Waiting_PendingLoans.CheckedItems)
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {                    
                    using (MySqlCommand cmd = Program.sql.MySqlDenyPendingReturns(connection))
                    {
                        cmd.Parameters.AddWithValue("@itemid", item.ID);
                        cmd.Parameters.AddWithValue("@user", Program.user.userid());

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Error in the system");
                        }
                        connection.Close();
                    }
                }
                //Remove selected items from list // update list
            }
            MessageBox.Show("reservation(s) Denied Succesfully");
            UpdatePendingLoansAndReturns();
        }

        private void Accept_Pending_Loans()
        {
            foreach (Item item in checklist_Waiting_PendingLoans.CheckedItems)
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand cmd = Program.sql.MySqlAcceptPendingLoans(connection))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@itemid", item.ID);

                            connection.Open();
                            int result = cmd.ExecuteNonQuery();

                            if (result < 0)
                            {
                                MessageBox.Show("Error in the system");
                            }
                            connection.Close();
                        }catch  (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                //Remove selected items from list // update list
            }
            MessageBox.Show("reservation(s) Accepted succesfully");
            UpdatePendingLoansAndReturns();
        }        
        #endregion


        #region Settings panel

        #endregion


        #region Account management panel
        private void kirjauduUlosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            LoginScreen l = new LoginScreen();
            l.ShowDialog();
        }

        private void btn_AM_ChangeEmail_Click(object sender, EventArgs e)
        {
            if (txt_AM_NewEmail.Text == txt_AM_NewEmail_Confirm.Text && Program.user != null)
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand cmd = Program.sql.MySqlChangeEmail(Program.user.username(), txt_AM_NewEmail_Confirm.Text, connection))
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("S-Posti vaihdettu");
                    }
                }
            }
            else
            {
                MessageBox.Show("S- Posti osoitteet eivät täsmää");
            }
        }       
        

        private void btn_AM_ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                User.User user = UserDataMapper.CreateFromDatabase(Program.user.username(), txt_AM_OldPW.Text);

                if (txt_AM_NewPW.Text == txt_AM_NewPW_Confirm.Text && user != null)
                {
                    PasswordHash hash = new PasswordHash(txt_AM_NewPW.Text);
                    byte[] hashBytes = hash.ToArray();

                    using (MySqlConnection connection = Program.sql.MySqlConnection())
                    {
                        using (MySqlCommand cmd = Program.sql.MySqlChangePassword(Program.user.username(), hashBytes, connection))
                        {               
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Salasana vaihdettu");
                            txt_AM_NewPW.Clear();
                            txt_AM_NewPW_Confirm.Clear();
                            txt_AM_OldPW.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Salasanat eivät täsmää, tai nykyinen salasana on väärin");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Salasanat eivät täsmää, tai nykyinen salasana on väärin \n\n" + ex.ToString());
            }
        }

        #endregion


        #region Item Management panel
        
        private void checklist_DeleteItem_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_CreateItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand cmd = Program.sql.MySqlAddNewItem(connection))
                    {
                        int index = ((ComboItem)ComboBoxCreateItemType.SelectedItem).ID;

                        cmd.Parameters.AddWithValue("@name", txt_CreateItemName.Text);
                        cmd.Parameters.AddWithValue("@TYPE", index.ToString());

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Error creating item");
                        }
                        else
                        {
                            MessageBox.Show("Item Created succesfully");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_CreateItemType_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand cmd = Program.sql.MySqlAddNewItemType(connection))
                {
                    cmd.Parameters.AddWithValue("@name", txt_CreateItemType.Text);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error creating new item type");
                    }
                    else
                    {
                        MessageBox.Show("Item Type Created succesfully");
                        itemtypes();
                    }
                }
                connection.Close();
            }
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            //TODO
        }


        #endregion

        #region History

        private void cb_LoanHistory_User_SelectedValueChanged(object sender, EventArgs e)
        {
            GetUsersLoanHistory(((ComboItem)cb_LoanHistory_User.SelectedItem).ID);
        }

        private void cb_LoanHistory_Item_SelectedValueChanged(object sender, EventArgs e)
        {
            GetItemsLoanHistory(((ComboItem)cb_LoanHistory_Item.SelectedItem).ID);
        }

        void GetItemsLoanHistory(int itemid)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlItemLoanhistory(connection, itemid))
                {
                    connection.Open();

                    MySqlCommandBuilder cmbl= new MySqlCommandBuilder(mydtadp2);
                    mydtadp2.SelectCommand = availableItems;
                    DataTable table = new DataTable();
                    mydtadp2.Fill(table);

                    bindingSource2.DataSource = table;
                    dataGridItemLoanHistory.DataSource = bindingSource2;
                }
                connection.Close();
            }
        }

        void GetUsersLoanHistory(int userid)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlUserLoanhistory(connection, userid))
                {
                    connection.Open();

                    MySqlCommandBuilder cmbl;

                    cmbl = new MySqlCommandBuilder(mydtadp);
                    mydtadp.SelectCommand = availableItems;
                    DataTable table = new DataTable();
                    mydtadp.Fill(table);

                    bindingSource1.DataSource = table;
                    dataGridUserLoanHistory.DataSource = bindingSource1;
                }
                connection.Close();
            }
        }

        void GetAllUsers()
        {
            cb_LoanHistory_User.Items.Clear();
            cb_LoanHistory_User.DisplayMember = "Text";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetAllUsers(connection))
                {
                    connection.Open();

                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int UserID = (int)reader["U_ID"];
                            string Username = (string)reader["U_USERNAME"];
                            cb_LoanHistory_User.Items.Add(new ComboItem {Text = Username, ID = UserID });
                        }
                    }
                }
                connection.Close();
            }
        }
        void GetAllItems()
        {
            cb_LoanHistory_Item.Items.Clear();
            cb_LoanHistory_Item.DisplayMember = "Text";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetAllItems(connection))
                {
                    connection.Open();

                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int itemid = (int)reader["I_ID"];
                            string itemname = (string)reader["I_NAME"];
                            cb_LoanHistory_Item.Items.Add(new ComboItem { Text = itemname, ID = itemid });
                        }
                    }
                }
                connection.Close();
            }
        }


        #endregion


        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exit == DialogResult.No);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dev = "Main Dev & Coder: Ville Kokkarinen\nEmail: kokkarinen.ville@gmail.com\nGithub: VilleKokkarinen\n\n";
            string devteam = "Dev Team:\nArtur Motin - UI & Code \nAnton Happonen -UI & Documenting\nOtto Tirkkonen- UI & Documenting \nTomi Oksman - Documenting";

            MessageBox.Show(dev + devteam);
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/VilleKokkarinen/Edu_Reservation_System");
        }        

        private void combox_reservation_itemtype_SelectedValueChanged(object sender, EventArgs e)
        {
            checklist_Reservation.Items.Clear();
            checklist_Reservation.DisplayMember = "NAME";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = Program.sql.MySqlGetAvailableItems(connection, txt_reservation_itemsearch.Text, ((ComboItem)combox_reservation_itemtype.SelectedItem).ID))
                {
                    connection.Open();
                    MySqlDataReader reader = availableItems.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ItemID = (int)reader["I_ID"];
                            string Itemname = (string)reader["I_NAME"];
                            int ItemType = (int)reader["I_TYPE"];
                            int ItemState = (int)reader["I_STATE"];
                            checklist_Reservation.Items.Add(new Item(ItemID, Itemname, ItemType, ItemState));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void helpContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/VilleKokkarinen/Edu_Reservation_System/blob/master/Ohje_dokumentti.pdf");
        }

        private void checklist_Reservation_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.CurrentValue == CheckState.Checked)
            {
                txt_reservation_Itemstate.Text = "";
                txt_reservation_Itemtype.Text = "";
                e.NewValue = CheckState.Unchecked;
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                txt_reservation_Itemstate.Text = "";
                txt_reservation_Itemtype.Text = "";
            }

        }

        private void checklist_Reservation_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}
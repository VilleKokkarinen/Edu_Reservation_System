﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System.UI
{
    public partial class MainScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_username.Text = "";
                lbl_welcome.Text = "Welcome";
                lbl_ReturnDate.Text = "Return date";
                btn_Loan.Text = "Loan item's";
                btn_Loans.Text = "My loan's";
                btn_Reservation.Text = "Reserve item's";
                btn_Settings.Text = "Settings";
                btn_ItemManagment.Text = "Item managment";
                btn_Loan_LoanItem.Text = "Loan";
                gBox_ItemInfo.Text = "Item info";
                gBox_SearchItem.Text = "Search item";
                WindowTextLabel.Text = "Reservation system";
            }

            else

            {
                lbl_username.Text = "";
                lbl_welcome.Text = "Tervetuloa";
                lbl_ReturnDate.Text = "Palautus pvm";
                btn_Loan.Text = "Lainaa tavaroita";
                btn_Loans.Text = "Omat lainat";
                btn_Reservation.Text = "Varaa tavaroita";
                btn_Settings.Text = "Asetukset";
                btn_ItemManagment.Text = "Tavaroiden hallinta";
                btn_Loan_LoanItem.Text = "Lainaa";
                gBox_ItemInfo.Text = "Tavaran tiedot";
                gBox_SearchItem.Text = "Hae tavaroita";
                WindowTextLabel.Text = "Varausjärjestelmä";
            }
        }
        public MainScreen()
        {
            InitializeComponent();
            lbl_username.Text = User.User._username;
            GetLoans();
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
                connection.Open();
                combobox_Loan_ItemType.Items.Clear();
                combobox_UserLoans_ItemType.Items.Clear();
                ComboBox_DeleteItemType.Items.Clear();
                ComboBoxCreateItemType.Items.Clear();
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
            btn_Loans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Settings.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_ItemManagment.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
            btn_Settings.ChangeColorMouseHC = true;

            Loan_Panel.Visible = true;
            Loan_Panel.BringToFront();
            itemtypes();
            AvailableItems();
        }

        private void btn_Loans_Click(object sender, EventArgs e)
        {
            btn_Loans.BZBackColor = Color.Black;
            btn_Loans.ChangeColorMouseHC = false;
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Settings.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_ItemManagment.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
            btn_Settings.ChangeColorMouseHC = true;

            panel_UserLoans.Visible = true;
            panel_UserLoans.BringToFront();
            itemtypes();
            GetLoans();
        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            btn_Reservation.BZBackColor = Color.Black;
            btn_Reservation.ChangeColorMouseHC = false;
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Loans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Settings.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_ItemManagment.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_Loans.ChangeColorMouseHC = true;
            btn_Settings.ChangeColorMouseHC = true;
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            btn_Settings.BZBackColor = Color.Black;
            btn_Settings.ChangeColorMouseHC = false;
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Loans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_ItemManagment.BZBackColor = Color.FromArgb(40, 40, 40);

            btn_Loan.ChangeColorMouseHC = true;
            btn_Loans.ChangeColorMouseHC = true;            
            btn_Reservation.ChangeColorMouseHC = true;

            Settings_Panel.Visible = true;
            Settings_Panel.BringToFront();
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            btn_ItemManagment.BZBackColor = Color.Black;
            btn_ItemManagment.ChangeColorMouseHC = false;
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Loans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Settings.BZBackColor = Color.FromArgb(50, 50, 50);

            btn_Loan.ChangeColorMouseHC = true;
            btn_Loans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
            btn_Settings.ChangeColorMouseHC = true;

            Item_Management.Visible = true;
            Item_Management.BringToFront();          
        }
        #endregion

        private void run_button_Click(object sender, EventArgs e)
        {
            
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Loans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);
           
            btn_Loan.ChangeColorMouseHC = true;
            btn_Loans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
           
        }

        private void help_button_Click(object sender, EventArgs e)
        {
          
            btn_Loan.BZBackColor = Color.FromArgb(40, 40, 40);
            btn_Loans.BZBackColor = Color.FromArgb(50, 50, 50);
            btn_Reservation.BZBackColor = Color.FromArgb(40, 40, 40);            
            btn_Loan.ChangeColorMouseHC = true;
            btn_Loans.ChangeColorMouseHC = true;
            btn_Reservation.ChangeColorMouseHC = true;
        }

        


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
        
        private void Tool_Strip_Loans_NewLoan_Click(object sender, EventArgs e)
        {
            btn_Loan.PerformClick();           
        }




        #endregion


        #region Loan panel
        private void AvailableItems()
        {
            checklist_Loan_Items.Items.Clear();
            checklist_Loan_Items.DisplayMember = "NAME";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = connection.CreateCommand())
                {
                    availableItems.CommandType = CommandType.Text;
                    availableItems.CommandText = "SELECT * FROM ITEMS WHERE ITEMS.I_STATE = 0";

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

                            checklist_Loan_Items.Items.Add(new User.Item(ItemID, Itemname, ItemType, ItemState));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void ItemsToLoan()
        {
            foreach (User.Item item in checklist_Loan_Items.CheckedItems)
            {
                string date = dtp_Loan_ReturnDate.Value.Date.ToString("yyyy-MM-dd HH':'mm':'ss");

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    string query = "UPDATE ITEMS SET I_STATE = 1 WHERE I_ID =@itemid;INSERT INTO RESERVATION (R_USER) VALUES (@user); INSERT INTO RESERVATIONROWS (RR_R_ID, RR_USER, RR_ITEM, RR_RESERVATIONDATE, RR_RETURNDATE, RR_RETURNED) VALUES (LAST_INSERT_ID(), @user, @itemid, CURRENT_TIMESTAMP, @returndate, 0)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
                //Remove selected items from list // update list
            }
            MessageBox.Show("reservation(s) Created succesfully");
            AvailableItems();
        }
        private void btn_Loanitem_Click(object sender, EventArgs e)
        {
            ItemsToLoan();
        }

        #endregion

        #region Reservation panel

        #endregion


        #region Returning loan panel
        private void GetLoans()
        {
            try
            {
                Checklist_UserLoans_Items.Items.Clear();
                Checklist_UserLoans_Items.DisplayMember = "NAME";

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand UserLoans = connection.CreateCommand())
                    {
                        UserLoans.CommandType = CommandType.Text;
                        UserLoans.CommandText = "SELECT * FROM ITEMS, RESERVATION, RESERVATIONROWS WHERE ITEMS.I_STATE = 1 AND RESERVATION.R_USER =@USER AND RESERVATIONROWS.RR_R_ID = RESERVATION.R_ID AND RESERVATIONROWS.RR_ITEM = ITEMS.I_ID AND RESERVATIONROWS.RR_USER =@USER AND RESERVATIONROWS.RR_RETURNED = 0";
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
                                Checklist_UserLoans_Items.Items.Add(new User.Item(ItemID, Itemname, ItemType, ItemState));
                            }
                        }
                    }
                    connection.Close();
                }
            }catch (Exception ex)
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
                        string query = "UPDATE ITEMS SET I_STATE = 0 WHERE I_ID =@itemid";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
                    using (MySqlConnection connection = Program.sql.MySqlConnection())
                    {
                        string query = "UPDATE RESERVATIONROWS SET RR_RETURNED = 1 WHERE RESERVATIONROWS.RR_RETURNED = 0 AND RR_USER =@USER AND RR_ITEM =@itemid";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Checklist_UserLoans_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_UserLoans_ItemID.Text = ((User.Item)Checklist_UserLoans_Items.SelectedItem).ID.ToString();                
                txt_UserLoans_ItemType.Text = ((User.Item)Checklist_UserLoans_Items.SelectedItem).TYPE.ToString();
                txt_UserLoans_ItemState.Text = ((User.Item)Checklist_UserLoans_Items.SelectedItem).STATE.ToString();

                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    using (MySqlCommand ItemType = connection.CreateCommand())
                    {
                        ItemType.CommandType = CommandType.Text;
                        ItemType.CommandText = "SELECT IT_NAME FROM ITEMTYPE WHERE IT_ID =@ITEMTYPEID";
                        ItemType.Parameters.AddWithValue("@USER", Program.user.userid());
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
                    using (MySqlCommand Item_ReturnDate = connection.CreateCommand())
                    {
                        Item_ReturnDate.CommandType = CommandType.Text;
                        Item_ReturnDate.CommandText = "SELECT RR_RETURNDATE FROM RESERVATIONROWS WHERE RR_ITEM =@ITEMID AND RR_RETURNED = 0 AND RR_USER =@USER";
                        Item_ReturnDate.Parameters.AddWithValue("@USER", Program.user.userid());
                        Item_ReturnDate.Parameters.AddWithValue("@ITEMID", txt_UserLoans_ItemID.Text);

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


        #region Settings panel

        #endregion


        #region Account management panel


        #endregion

        #region Item Management panel
        private void btn_CreateItem_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                string query = "INSERT INTO ITEMS (I_NAME, I_STATE, I_TYPE) VALUES (@name, 1, @TYPE)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    int index = ((ComboItem)combobox_Loan_ItemType.SelectedItem).ID;

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

        private void btn_CreateItemType_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                string query = "INSERT INTO ITEMTYPE (IT_NAME) VALUES (@name)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
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

        private void checklist_Loan_Items_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txt_Loan_ItemID.Text = ((User.Item)checklist_Loan_Items.SelectedItem).ID.ToString();                
                txt_Loan_ItemType.Text = ((User.Item)checklist_Loan_Items.SelectedItem).TYPE.ToString();
                txt_Loan_Item_State.Text = ((User.Item)checklist_Loan_Items.SelectedItem).STATE.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit?", "!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (exit == DialogResult.No);
        }

        private void vaihdaSalasanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void Loan_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vaihdaKäyttäjänimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void vaihdaSähköpostiOsoiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();
        }

        private void checklist_Loan_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

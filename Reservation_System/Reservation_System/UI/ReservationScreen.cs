using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System
{
    public partial class ReserationScreen : Form
    {
        List<ComboItem> items = new List<ComboItem>();

        public ReserationScreen()
        {
            InitializeComponent();
            CenterToScreen();  
                                  
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                connection.Open();
                items.Clear();

                using (MySqlCommand GetItemTypes = Program.sql.MySqlGetItemTypes(connection))
                {
                    MySqlDataReader reader = GetItemTypes.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string text = (string)reader["IT_NAME"];
                            int id = (int)reader["IT_ID"];
                            items.Add(new ComboItem { Text = text, ID = id });
                        }
                    }

                }
            }           
            foreach (ComboItem item in items)
            {
                comboBox1.Items.Add(item);
            }
           
        }

        private void btn_showitemdetails_Click(object sender, EventArgs e)
        {

        }

        private void AvailableItems()
        {
            chckboxlist_Items.Items.Clear();
            chckboxlist_Items.DisplayMember = "Description";
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand availableItems = connection.CreateCommand())
                {
                    availableItems.CommandType = CommandType.Text;
                    availableItems.CommandText = "SELECT * FROM ITEMS WHERE ITEMS.I_STATE = 1";

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

                            chckboxlist_Items.Items.Add(new User.LoanItem(new User.Item(ItemID, Itemname, ItemType, ItemState)));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void ReserationScreen_Load(object sender, EventArgs e)
        {
            AvailableItems();  
        }      
        private void btn_loan_Click(object sender, EventArgs e)
        {

            foreach (User.LoanItem item in chckboxlist_Items.CheckedItems)
            {
                string date = dtpReturnDate.Value.Date.ToString("yyyy-MM-dd HH':'mm':'ss");
                             
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {                  
                    string query = "UPDATE ITEMS SET I_STATE =2 WHERE I_ID =@itemid;INSERT INTO RESERVATION (R_USER) VALUES (@user); INSERT INTO RESERVATIONROWS (RR_R_ID, RR_USER, RR_ITEM, RR_RESERVATIONDATE, RR_RETURNDATE) VALUES (LAST_INSERT_ID(), @user, @itemid, CURRENT_TIMESTAMP, @returndate)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {                        
                        cmd.Parameters.AddWithValue("@user", Program.user.userid());
                        cmd.Parameters.AddWithValue("@itemid", item.ItemID);
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
    }
    class ComboItem
    {
        public string Text { get; set; }
        public int ID { get; set; }
    }
}

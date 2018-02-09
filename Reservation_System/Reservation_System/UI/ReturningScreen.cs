using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Reservation_System.UI
{
    public partial class ReturningScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                label7.Text = "Return window";
                label8.Text = "Borrowed items";               
                button7.Text = "Return";                
                button10.Text = "Show information about item";
                btn_main_returning.Text = "Main menu";
            }
            else
            {
                label7.Text = "Palautusvalikko";
                label8.Text = "Lainassa olevat tuotteet";               
                button7.Text = "Palauta";               
                button10.Text = "Näytä valitun tavaran tiedot";
                btn_main_returning.Text = "Päävälikko";
            }
        }
        public ReturningScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void GetLoans()
        {
            checkedListBox2.Items.Clear();
            checkedListBox2.DisplayMember = "Description";

            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand UserLoans = connection.CreateCommand())
                {
                    UserLoans.CommandType = CommandType.Text;
                    UserLoans.CommandText = "SELECT * FROM ITEMS, RESERVATION, RESERVATIONROWS WHERE ITEMS.I_STATE = 2 AND RESERVATION.R_USER =@USER AND RESERVATIONROWS.RR_R_ID = RESERVATION.R_ID AND RESERVATIONROWS.RR_ITEM = ITEMS.I_ID AND RESERVATIONROWS.RR_USER =@USER";
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
                            checkedListBox2.Items.Add(new User.LoanItem(new User.Item(ItemID, Itemname, ItemType, ItemState)));
                        }
                    }
                }
                connection.Close();
            }
        }

        private void ReturningScreen_Load(object sender, EventArgs e)
        {
            GetLoans();  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (User.LoanItem item in checkedListBox2.CheckedItems)
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    string query = "UPDATE ITEMS SET I_STATE = 1 WHERE I_ID =@itemid";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {                       
                        cmd.Parameters.AddWithValue("@itemid", item.ItemID);                        

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
            GetLoans();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btn_main_returning_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                UserInterFace.MainScreen();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    
}

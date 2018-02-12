using MySql.Data.MySqlClient;
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
    public partial class PreReservationScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                label23.Text = "Search";
                button17.Text = "Reserve";
                button18.Text = "Show item details";
              
            }
            else
            {
                label23.Text = "Hae tavaroita";
                button17.Text = "Varaa";
                button18.Text = "Näytä valitun tavaran tiedot";
               
            }
        }
        public PreReservationScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void btn_main_prereservation_Click(object sender, EventArgs e)
        {
            UserInterFace.MainScreen();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            foreach (User.Item item in checkedListBox4.CheckedItems)
            {
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    string query = "UPDATE ITEMS SET I_STATE = 2 WHERE I_ID =@itemid;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@user", Program.user.userid());
                        cmd.Parameters.AddWithValue("@itemid", item.ID.ToString());
                        

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
        private void AvailableItems()
        {
            checkedListBox4.Items.Clear();
            checkedListBox4.DisplayMember = "NAME";
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

                            checkedListBox4.Items.Add(new User.Item(ItemID, Itemname, ItemType, ItemState));
                        }
                    }
                }
                connection.Close();
            }
        }
        private void PreReservationScreen_Load(object sender, EventArgs e)
        {
            AvailableItems();
        }
    }
}

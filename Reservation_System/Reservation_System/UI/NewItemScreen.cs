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
    public partial class NewItemScreen : Form
    {
        List<ComboItem> items = new List<ComboItem>();

        void updatetypes()
        {            
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                connection.Open();
                items.Clear();
                comboBox1.Items.Clear();

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

        public NewItemScreen()
        {
            InitializeComponent();
            CenterToScreen();         
        }
        void language()
        {
            if (Program.Settings.English == true)
            {

                lbl_name.Text = "Name";
                lbl_type.Text = "Type";
                btn_addtodatabase.Text = "Add to database";
            }
            else
            {
                lbl_name.Text = "Nimi";
                lbl_type.Text = "Tyyppi";
                btn_addtodatabase.Text = "Lisää tietokantaan";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                string query = "INSERT INTO ITEMS (I_NAME, I_STATE, I_TYPE) VALUES (@name, 1, @TYPE)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {

                    int index = ((ComboItem)comboBox1.SelectedItem).ID;

                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
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
                        updatetypes();
                    }
                }
                connection.Close();
            }
        
    }

        private void NewItemScreen_Load(object sender, EventArgs e)
        {
            updatetypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                string query = "INSERT INTO ITEMTYPE (IT_NAME) VALUES (@name)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@name", textBox1.Text); 

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error creating new item type");
                    }
                    else
                    {                        
                        MessageBox.Show("Item Type Created succesfully");
                        updatetypes();
                    }
                }
                connection.Close();
            }
        }
    }
    class ComboItem
    {
        public string Text { get; set; }
        public int ID { get; set; }
    }
}

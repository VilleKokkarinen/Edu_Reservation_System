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

        public NewItemScreen()
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
                            string text = (string)reader["IS_NAME"];
                            items.Add(new ComboItem { Text = text });
                        }
                    }

                }
            }
            foreach (ComboItem item in items)
            {
                comboBox1.Items.Add(item.Text);
            }
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

        }

        private void NewItemScreen_Load(object sender, EventArgs e)
        {

        }
    }
    class ComboItem
    {
        public string Text { get; set; }
    }
}

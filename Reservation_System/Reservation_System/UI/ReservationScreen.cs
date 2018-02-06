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

        private void btn_showitemdetails_Click(object sender, EventArgs e)
        {

        }

        private void ReserationScreen_Load(object sender, EventArgs e)
        {
           foreach (User.LoanItem item in Program.user.AvailableItems)
            {
                chckboxlist_Items.Items.Add(item.Description);
            }           
                      
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {

        }

        private void ReserationScreen_Leave(object sender, EventArgs e)
        {
            chckboxlist_Items.Text = String.Empty;
        }

        private void ReserationScreen_Leave(object sender, FormClosedEventArgs e)
        {
            
        }

        private void chckboxlist_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void CleareAllcontrolsRecursive(Control container)
        {
            foreach (var control in container.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Text = string.Empty;
                }
            }
        }
    }
    class ComboItem
    {
        public string Text { get; set; }
    }
}

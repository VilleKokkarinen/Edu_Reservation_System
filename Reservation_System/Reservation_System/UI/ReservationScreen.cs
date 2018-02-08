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
                comboBox1.Items.Add(item.Text);
            }

        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_availableitems.Text = "Item's avalaible";
                lbl_searchitems.Text = "Search items";

                lbl_returndate.Text = "Return date";
                btn_loan.Text = "Loan";
                btn_showitemdetails.Text = "Show item details";
            }
            else
            {
                lbl_availableitems.Text = "Saatavilla olevat tuotteet";
                lbl_searchitems.Text = "Hae tuotteita";
                lbl_returndate.Text = "Palautus päivämäärä";
                btn_loan.Text = "Lainaa";
                btn_showitemdetails.Text = "Näytä valitun esineen tiedot";
            }
        }
        private void btn_showitemdetails_Click(object sender, EventArgs e)
        {

        }

        private void ReserationScreen_Load(object sender, EventArgs e)
        {
            items.Clear();
            chckboxlist_Items.Items.Clear();
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

        private void btn_loan_Click(object sender, EventArgs e)
        {

        }
    }
    class ComboItem
    {
        public string Text { get; set; }
        public int ID { get; set; }
    }
}

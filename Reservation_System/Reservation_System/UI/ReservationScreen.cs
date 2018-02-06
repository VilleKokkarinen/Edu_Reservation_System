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
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_availableitems.Text = "Available items";
                lbl_searchitems.Text = "Search items";
                label10.Text = "Return date";
                btn_showitemdetails.Text = "Show item details";
                btn_loan.Text = "Loan";
            }
            else
            {
                lbl_availableitems.Text = "Saatavilla olevat tuottet";
                lbl_searchitems.Text = "Hae tavaroita";
                label10.Text = "Palautuspäivä";
                btn_showitemdetails.Text = "Näytä valitun tavaran tiedot";
                btn_loan.Text = "Lainaa";
            }
        }
        public ReserationScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_showitemdetails_Click(object sender, EventArgs e)
        {

        }

        private void ReserationScreen_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = Program.sql.Accessconnection();
            OleDbCommand cmd = Program.sql.AccessGetAvailableItems(connection);

            connection.Open();

            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            string value = "";

            while (reader.Read())
            {
                if (reader.HasRows)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        value += " - " +reader.GetValue(i).ToString();
                        
                    }
                    chckboxlist_Items.Items.Add(value);
                    value = "";
                }
            }
                        connection.Close();

            
              
                      
        }
    }
}

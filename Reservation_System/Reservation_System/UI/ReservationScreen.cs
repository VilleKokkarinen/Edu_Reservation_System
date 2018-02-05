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

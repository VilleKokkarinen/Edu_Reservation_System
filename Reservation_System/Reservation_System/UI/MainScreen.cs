using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Reservation_System.UI;

namespace Reservation_System
{
    public partial class MainScreen : Form
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog = master;
                    Integrated Security = True;
                    Connect Timeout = 30;
                    Encrypt=False;
                    TrustServerCertificate=True;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False";

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {            
            //txt_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(cs);

            SqlCommand cmd = new SqlCommand("Select * from USERS where U_USERNAME=@username and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);

            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            connection.Close();

            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count == 1)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                SettingsScreen SS = new SettingsScreen();
                SS.Show();
            }
            else
            {
                MessageBox.Show("Login Failed!");
                
            }
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "GUEST")
                txt_username.Text = "";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsScreen _SettingsScreen = new SettingsScreen();
            _SettingsScreen.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.ShowDialog();
        }
    }
}

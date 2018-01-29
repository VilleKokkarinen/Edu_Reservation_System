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
using FirebirdSql.Data.Client;
using FirebirdSql.Data.FirebirdClient;

namespace Reservation_System
{
    public partial class MainScreen : Form
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog = RESERVATIONSYSTEM;
                    Integrated Security = True;
                    Connect Timeout = 30;
                    Encrypt=False;
                    TrustServerCertificate=True;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False";


        public MainScreen()
        {
            InitializeComponent();

            cs = @"User=SYSDBA;Password=kokkarinen;Database=37.219.31.104:D:\data\reservationsystem.fdb;DataSource=37.219.31.104;
                Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;
                MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
         }

        private void MainScreen_Load(object sender, EventArgs e)
        {            
            //txt_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            FbConnection connection = new FbConnection(cs);

            FbCommand cmd = new FbCommand("Select * from USERS where U_USERNAME=@username and U_PASSWORD=@password", connection);
            cmd.Parameters.AddWithValue("@username", txt_username.Text);
            cmd.Parameters.AddWithValue("@password", txt_password.Text);

            connection.Open();

            FbDataAdapter adapter = new FbDataAdapter(cmd);
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

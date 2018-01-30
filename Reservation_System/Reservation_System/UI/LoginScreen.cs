using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data.SqlClient;

namespace Reservation_System.UI
{
    public partial class LoginScreen : Form
    {
        bool txt_password_enabled_checker = true;      

        string cs = "";

            public LoginScreen()
            {
                InitializeComponent();

                cs = @"User=SYSDBA;Password=kokkarinen;Database=192.168.43.227:D:\data\reservationsystem.fdb;DataSource=192.168.43.227;
                Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;
                MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";
            }        

        private void btn_login_Click_2(object sender, EventArgs e)
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
                this.Hide();
                UserInterFace.MainScreen();
            }
            else
            {
                lbl_invalid_login_credentials.Visible = true;
            }
        }

        private void txt_password_Enabled(object sender, EventArgs e)
        {
            lbl_invalid_login_credentials.Visible = false;

            if (txt_password_enabled_checker == true)
            {
                txt_password.Text = "";
                txt_password.PasswordChar = '*';
                txt_password.Font = new Font("Microsoft Sans Serif", txt_password.Font.Size);
                txt_password_enabled_checker = false;
            }
        }

        private void btnforgotpassword_Click(object sender, EventArgs e)
        {
            UserInterFace.ForgotPasswordScreen();
        }
    }
}
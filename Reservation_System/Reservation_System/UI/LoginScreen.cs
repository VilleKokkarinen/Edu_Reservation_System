﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace Reservation_System.UI
{
    public partial class LoginScreen : Form
    {
            string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                    Initial Catalog = RESERVATIONSYSTEM;
                    Integrated Security = True;
                    Connect Timeout = 30;
                    Encrypt=False;
                    TrustServerCertificate=True;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False";

            public LoginScreen()
            {
                InitializeComponent();

                cs = @"User=SYSDBA;Password=kokkarinen;Database=224.0.0.22:D:\data\reservationsystem.fdb;DataSource=224.0.0.22;
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
    }
}
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
               
        protected void Center()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }

        public LoginScreen()
            {
                InitializeComponent();                       
                Center();               
            }        

        private void login()
        {
            SQL sql = new SQL();

            FbConnection connection = sql.FBconnection();

            FbCommand cmd = sql.userlogin(txt_username.Text, txt_password.Text, connection);

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

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
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

        private void lblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInterFace.ForgotPasswordScreen();
        }
    }
}
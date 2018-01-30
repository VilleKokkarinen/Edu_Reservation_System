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


namespace Reservation_System.UI
{
    public partial class RegisterUser : Form
    {
        string cs = @"User=SYSDBA;Password=kokkarinen;Database=192.168.43.227:D:\data\reservationsystem.fdb;DataSource=192.168.43.227;
                Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=15;Pooling=true;
                MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;";

        public RegisterUser()
        {
            InitializeComponent();
            CenterToScreen();
        }

        

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_email.Text == "" || txt_firstname.Text == "" || txt_password.Text == "" || txt_surname.Text == "" ||txt_username.Text == "")
            {
                MessageBox.Show("Please, fill all the details");
            }
            else if(txt_password.TextLength <= 5)
            {
                MessageBox.Show("Password must be atleast 6 characters long");
            }
            else
            { 
                using (SqlConnection connection = new SqlConnection(cs))
                {

                 string query = "INSERT INTO USERS (U_FIRST_NAME, U_LAST_NAME, U_EMAIL,U_USERNAME, U_PASSWORD, U_ACCOUNTTYPE) VALUES (@firstname, @lastname, @email, @username, @password, 2)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", txt_surname.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                            MessageBox.Show("Error creating user");
                    }                      
                }
            }
        }
    }
}

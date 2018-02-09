using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Reservation_System.UI
{
    public partial class RegisterUser : Form
    {        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_username.Text = "Username";
                lbl_password.Text = "Password";                
                lbl_firstname.Text = "First name";
                lbl_lastname.Text = "Last name";
                lbl_email.Text = "Email-address";
                Text = "Register";
            }
            else
            {
                lbl_username.Text = "Käyttäjänimi";
                lbl_password.Text = "Salasana";
                lbl_firstname.Text = "Etunimi";
                lbl_lastname.Text = "Sukunimi";
                lbl_email.Text = "Sähköposti- osoite";
                Text = "Rekisteröityminen";
            }
        }
       
        public RegisterUser()
        {
            InitializeComponent();
            CenterToScreen();
            language();
        }
        

        private void btn_register_Click(object sender, EventArgs e)
        {
            //TODO !CHECK! if the username is already being used & deny the creation with a proper message to the user.
            // "Username is already taken" - eg

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
                
                using (MySqlConnection connection = Program.sql.MySqlConnection())
                {
                    //Check before doing the query, if the username is already taken

                    string query = "INSERT INTO USERS (U_FIRST_NAME, U_LAST_NAME, U_EMAIL,U_USERNAME, U_PASSWORD, U_ACCOUNTTYPE) VALUES (@firstname, @lastname, @email, @username, @password, 2)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@firstname", txt_firstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", txt_surname.Text);
                        cmd.Parameters.AddWithValue("@email", txt_email.Text);
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.Parameters.AddWithValue("@password", txt_password.Text);

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result < 0)
                        {
                            MessageBox.Show("Error creating user");
                        }
                        else
                        {
                            MessageBox.Show("User: " + txt_username.Text + "\nCreated succesfully");
                        }
                    }                      
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

using MySql.Data.MySqlClient;
using Reservation_System.User;

namespace Reservation_System.UI
{
    public partial class ForgotPasswordScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                btn_recover.Text = "Recover password";
                lbl_email.Text = "Email";
                lbl_username.Text = "Username";
            }
            else
            {
                btn_recover.Text = "Palauta salasana";
                lbl_email.Text = "Sähköposti";
                lbl_username.Text = "Käyttäjänimi";
            }
        }
        string newpassword = "";
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZqwertyuiopasdfghjklzxcvbnm".ToCharArray();
        public ForgotPasswordScreen()
        {
            InitializeComponent();
            CenterToScreen();
            language();          
        }

        private void checkuser()
        {
            Cursor = Cursors.WaitCursor;
            try
            {

                MySqlConnection connection = Program.sql.MySqlConnection();
                MySqlCommand cmd = Program.sql.MySqlSelectUserByUserNameAndEmail(txt_username.Text, txt_email.Text, connection);

                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();

                int count = ds.Tables[0].Rows.Count;
               
                if (count == 1)
                {                   
                    this.Hide();

                    Random r = new Random();

                    for(int i = 0; i < 7; i ++)
                    {
                        newpassword += alphabet[r.Next(0,alphabet.Count()-1)];
                    }

                    Email.Email email = new Email.Email(txt_email.Text, "Password reset request", "Your account "+ txt_username.Text + "'s password has had a reset request.\n\n\n" +
                        "New randomly generated password: " + newpassword + "\n\n" +
                        "Change the password ASAP, during first login.\n\n\n" +
                        "Email sent from -Insert Software name here-\n" +
                        "@ " + DateTime.Now + " " + TimeZone.CurrentTimeZone.StandardName);
                        email.send();
                        changepassword();
                }
                else
                {
                    MessageBox.Show("No user found with provided information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            Cursor = Cursors.Default;
        }

        private void changepassword()
        {
            PasswordHash hash = new PasswordHash(newpassword);
            byte[] hashBytes = hash.ToArray();

            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                using (MySqlCommand cmdnewpw = Program.sql.MySqlChangePassword(txt_username.Text, hashBytes, connection))
                {
                    connection.Open();

                    int result = cmdnewpw.ExecuteNonQuery();

                    connection.Close();
                    if (result < 0)
                    {
                        MessageBox.Show("Error changing password");
                    }
                    else
                    {
                        MessageBox.Show("User: " + txt_username.Text + "'s\n New password has been sent to their email address!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuser();                   
        }
    }
}

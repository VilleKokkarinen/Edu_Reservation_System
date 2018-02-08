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
using System.Data.SqlClient;
using System.Windows.Input;
using System.Data.OleDb;

namespace Reservation_System.UI
{
    public partial class LoginScreen : Form
    {
        void language()
        {
            if(Program.Settings.English == true)
            {
                lbl_invalid_login_credentials.Text = "Login - credentials invalid!";
                lblforgotpassword.Text = "Forgot password?";
                txt_password.Text = "password";
                chkbox_remember_user.Text = "Remember user";
                btn_login.Text = "Login";
                btn_registeruser.Text = "Register new user";
            }
            else
            {
                lbl_invalid_login_credentials.Text = "Sisäänkirjautumistiedot väärin!";
                lblforgotpassword.Text = "Unohditko salasanan?";
                txt_password.Text = "salasana";
                chkbox_remember_user.Text = "Muista käyttäjä";
                btn_login.Text = "Kirjaudu";
                btn_registeruser.Text = "Rekisteröi uusi käyttäjä";
                this.Text = "Sisäänkirjautuminen";
            }
        }

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
                language();

                if(Program.Settings.RememberUserName == true)
                {
                    chkbox_remember_user.Checked = true;
                    txt_username.Text = Program.Settings.Username;
                txt_password.Select();

                }             
            }        


        private void ACCESSlogin()
        {
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            try
            {
                OleDbConnection connection = Program.sql.Accessconnection();
                OleDbCommand cmd = Program.sql.Accesslogin(txt_username.Text, txt_password.Text, connection);

                connection.Open();

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    Program.User = new User(txt_username.Text);
                    this.Hide();
                    UserInterFace.MainScreen();
                }
                else
                {
                    lbl_invalid_login_credentials.Visible = true;
                }
            }
            catch
            {
                //do something with the error code ex
            }

            Cursor = System.Windows.Forms.Cursors.Default;
        }


        private void FBlogin()
        {
            Cursor = System.Windows.Forms.Cursors.WaitCursor;
            try
            {                
                FbConnection connection = Program.sql.FBconnection();
                FbCommand cmd = Program.sql.FBuserlogin(txt_username.Text, txt_password.Text, connection);

                connection.Open();

                FbDataAdapter adapter = new FbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                connection.Close();

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    Program.User = new User(txt_username.Text);
                    this.Hide();
                    UserInterFace.MainScreen();
                }
                else
                {
                    lbl_invalid_login_credentials.Visible = true;
                }
            }
            catch
            {
                ACCESSlogin();
            }
            

            Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                ACCESSlogin();                
            }catch
            {
                FBlogin();
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

        private void lblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserInterFace.ForgotPasswordScreen();
        }

        private void txt_password_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                btn_login.PerformClick();
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.Settings.RememberUserName = chkbox_remember_user.Checked;
            

            if(Program.Settings.RememberUserName == true && txt_username.Text != "")
            {
                Program.Settings.Username = txt_username.Text;
            }

            Program.Settings.SaveFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInterFace.RegisterUserScreen();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reservationsystemDataSet.USERS' table. You can move, or remove it, as needed.
           

        }
    }
}
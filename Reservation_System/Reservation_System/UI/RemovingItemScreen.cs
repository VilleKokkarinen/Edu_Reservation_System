﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_System.UI
{
    public partial class RemovingItemScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {               
                btn_remove.Text = "Remove selected item";
            }
            else
            {               
                btn_remove.Text = "Poista valittu tuote";
            }
        }

        public RemovingItemScreen()
        {
            InitializeComponent();
            CenterToScreen();

            checklist_items.Items.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void RemovingItemScreen_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Program.sql.MySqlConnection())
            {
                connection.Open();


                using (MySqlCommand Items = Program.sql.MySqlGetAllItems(connection))
                {
                    MySqlDataReader reader = Items.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int ItemID = (int)reader["I_ID"];
                            string Itemname = (string)reader["I_NAME"];
                            int ItemType = (int)reader["I_TYPE"];
                            int ItemState = (int)reader["I_STATE"];

                            checklist_items.Items.Add("[" + ItemID +"] " + "["+ Itemname +"] "+ "[" + ItemType + "] "+ "[" + ItemState + "] ");
                        }
                    }
                }
            }
        }
        void language()
        {
            if (Program.Settings.English == true)
            {
                lbl_SearchItem.Text = "Search item";
                checkboxlist_DeleteItem.Text = "Delete item";
                btn_Delete.Text = "Delete";
                btn_SearchItem.Text = "Search";
            }
            else
            {
                lbl_SearchItem.Text = "Hae tavara";
                checkboxlist_DeleteItem.Text = "Poista tavara";
                btn_Delete.Text = "Poista";
                btn_SearchItem.Text = "Hae";
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}

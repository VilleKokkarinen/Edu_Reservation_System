﻿using System;
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
    public partial class ItemManagement : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                button1.Text = "Add a new item";
                button2.Text = "Remove an item";
            }
            else
            {
                button1.Text = "Lisää tavara";
                button2.Text = "Poista tavara";
            }
        }
        public ItemManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInterFace.NewItemScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInterFace.RemovingItemScreen();
        }

        private void btn_main_itemman_Click(object sender, EventArgs e)
        {
            UserInterFace.MainScreen();
        }
    }
}
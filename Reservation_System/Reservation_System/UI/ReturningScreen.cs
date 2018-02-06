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
    public partial class ReturningScreen : Form
    {
        void language()
        {
            if (Program.Settings.English == true)
            {
                label7.Text = "Return window";
                label8.Text = "Borrowed items";
                label9.Text = "Search items";
                button7.Text = "Return";
                button8.Text = "Search";
                button10.Text = "Show information about item";
            }
            else
            {
                label7.Text = "Palautusvalikko";
                label8.Text = "Lainassa olevat tuotteet";
                label9.Text = "Hae tavaroita";
                button7.Text = "Palauta";
                button8.Text = "Hae";
                button10.Text = "Näytä valitun tavaran tiedot";
            }
        }
        public ReturningScreen()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ReturningScreen_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
